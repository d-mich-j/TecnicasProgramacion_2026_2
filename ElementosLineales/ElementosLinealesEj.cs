//SISTEMA DE GESTION DE FESTIVAL MUSICAL:EstructurasLineales


//Programa principal

Festival festivAl = new Festival("KermesFI");
Console.WriteLine($"BIENVENIDO AL FESTIVAL DE MUSICA {festival.Nombre}");

//Crear banda y sus sets de canciones

Console.WriteLine("REGISTRANDO BNDAS Y SETS");

//Banda 1 
Banda muse = new Banda("DJO", "UE", new TimeSpan(19, 0, 0), 5);
muse.CargaCancion(0 new Cancion("StarLight", 4, "ROCK"));
muse.CargaCancion(1 new Cancion("Histeria", 3, "ROCK"));
muse.CargaCancion(2 new Cancion("Unintended", 3, "ROCK"));
muse.CargaCancion(3 new Cancion("Madness", 5, "ROCK"));

//Banda 2 
Banda djo = new Banda("Muse", "UK", new TimeSpan(17, 0, 0), 3);
djo.CargaCancion(0 new Cancion("Crux", 3, "ROCK"));
djo.CargaCancion(1 new Cancion("End of begining", 3, "ROCK"));
djo.CargaCancion(2 new Cancion("Back on you", 5, "ROCK"));

//Banda 3 
Banda bts = new Banda("BTS", "COR", new TimeSpan(21, 0, 0), 3);
bts.CargaCancion(0 new Cancion("Butter", 3, "KPOP"));
bts.CargaCancion(1 new Cancion("Body to body", 3, "KPOP"));
bts.CargaCancion(2 new Cancion("Hooligan", 3, "KPOP"));

//Banda 4 
Banda calibre50 = new Banda("Calibre50", "MEX", new TimeSpan(24, 0, 0), 3);
calibre50.CargaCancion(0 new Cancion("Si te pudiera mentir", 4, "BANDA"));
calibre50.CargaCancion(1 new Cancion("El tierno se fue", 4, "BANDA"));
calibre50.CargaCancion(2 new Cancion("El amor de mi vida", 2, "BANDA"));

//Agregar al festival

festivAl.AgregarBanda(muse);
festivAl.AgregarBanda(djo);
festivAl.AgregarBanda(bts);
festivAl.AgregarBanda(calibre50);

//Duracion toal de cada set
Console.WriteLine("DURACION DE SETS´POR BANDA")
foreach (Banda b in festivAl.OrdenShow) {
    Console.WriteLine($"{b.Nombre} - {b.DuracionTotalSet}");
}

//Orden original de preentacion
Console.WriteLine("REORDENANDO SHOW");
festivAl.ResumenCartel();

//cAMBIO DE ULTIMO MINUTO BANDA INVITADA CONFIRMA MJ
//Banda 4 
Banda mj = new Banda("Michel Jackson", "Ue", new TimeSpan(20, 0, 0), 2);
mj.CargaCancion(0 new Cancion("Thriller", 5, "POP"));
mj.CargaCancion(1 new Cancion("Beat it", 4, "POP"));


Console.WriteLine($"Cambo de ultimo minuto {mj.Nombre} confirma como banda despues de BTS y antes de calibre 50");

//Nodo al que pertenece BTS
LinkedListNode<Banda> nodoBTS = festivAl.OrdenShow.Find(bts);


//Insertar MJ al orden show
festivAl.InsertarBandaDespuesDe(mj, nodoBTS);

//Cancela una banda
festivAl.CancelarBanda(bts);

//Fila de ingreso

Console.WriteLine("Asistentes en la fila de ingreso:");
festivAl.FilaIngreso.Enqueue(new Asistente("Juan", 1001, new TimeSpan(17, 0, 0)));
festivAl.FilaIngreso.Enqueue(new Asistente("Carlos", 1002, new TimeSpan(17, 30, 0)));
festivAl.FilaIngreso.Enqueue(new Asistente("Saul", 1003, new TimeSpan(20, 30, 0)));
festivAl.FilaIngreso.Enqueue(new Asistente("Bruno", 1004, new TimeSpan(21, 0, 0)));
festivAl.FilaIngreso.Enqueue(new Asistente("Daniela", 1005, new TimeSpan(16, 0, 0)));

//Admitir a todos en el orden de llegada

Console.WriteLine("ADMITINDO AL FESTIVAL:");
while (festivAl.FilaIngreso.Count > 0) {
	Asistente ingreso = festivAl.AdministrarSiguiente();
	Console,WriteLine($"Ingresa: {ingreso.Nombre} | {ingreso.HoraLlegada}");
}

//sIMULACION DE PRESENTCION EN ESCENARIO

Console.WriteLine("PRESENTACIONES EN ESCENARIO:");
foreach (Banda B in festivAl.OrdenShow.SkipLast(2)) {
	festivAl.RegistrarPresentacion(b);
}

//Historial de presentacion

Console.WriteLine("Historial de escenario:");
Stack<Banda> copiaHistorial = new Stack<Banda>(festivAl.HistoralEscenario);
int turno = 1;
while (copiaHistorial.Count > 0) {
	Console.WriteLine($"{turno}")
}

public class Cancion
{
	public string Titulo { get; set; }
	public int Duracion { get; set; }
	public string Genero { get; set}

	public Cancion(string titulo; int duracion ; string genero) 
	{
		Titulo = titulo; 
		Duracion = duracion;
		Genero = genero;
	}
	//Metodos 
	public override string ToString () {
		return $"{Titulo} - {Duracion} min [{Genero}]"
	}
}

public class Banda 
{
	public string Nombre { get; set; }
	public string Origen { get; set; }
	public TimeSpan HoraPresentacion { get; set}
	public Cancion[] SetCanciones { get; set; }

	public Banda (string nombre, string origen, TimeSpan hora, int cantidadCanciones) 
	{
		Nombre = nombre;
		Origen = origen;
		HoraPresentacion = hora;
		SetCanciones = new Cancion [cantidaCanciones];
	}

	//Metodos

	//Carga cancion en un posicion especifica 

	public void CargaCancion( int posicion, Cancion cancion ) 
	{
		if (posicion >= SetCanciones.Lenght || posicion <0 ) 
		{
			throw new ArgumentOutOfRangeException ($"Posicion invalida: {posicion}")
		}

		SetCanciones[posicion] = cancion;
	}
	 public int DuracionTotalSet() 
	{

		//Recorrer el arreglo sumando duraciones

		int total = 0;

		foreach (Cancion cancion in SetCanciones)
		{
			if (cancion != null ) 
			{
                total += cancion.Duracion;
            }
			
		}

		return total;
	}

	public override string ToString() 
	{
		return $"{Nombre} ({Origen}) | {HoraPresentacion} :hh\\:mm";
	}
}

public class Asistente 
{
	//Popiedaes 

	public string Nombre { get; set; }
	public int NumeroEntrada { get; set; }
	public TimeSpan  HoraLlegada { get; set; }
	public bool YaIngreso { get; set; }

	//Constructor 

	public Asistente (string nombre, int numeroEntrada, TimeSpan horallegada, bool yaIngreso) {
		Nombre = Nombre;
		NumeroEntrada = numeroEntrada;
		HoraLlegada = horallegada;
		YaIngreso = false;
	}

	//Metodos

	public override string ToString() {
		return $"#{NumeroEntrada} {Nombre} llego a las {HoraLlegada} :hh\\:mm"
	}

}

public class Festival {
	//Propiedades 
	public string Nombre { get; set; }
	public List<string> Cartel { get; set; }
	public Stack<string> HistoralEscenario { get; set; }
	public Queue<string> FilaIngreso { get; set; }
	public LinkedList<string> OrdenShow { get; set; }

	//Constructor

	public Festival(string nombre) {
		Nombre = nombre;
		Cartel = new List<string>();
		HistoralEscenario = new Stack<string>();
		FilaIngreso = new Queue<string>();
		OrdenShow = new LinkedList<string>();
	}

	//Metodos 

	public void AgregarBanda(Banda banda) {
		//Agregando banda a la lista cartel
		Cartel.Add(banda);
		//Agregar banda a la listaenazada del orden del show 
		OrdenShow.AddLast(banda);
		Console.WriteLine($"[+] Banda confirmada {banda.Nombre}");
	}

	public void CancelarBanda(Banda banda) {
		if (Cartel.Contains(banda)
		{
			Cartel.Remove(banda);
			OrdenShow.Remove(banda);
			Console.WriteLine($"[-] Banda cancelada {banda.Nombre}");
		} else {
			Console.WriteLine($"Banda {banda.Nombre} no se encontro");
		}
	}

	public void InsertarBandaDespuesDe(Banda nueva, LinkedListNode<Banda> despuesDe) {
		if (OrdenShow.Contains(nueva)) 
		{
            OrdenShow.Remove(nueva);
        }
		
		OrdenShow.AddAfter(despuesDe, nueva);
		Console.WriteLine($"  [] {nueva.Nombre} reubicada en el oreden del show")


	}

	public void RegistrarPresentacion(Banda banda) {
		HistorialEscenario.Push(banda);
		Console.WriteLine($"   []  Presentacion registrada: {banda.Nombre}")

	}

	public Asistente AdministrarSiguiente() {
		Asistente asistente = FilaIngreso.Dequeue();
		asistente.YaIngreso = true;
		return asistente;
	}

	public Banda UltimaEnTocar() {
		return HistoralEscenario.Peek();
	}

	public void ResumenCartel() {
		//Copia de la lista de bandas para no alterar el original
		List<Banda> ordenada = new List<Banda>(Cartel);

		//Ordenamiento burbuja sobre hora de presentacion
		int n = ordenada.Count;

		for (int i = 0; i < n-1; i++) {
			for (j = 0; j < n-i-1; j++) {
				if (ordenada[j].HoraPresentacion> ordenada[j+1].HoraPresentacion) {
					Banda temp = ordenada[j];
					ordenada[j] = ordenada[j + 1];
					ordenada[j + 1] = temp;
				}
			}
		}

		Console.WriteLine($"Cartel oficial - {Nombre}");
		foreach(Banda b in ordenada) {
			Console.WriteLine($"{b.HoraPresentacion:hh\\mm} {b.Nombre}");
		}
	}


}



