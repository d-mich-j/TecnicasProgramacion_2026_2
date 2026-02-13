//Programa principal

//Calculadora calculadora1 = new Calculadora(5, 0);

//Console.WriteLine($"");
//Console.WriteLine($"");

//float resultadodivision = calculadora1.Division();
//Console.WriteLine($"El resultado de la division es:{ resultadodivision}");

//int resultadosuma = calculadora1.Suma();
//Console.WriteLine("El resultado de la suma es:"{ resultadosresta});

//int resultadoresta = calculadora1.Resta();
//Console.WriteLine("El resultado de la suma es:"{ resultadosresta});

//int resultadosuma = calculadora1.Suma();
//Console.WriteLine("El resultado de la multiplicacion es:"{ resultadomultiplicacion});


//Función factorial

/*Calculadora calculadora2 = new Calculadora(6, 8);
CalculadoraCientifica calculadoraCientifica = new CalculadoraCientifica(7, 2);*/

Console.WriteLine("Ingresa el segundo numero a operar");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Ingresa el segundo numero a operar");
int num2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Presiona 1-  Calculadora Baica");
Console.WriteLine("Presiona 1-  Calculadora Cientifica");
int sel = int.Parse(Console.ReadLine() ?? "");

if (sel == 1) 
{
    Calculadora calculadora1 = new Calculadora(1, 3);
    Console.WriteLine("1- Suma"); 
    Console.WriteLine("1- Resta");
    Console.WriteLine("1- Multiplicacion");
    Console.WriteLine("1- Division");
    sel = int.Parse(Console.ReadLine()??"");

    switch (sel) 
    {
        case 1:
            Console.WriteLine($"El resultado de calculadora basica: {calculadora1.Suma()} ");
            break;
        case 2:
            Console.WriteLine($"El resultado de calculadora basica: {calculadora1.Resta()} ");
            break;
        case 3:
            Console.WriteLine($"El resultado de calculadora basica: {calculadora1.Suma()} ");
            break;
        case 4:
            Console.WriteLine($"El resultado de calculadora basica: {calculadora1.Suma()} ");
            break;

    }
}


switch () 
{ 
    case 0;
        break;
}


//Clases

//Calculadora basica que solo opera 2 numeros enteros 
public class Calculadora {
    //Atributos
    public int Numero1 { get; set; }
    public int Numero2 { get; set; }


    //Constructor

    public Calculadora(int numero1, int numero2) {
        Numero1 = numero1;
        Numero2 = numero2;
    }

    //Metodos

    public int Suma() {
        return Numero1 + Numero2;
    }

    public int Resta() {
        return Numero1 - Numero2;
    }

    public int Multiplicacion() {
        return Numero1 * Numero2;
    }

    public float Division() {
        if (Numero2 == 0) {
            Console.WriteLine("MathError");
            return 0;
        }

        return (float)Numero1 / Numero2;
    }



}

//Clase hija


public class CalculadoraCientifica : Calculadora {
    //Atributos
    //Constructor
    public CalculadoraCientifica(int num1, int num2) : base(num1, num2) {

    }
    //Metodos 

    //Override cambia el metodo hereddo

    public override int Suma() {

    }

    public int factorial() {
        if (Numero1 == 0 || Numero1 == 1) {
            return 1;
        } else if (Numero1 < 0) {
            Console.WriteLine("No es posible el factorial de un numero negativo");
            return 0;
        } else {
            int Fct = 1;

            for (int i = 2, i <= 1; i++) ;
            {
                Fct = Fct * i;
            }
            return Fct;
        }
    }
}


