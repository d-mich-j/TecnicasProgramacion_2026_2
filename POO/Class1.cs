//Interfaz y clases 

public interface IDispositivos {
    bool  Encendido();
    bool Apagado(); 
    string EstadoActual();
}

public class Lampara : IDispositivos
{
    //Atributos 

    int brillo { get; set; }

    //Constructor 
    public Lampara(bool encendido, string estadoActual, int brillo) 
    {
        encendido = true;
        estadoActual = "encendido";
        brillo = 0;
    }


    //Metodos 
    public bool Encendido() 
    {
        Console.WriteLine("");
        
        return true;

    }
    public string  EstadoActual() 
    {
        Console.WriteLine("dfhg");
        return "s";
    }
    public bool Apagado() {
        Console.WriteLine("dfhg");
        return false;
    }
    

}

public class Ventilador : IDispositivos() {

    //Atributos 



    //Constructor



    //Metodos 
    public bool Encendido() {
        Console.WriteLine("DFD");
        return true;

    }
    public string EstadoActual() {
        Console.WriteLine("dfhg");
        return "s";
    }
    public bool Apagado() {
        Console.WriteLine("dfhg");
        return false;
    }
}
 public class Altavoz : IDispositivos {
    //Atributos 


    //Constructor 


    //Metodos 
    public bool Encendido() {
        Console.WriteLine("DFD");
        return true;

    }
    public string EstadoActual() {
        Console.WriteLine("dfhg");
        return "s";
    }
    public bool Apagado() {
        Console.WriteLine("dfhg");
        return false;
    }

}