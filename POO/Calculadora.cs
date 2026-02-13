//Programa principal

Calculadora calculadora = new Calculadora(5, 0);
float resultadodivision = calculadora.Division();

Console.WriteLine("El resultado de la division es:"{ resultadodivision});
int resultadosuma = calculadora.Suma();

Console.WriteLine("El resultado de la suma es:"{ resultadosresta});
int resultadoresta = calculadora.Resta();


Console.WriteLine("El resultado de la multiplicacion es:"{ resultadomultiplicacion});
int resultadosuma = calculadora.Suma();

//Clases

//Calculadora basica que solo opera 2 numeros enteros 

public class Calculadora {
    //Atributos
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }
    public int Numero3 { get; set; }

    //Atriuto privado
    private int Resultado;


    //Constructor

    public Calculadora(int numero1, int numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
    }

    //Metodos

    public int Suma() 
    {
        return Numero1 + Numero2;
    }

    public int Resta() 
    {
        return Numero1 - Numero2;
    }

    public int Multiplicacion() 
    {
        return Numero1 * Numero2;
    }

    public float Division() 
    {
          if (Numero2 == 0) 
          {
              Console.WriteLine("MathError");
              return 0;
          }
    }
        return (float)Numero1 / Numero2;
    }


}