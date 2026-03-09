    //Programa principal 

Lampara lampara = new Lampara("Lamparita",100, 40);
Ventilador ventilador = new Ventilador("Aire", 150, 50);

//Enciender ambos dispositivos 

lampara.Encender();
ventilador .Encender();

//Mostrar informacion

Console.WriteLine(lampara.MostrarInfo());
Console.WriteLine(ventilador.MostrarInfo());

//Ajustamos consumo

lampara.AjustarConsumo();
ventilador.AjustarConsumo(-6);

//Mostrar informacion

Console.WriteLine(lampara.MostrarInfo());
Console.WriteLine(ventilador.MostrarInfo());

//Comparacion con operadores

if (lampara > ventilador) {
    Console.WriteLine("Lampara consume mas");
}else if(lampara < ventilador) {
    Console.WriteLine("Ventilador consume mas");
}else {
    Console.WriteLine("Ambos consumen lo mismo");
}


public class Dispositivo 

{
    //Atributos

    private string nombre;
    private bool encendido;
    private int consumo;

    public string Nombre 
    {
        get { return nombre; }
        set { Nombre = value; }
 
    }
    public bool Encendido 
    {
        get { return encendido; }
        set { encendido = value; }

    }
    
    public int Consumo
        {
        get { return encendido ? Consumo : 0; }//solo consume si esta encendido.
        set 
        {
            if (value < 0)
            {
                consumo = 0;
            } else 
            {
                consumo = value;
            }
        }
    }


    //Constructor

    public Dispositivo (string nombre, int  cconsumo) {
        this.nombre = nombre;
        this.consumo = consumo;
        this.encendido = false;

    }

    //Metodos

    public void Encender() {
        Encendido = true;

    }

    public void Apagar() {

    }

    //Sobrecarga 

    public void AjustarConsumo( ) {
        Consumo = 100;
    }
    public void AjustarConsumo(int nuevoConsumo) {
        Consumo = nuevoConsumo;
    }

    public virtual string MostrarInfo() {
        return $"Dispositivo:{Nombre}, Encendido:{Encendido}, Consumo:{Consumo}";
    }


    //Sobrecarga de operadores 

    public static bool operator > (Dispositivo d1, Dispositivo d2) {
        return d1.Consumo > d2.Consumo;
    }
    public static bool operator < (Dispositivo d1, Dispositivo d2) {
        return d1.Consumo < d2.Consumo;
    }
    public static bool operator == (Dispositivo d1, Dispositivo d2) {
        return d1.Consumo == d2.Consumo;
    }
    public static bool operator != (Dispositivo d1, Dispositivo d2) {
        return d1.Consumo != d2.Consumo;
    }
}

public class Lampara : Dispositivo 
{

    //Atributos 

    private int intensidad = 0; //nivel de brillo

    //Constructor 

    public Lampara (string nombre, int consumo, int intensidad) : base(nombre, consumo) {
        this.intensidad = intensidad;
    }

    //Metodos

    public override string MostrarInfo() 
    {
        return $"Lampara: {base.MostrarInfo()}, Intensidad {intensidad}";
    }
}

public class Ventilador : Dispositivo 
{
    //Atributos
    private int velocidad;

    //Constructor
    public Ventilador(string nombre, int consumo, int velocidad) : base(nombre, consumo) {
        this.velocidad = velocidad;
    }

    //Metodos
    public override string MostrarInfo() {
        return $"Ventilador: {base.MostrarInfo()}, Velocidad: {velocidad}";
    }
}
