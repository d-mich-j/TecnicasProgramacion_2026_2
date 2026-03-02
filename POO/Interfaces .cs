//Ejemplo de interfases

//Programa principal

IEjemplo algo = new EjemploClase();
algo.Haceralgo();



//Declaracion 

public interface IEjemplo
//Definicion de metodos 
{
    void Haceralgo();
}

public class EjemploClase : IEjemplo {
    public void Haceralgo() {
        Console.WriteLine("Haciendo algo");
    }
}

