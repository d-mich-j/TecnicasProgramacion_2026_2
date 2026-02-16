using System.Reflection.Metadata.Ecma335;
//Programa principl con instrucciones de nivel superior

Auto Auto1 = new Auto();
Auto1.Marca = "Honda";
Auto1.Modelo = "Civic";
Auto1.Velocidadactual = 30.5f;
Console.WriteLine($"La marca del auto es: {Auto1.Marca}");
Auto1.Acelerar(10.0f);
Console.WriteLine($"La velocidad es: {Auto1.Velocidadactual}");
Auto1.Frenar(-100.0f);
Console.WriteLine($"La velocidad es: {Auto1.Velocidadactual}");

//Herencia

Vehiculo vehiculo = new Vehiculo("algo", "otra cosa");
vehiculo.Modelo = "Otro modelo";
AutoH autoH = new AutoH(" Ford","Mustang");
autoH.Marca = vehiculo.Marca;
Motocicleta moto = new Motocicleta("Yamaha", "RT07");

autoH.Acelerar(50f);
moto.Acelerar(60f);


moto.Frenar(70f);

//Aplicar sobrecarga de operadores 
if (autoH > moto) {
    Console.WriteLine($"Moto mas rapido: {moto.Velocidadactual} ");
} else if (autoH > moto) {
    Console.WriteLine($"Moto mas rapido: {moto.Velocidadactual} ");
} else if (autoH == moto) {
    Console.WriteLine($"Van a la misma velocidad ");
}
Console.WriteLine($"Moto  : {moto.Velocidadactual} ");
Console.WriteLine($"Auto  : {autoH.Velocidadactual} ");

public class Vehiculo {
    //Atributos

    protected string marca;
    protected string modelo;
    protected float velocidadactual;

    //Atributos publicos con control

    public  virtual string Marca {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo {
        get { return modelo; }
        set { modelo = value; }

    }

    public float Velocidadactual {
        get { return velocidadactual; }
        set {
            if (value < 0) {
                velocidadactual = 0;
            } else {
                velocidadactual = value;
            }
        }
    }



    //Constructor

    public Vehiculo(string marca, string modelo) 
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidadactual = 0.0f;

    }

    //Metodos

    public void Acelerar(float incremento) {
        Velocidadactual += incremento;

    }
    public void Frenar(float decremento) {
        Velocidadactual -= decremento;
    }


    //Sobrecarga de los operadores > < == para comparar velocidad
    
    public static bool operator > (Vehiculo v1, Vehiculo v2) 
    {
        return v1.velocidadactual > v2.velocidadactual;
    }

    public static bool operator <(Vehiculo v1, Vehiculo v2) 
    {
        return v1.velocidadactual < v2.velocidadactual;
    }

    public static bool operator == (Vehiculo v1, Vehiculo v2) 
    {
        return v1.velocidadactual == v2.velocidadactual;
    }

    public static bool operator !=(Vehiculo v1, Vehiculo v2) {
        return v1.velocidadactual != v2.velocidadactual;
    }


}

public class AutoH : Vehiculo 
{
    //constructor
    public AutoH(string marca, string modelo) : base(marca, modelo) { }
    
    //Atributos publicos con control
    public override string Marca 
    {
        get 
        {
            Console.WriteLine($"La marca del auto es {marca}");
            return marca;
        }
        set { marca = value; }
    }

}

public class Motocicleta : Vehiculo 
{
    //constructor
    public Motocicleta(string marca, string modelo) : base(marca, modelo) { }
}
public class Auto 
{
    //Atributos

    private string marca;
    private string modelo;
    private float velocidadactual;

    //Atributos publicos con control

    public string Marca 
    {
        get { return marca; }
        set {marca = value; }
    }

    public string Modelo 
    {
        get { return modelo; }
        set { modelo = value; }

    }

    public float Velocidadactual 
    {
        get { return velocidadactual; }
        set {
            if (value < 0) {
                velocidadactual = 0;
            } else {
                velocidadactual = value;
            }
        }
    }
      
        

        //Constructor



        //Metodos

        public void Acelerar(float incremento) 
        {
            Velocidadactual += incremento;

        }
        public void Frenar( float decremento) 
        {
            Velocidadactual -= decremento;
        }

}