

// Programa principal

List<IDispositivos> LIST = new List<IDispositivos>();


Lampara lampara = new Lampara(false, 0);
Ventilador ventilador = new Ventilador(false, 0);
Altavoz altavoz = new Altavoz(false, "");

LIST.Add(lampara);
LIST.Add(ventilador);
LIST.Add(altavoz);

// Encender dispositivos
Console.WriteLine("Encendiendo dispositivos ");

Console.WriteLine(LIST);

lampara.Encendido();
ventilador.Encendido();
altavoz.Encendido();

lampara.MostrarEstado();
ventilador.MostrarEstado();
altavoz.MostrarEstado();


// Ajustar valores
Console.WriteLine("\nAjustando valores");

lampara.AjustarBrillo(5);
ventilador.AjustarVelocidad(15);
altavoz.ReproducirCancion("Cancion favorita");

// Mostrar estado
Console.WriteLine("\nEstado: ");
lampara.MostrarEstado();
ventilador.MostrarEstado();
altavoz.MostrarEstado();

// Apagar todos
Console.WriteLine("\nApagando dispositivos ");

lampara.Apagado();
ventilador.Apagado();
altavoz.Apagado();

// Mostrar estado
Console.WriteLine("\nEstado: ");
lampara.MostrarEstado();
ventilador.MostrarEstado();
altavoz.MostrarEstado();



//Interfaces y clases

public interface IDispositivos
{
    void Encendido();
    void Apagado();
    void MostrarEstado();
}


public class Lampara : IDispositivos
{

    //Atributos
    public bool encendido { get; set; }
    public int brillo { get; set; }

    //Constructor
    public Lampara(bool encendido, int brillo)
    {
        this.encendido = encendido;
        this.brillo = brillo;
    }

    //Encendido
    public void Encendido()
    {
        encendido = true;
    }

    public void Apagado()
    {
        encendido = false;
    }

    public void AjustarBrillo(int valor)
    {
        brillo = valor;
    }

    public void MostrarEstado()
    {
        if (encendido == true)
        {
            Console.WriteLine($"La lampara esta encendida con brillo {brillo}");
        }
        else
        {
            Console.WriteLine($"La lampara esta apagada.");
        }
    }
}


public class Ventilador : IDispositivos
{
    public bool encendido { get; set; }
    public int velocidad { get; set; }

    public Ventilador(bool encendido, int velocidad)
    {
        this.encendido = encendido;
        this.velocidad = velocidad;
    }

    public void Encendido()
    {
        encendido = true;
    }

    public void Apagado()
    {
        encendido = false;
    }

    public void AjustarVelocidad(int valor)
    {
        velocidad = valor;
    }

    public void MostrarEstado()
    {
        if (encendido == true)
        {
            Console.WriteLine($"El ventilador esta encendido con velocidad {velocidad}");
        }
        else
        {
            Console.WriteLine($"El ventilador esta apagado.");
        }
    }
}


public class Altavoz : IDispositivos
{
    public bool encendido { get; set; }
    public string cancion { get; set; }

    public Altavoz(bool encendido, string cancion)
    {
        this.encendido = encendido;
        this.cancion = cancion;
    }

    public void Encendido()
    {
        encendido = true;
    }

    public void Apagado()
    {
        encendido = false;
    }

    public void ReproducirCancion(string nombre)
    {
        cancion = nombre;
    }

    public void MostrarEstado()
    {
        if (encendido == true )
        {
            Console.WriteLine($"El altavoz esta encendido reproduciendo: {cancion}");
        }
        else
        {
            Console.WriteLine("El altavoz esta apagado.");
        }
    }
}

