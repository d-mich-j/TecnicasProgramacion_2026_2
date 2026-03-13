//Jimenez Muñoz Daniela Michelle 

using System.Runtime.CompilerServices;

public class Bola {
    //Atributos
    protected double  Masa { get; }


    //Varible de la clase


    //Constructor 

    public Bola(double masa) {
        Masa = masa / 1000;
    }

    //Metodos 

    public void Mover(double posicionX, double posicionY) {
        posicionX = 0 + posicionX;
        posicionY = 0 + posicionY;
    }

    public void ObteneroeficienteFriccion() {}
}
//Clase hija bola normal
public class BolaN : Bola {
    //Constructor 
    public BolaN(double masa) : base (masa) {}

    //Metodos 
    public static void ObteneroeficienteFriccion(double u) 
    {
        u = 1.2;
    }

}

//Clase hija bola PROFESIONAL
public class BolaP : Bola {
    //Constructor 
    public BolaP(double masa) : base(masa) { }

    //Metodos 
    public static void ObteneroeficienteFriccion(double u) {
        u = 0.6;
    }
}

public class Tiro 
{
    //Atributos
    public double Impulso { get; }
    public double PosicionX { get; }
    public double PosicionY { get; }

    
    //Constructor 

    public Tiro (double impulso, double posicionX, double posicionY) 
    {
        Impulso = impulso;
        PosicionX = posicionX;
        PosicionY = posicionY;
    }

    
}

//Interfaz para criterio de calculo
 interface IEstrategiaCalculo 
 {
    double CalcularDistancia();
    
}

public class CalculoSimple : IEstrategiaCalculo 
{
    //aTRIBUTO
    public double Impulso { get; }

    //cONSTRUCTOR
    public CalculoSimple(double impulso) {
        Impulso = impulso;
    }

    //Metodos 

    public double CalcularDistancia(double distancia) {

        distancia = Impulso * 2;
        return distancia;
    }
}

public class CalculoFisico : IEstrategiaCalculo {
    //aTRIBUTO
    public double g = 9.81;
    double d = 0;

    //cONSTRUCTOR
    public CalculoFisico(Bola masa, Tiro impulso) {
        masa = masa;
        impulso = impulso;

    }
    //Metodos 

    public double CalcularDistancia(double masa, double impulso, double distancia) 
    {

        double v0 = impulso / masa;
        double mu = 
        double distancia = 0;

        return d;
    }

    public class SimuladorBillar {

        
        public List<Tiro> tiros = new List<Tiro>();

        //Constructor 



        //Metodos



    }
}
