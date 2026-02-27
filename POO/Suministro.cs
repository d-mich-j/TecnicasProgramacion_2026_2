
//Programa principal
Inventario inventario = new Inventario();

bool salir = false;

while (!salir) {

    Console.WriteLine("Menu \n Seleccione la opcion que desea");
    Console.WriteLine("     1. Mostrar ");
    Console.WriteLine("     2. Buscar");
    Console.WriteLine("     3. Ordenar por nombre");
    Console.WriteLine("     4. Invertir orden");
    Console.WriteLine("     5. Vaciar inventario");
    Console.WriteLine("     6. Agregar suministro");
    Console.WriteLine("     7. Eliminar suministro");
    Console.WriteLine("     8. Salir");

    int opcion = int.Parse(Console.ReadLine()??"");

    switch (opcion) {
        case 1:
            inventario.MostrarSuministros();
            break;
        case 2:
            Console.WriteLine("Ingresa el suministro a buscar:");
            String nombre = Console.ReadLine()??"";
            inventario.BuscarSuministro(nombre);
            break;
        case 3:
            inventario.OrdenarPorNombre();

            break;
        case 4:
            inventario.InvertirOrden();
            break;
        case 5:
            inventario.VaciarInventario();
            break;
        case 6:
            Console.WriteLine("Ingresa el nombre del suministro a agregar :");
            String nombreSum = Console.ReadLine() ??"";
            
            Console.WriteLine("antidad o vacio");
            String cantidad = Console.ReadLine() ?? "";

            if (cantidad != "") {
                Console.WriteLine("Prioridad o vacio");
                string prioridad = Console.ReadLine() ?? "";
                
                inventario.AgregarSuministros(nombreSum, int.Parse(cantidad), int.Parse (prioridad));



            } else {
                inventario.AgregarSuministro(nombreSum);
            }

                break;
        case 7:
            Console.WriteLine("Ingresa el nombre del suministro a eliminar :");
            String nombreElim = Console.ReadLine() ?? "";
            inventario.EliminarSuministro(nombreElim);
            break;
        case 8:
            salir = true;
            break;
        default:
            Console.WriteLine("No existe esa opcion");
            break;

            

    }

}




public class Suministro 
{
    //atributos
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public int Prioridad { get; set; }

    //metodos

    public void MostrarInfo() {
        Console.WriteLine($"{Nombre}, Cantidad{Cantidad}, Prioridad{Prioridad}");
    }

    //constructor 
    public Suministro(string nombre, int cantidad, int prioridad) 
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Prioridad = prioridad;


    }
    //Sobrecarga constructor
    public Suministro(string nombre) {
        Nombre = nombre;
        Cantidad = 1;
        Prioridad = 2;

    }
}
 public class Inventario {
    
    //Atributos 
    private Suministro[] suministros;

    //Metodo 
    public void MostrarSuministros() 
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Inventario de suministros:");
        Console.ForegroundColor = ConsoleColor.Red;

        foreach (Suministro suministro in suministros) {
            suministro.MostrarInfo();
        }
    }
    public void BuscarSuministro(string nombre) {

        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());



        if (indice >=0) {
            Console.WriteLine ($"{nombre} se encontro en la posicion { indice}");
        }else {
            Console.WriteLine($"{nombre} no se encontro en el inventario");
        }
    }

    public void OrdenarPorNombre() {
        Array.Sort(suministros,(x,y) => x.Nombre.CompareTo(y.Nombre));
        Console.WriteLine("Suinistros ordenados por nombre");
    }
    public void InvertirOrden() {
        Array.Reverse(suministros);
        Console.WriteLine("Orden invertido");
    }
    public void VaciarInventario() {
        Array.Clear(suministros,0,suministros.Length);
        Console.WriteLine($"Inventario borrado:{suministros.Length}");
    }
    //Agregar suministros

    public void AgregarSuministros(string nombre, int cantidad, int prioridad) {
        int indiceNull = Array.FindIndex(suministros, s => s == null);
        if (indiceNull >= 0) {
            suministros[indiceNull] = new Suministro(nombre, cantidad, prioridad);
        }
        else {
            Array.Resize(ref suministros, suministros.Length +1 );
            suministros[suministros.Length - 1] = new Suministro(nombre, cantidad, prioridad);
            Console.WriteLine($"{nombre} agragado al inventario");
        }
    }

    public void AgregarSuministro(string nombre) {
        AgregarSuministros(nombre,1,2);
    }
    //Eliminar suministros

    public void EliminarSuministro(string nombre) {
        int indice = Array.FindIndex(suministros, s => s.Nombre.ToLower() == nombre.ToLower());
        if (indice >=0) {
            for (int i = indice; i < suministros.Length - 1; i++) {
                suministros[i] = suministros[i + 1];
            }

            Array.Resize(ref suministros, suministros.Length - 1);
            Console.WriteLine($"{nombre} se elimino del inventario");
        }
    }




    //Constructor
    public Inventario() {
        suministros = new Suministro[]
        {
            new Suministro ("Oxigeno",15,1),
            new Suministro ("Gasolina"),
            new Suministro ("Comida",30,1),
            new Suministro ("Almohada",15,3),
            new Suministro ("Botiquin",4,1),
            new Suministro ("Herramientas")
        }; 
    }
}
