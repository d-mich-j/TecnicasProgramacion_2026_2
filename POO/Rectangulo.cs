
public class Rectangulo 
{
    //Atributos

    public int Base { get; set; } 

    public int Altura { get; set; }

    //Costructor

    public Rectangulo(int base_, int altura) 
    {
        Base = base_;
        Altura = altura;
    }


    //Metodos 
    public void Perimetro() 
    {
        Console.WriteLine($"El perimetro es:{Base * 2 + Altura + 2}");
    }

    public void Area() 
    {

        int calculoArea = Base * Altura;
        Console.WriteLine($"El area es:{calculoArea}");
    }

}



