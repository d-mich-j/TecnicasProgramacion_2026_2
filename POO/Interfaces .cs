//Ejemplo de interfases

//Programa principal

IEjemplo algo = new EjemploClase();
algo.Haceralgo();
algo.Haceralgomas();




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

public class Tucan : Paloma {

}

//Usando INterfaces 
public interface IaNIMAL {
    void HacerSonido();
}