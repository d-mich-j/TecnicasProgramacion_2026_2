//Implementaciones del juego 

using static System.Runtime.InteropServices.JavaScript.JSType;

try {
    Console.WriteLine("BINVENIDO AL TORNEO DE GUERREROS ");
    string nombre = ObtenerNombre();

    Guerrero jugador = SeleccionarClase(nombre);
    Guerrero enemigo = GeneraEnemigo();

    Console.WriteLine($"Te enfrentaras a {enemigo.Nombre}");

    while (enemigo.Vida > 0 && jugador.Vida >0) {
        MostrarEstado(jugador, enemigo);
        string opcion = ObtenerOpcion();

        switch (opcion) {
            case "1":
                jugador.Atacar(enemigo);
                break;
            case "2":
                Console.WriteLine($"{jugador.Nombre} se defiende y se reduce");
                enemigo.Atacar(jugador);
                jugador.Recibirdanio(jugador.Ataque/2);
                break;
            case "3":
                Console.WriteLine("Intentando la fusion");
                if(new Random().Next(1,100) > 50) {
                    jugador = jugador + enemigo;
                    Console.WriteLine($"Tu nuevo nombre es {jugador.Nombre} | {jugador.Vida} | {jugador.Ataque}");

                }else {
                    Console.WriteLine("La fusion fallo y perdiste vida");
                    jugador.Recibirdanio(jugador.Vida / 2);
                }
                    break;
            default:
                throw new ArgumentException("Opcion invalida");

        }


        if (enemigo.Vida > 0) {
            enemigo.Atacar(jugador):; 
        }
    }
    
} catch {

}

//Apartado de funciones 
static string ObtenerNombre() {
    while (true) {
        try {
            Console.WriteLine("Ingresa nombre del guerrero: ");
            string nombre = Console.ReadLine() ?? "".Trim();
            if (string.IsNullOrEmpty(nombre)) {
                throw new ArgumentException("Elnombre no puede estar vacio ");
            }return nombre;
        } 
        catch (Exception ex ) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

static string  ObtenerOpcion() {
    while (true) {
        try {
            Console.WriteLine("Ingresa que quieres hacer: ");
            string opcion = Console.ReadLine() ?? "".Trim();
            if (opcion != "1" && opcion != "2" && opcion != "3") {
                throw new ArgumentException("Opcion invalida, debes de ingresar 1,2 o 3");
            }
            return opcion;
        }catch (Exception ex) {
            Console.WriteLine($"eRROR:{ex.Message}");
        }
    }
} 

static Guerrero SeleccionarClase(string nombre) {
    while (true) {
        try {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("SELECCIONA TU CLASE ");
            Console.WriteLine("     1. Caballero ");
            Console.WriteLine("     2. Mago");
            Console.WriteLine("     3. Arquero");
            Console.WriteLine("     4. Guerrero sombra");

            string opcion = Console.ReadLine() ?? "";
            return opcion switch
            {
                "1" => new Caballero(nombre),
                "2" => new Mago(nombre),
                "3" => new Arquero(nombre),
                "4" => new GuerreroSombra(nombre),
                _ => throw new ArgumentException("Opcion invalida, intenta nuevamente"),
            };
        } catch (Exception ex) {
            Console.WriteLine($"{ex.Message}");
        }
    }
}

static Guerrero GeneraEnemigo() {
    string[] nombres = { "Vikingos", "orcos", "Terminator", "Mikey Mouse", "Sherk", "Zeus" };
    string nombre = nombres[new Random().Next(nombres.Length)];
    return new Guerrero (nombre, new Random().Next(150, 200), new Random ().Next(30,50));
}

static void MostrarEstado (Guerrero jugador, Guerrero enemigo) {
    Console.ForegroundColor = ConsoleColor.Magenta;
}

//Definiciones de clases 

public class Guerrero 
{
    //Atributos
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }


    //Constructor 
    public Guerrero(string nombre, int vida, int ataque ) 
    {
        Vida = vida;
        Ataque = ataque;
        Nombre = nombre;
    }

    //Metodos 
    public virtual void Atacar(Guerrero enemigo) {
        int danio = Ataque + new Random().Next();
        //recibir daño
        enemigo.Recibirdanio(danio);
        Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} causa {danio} de danio");
    }
    public void Recibirdanio(int cantidad) {
        Vida = Math.Max ( Vida - cantidad,0); //Math.Max si la suma e smenor que sero regresa 0, en otro caso es el resultado de a suma 

    }

    //Sobrecarga del operador +
    public static Guerrero operator + (Guerrero g1, Guerrero g2) {
        Console.WriteLine($"{g1.Nombre} + {g2.Nombre} se fusionan en un nuevo guerrero ");
        return new Guerrero ($"{g1.Nombre}----{g2.Nombre}", (g1.Vida + g2.Vida)/2, (g1.Ataque+g2.Ataque)/2 );
    }
}

//Clase Caballero

public class Caballero : Guerrero {
    //Constructor
    public Caballero(string nombre) : base(nombre, 120, 20) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {
        Console.WriteLine($"{Nombre}(Caballero) usa golpe critico");
        base.Atacar(enemigo);
    }
}

//Clase Mago
public class Mago : Guerrero {
    //Constructor 
    //Constructor
    public Mago(string nombre) : base(nombre, 80, 25) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {
        Console.WriteLine($"{Nombre}(Mago) lanza hechizo de fuego");
        base.Atacar(enemigo);
    }
}

//Clase Arquero
public class Arquero : Guerrero {
    //Constructor 
    //Constructor
    public Arquero(string nombre) : base(nombre, 90, 15) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {

        int probabilidad = new Random().Next(1,100);
        if (probabilidad < 30) {
            Console.WriteLine($"{Nombre} (Arquero) dispara una flecha y falla ");
        }else {
            Console.WriteLine($"{Nombre}(Arquero) lanza una flecha y acierta");
            base.Atacar(enemigo);
        }
            
    }
}
//Clase Guerrero Sombra
public class GuerreroSombra : Guerrero {
    //Constructor 
    //Constructor
    public GuerreroSombra(string nombre) : base(nombre, 110, 22) { }

    //Polimorfismo

    public override void Atacar(Guerrero enemigo) {

        int chance = new Random().Next(1, 100);
        if (chance < 20) {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) desaparece   ");
        } else {
            Console.WriteLine($"{Nombre}(Guerrero Sombra) ataca sigilozamente");
            base.Atacar(enemigo);
        }

    }
}