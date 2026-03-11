//Programa principal

Libreria libreria = new Libreria();

try 
{
    int operaciones = int.Parse(Console.ReadLine() ?? "");

    for (int i = 0; i< operaciones; i++) 
    {
        string[] entrada = (Console.ReadLine() ?? "").Split(" ");
        string comando = entrada[0];
        switch (comando) {
            case "LIBRO":
                libreria.AgregarLibro(entrada[1], entrada[2], entrada[3]);

                break;
            case "CALIFICAR":
                
                if (entrada.Length == 4) { 
                    libreria.CalificarLibro(entrada [1], int.Parse(entrada[3]));
                }else 
                {
                    //Control
                    Console.WriteLine(entrada.Length);

                    libreria.CalificarLibro(entrada[1], int.Parse(entrada[3]), string.Join (" ", entrada.Skip(4)));
                }
                    break;
            case "MEJOR":
                libreria.MostrarMejorLibro(entrada[1]);

                break;
            case "CRITERIO":
                libreria.CambiarCriterio(entrada[1]);

                break;
            default:
                throw new InvalidOperationException("comando no valido");
        }

    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


//Clases 


public class Libro {
    //Atributos
    public string Titulo { get; } //No se establece el cambio en el valor d este atributo 
    public string Autor { get; }
    public string Genero { get; }

    //Varible de la clase
    List<int> Calificaciones;

    //Constructor 
    public Libro (string titulo, string autor, string genero) 
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Calificaciones = new List<int>();
    }


    //Metodos 

    public void Calificar(int estrellas) 
    {
        if (estrellas >= 1 && estrellas <=5) 
        {
            Calificaciones.Add(estrellas);
        }
        else 
        {
            throw new ArgumentException("Calificacion invalida (debe ser de 1-5) ");
        }
    }
    //Sobrecarga del metodo calificar
    public void Calificar(int estrellas, string comentario) 
    {
        Console.WriteLine($"Comentario recibido : {comentario}");
        Calificar(estrellas);
    }

    public double ObtenerPromedio() 
    {
        if (Calificaciones.Count = 0) 
        {
            throw new InvalidOperationException("No hay calificaciones para este libro");
        }
        else 
        {
            double promedio = Calificaciones.Average();
            return promedio;
        }
            
    }

    public int ObtenerCantidadVoto() 
    {
        return Calificaciones.Count;
    }

}

//Clases hijas tipos de libro

public class LibroFiccion : Libro 
{
    //Variable de clase 
    List<string > tipoFiccion = new List<string> { "Fantasia", "Ciencia_Ficcion", "Romance", "Terror", "Misterio" } ;

    //Constructor 

    public LibroFiccion(string titulo, string autor, string genero) : base(titulo, autor, genero) 
    {
        if (tipoFiccion.Contains(genero)) 
        {
            throw new ArgumentException("El libro no pertenece a esta categoria");
        }
    }
}

public class LibroTecnico : Libro 
    {
 

    //Constructor 

    public LibroTecnico(string titulo, string autor, string genero) : base(titulo, autor, genero) {
        if (tipoFiccion.Contains(genero)) 
        {
            throw new ArgumentException("El libro no pertenece a esta categoria");
        }
    }
}

//Interfaz para criterio de recomendcion
 interface IRecomendable 
 {
    Libro ObtenerMejorLibro(List <Libro> libros);
 }
//Clases que implementen interfaz 

public class RecomendacionPorPromedio : IRecomendable 
{
    public Libro ObtenerMejorLibro (List <Libro> libros) 
    {
         Libro mejorLibro = null;
        double mejorPromedio = 0;
        
        foreach (Libro libro in libros) {
            double promedio = libro.ObtenerPromedio(); //Selecion del pivote 
            if (promedio > mejorPromedio) //Comparacion 
            {
                mejorPromedio = promedio;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}

public class RecomendacionPorVotos : IRecomendable 
{
    public Libro ObtenerMejorLibro(List<Libro> libros) {
        Libro mejorLibro = null;
        double maxVotos = -1;

        foreach (Libro libro in libros) {
            double votos = libro.ObtenerCantidadVoto(); //Selecion del pivote 
            if (votos > maxVotos) //Comparacion 
            {
                maxVotos = votos;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}

//Clase de libreria

public class Libreria {
    public List<Libro> libros = new List<Libro>();
    IRecomendable estragiaRecomendacion = new RecomendacionPorPromedio();


    //Metodos
    public void AgregarLibro (string titulo, string autor, string genero) 
    {
        Libro nuevolibro;
        try 
        {
            nuevolibro = new LibroFiccion(titulo, autor, genero);
        } 
        catch(Exception ex) 
        {
            nuevolibro = new LibroFiccion(titulo, autor, genero);
        }
    }

    public void CalificarLibro (string titulo, int estrellas) 
    {
        Libro libroEncontrado = null;

        foreach (Libro libro in libros) 
        {
            if (libro.Titulo == titulo)
            {
                libroEncontrado = libro;
                break;
            }
        }

        if (libroEncontrado != null) 
        {
            libroEncontrado.Calificar(estrellas);
        } 
        else 
        {
            throw new KeyNotFoundException("Libro no ncontrado");
        }
    }

    //Sobrecarga 
    public void CalificarLibro(string titulo, int estrellas, string comentario) 
    {
        Libro libroEncontrado = null;

        foreach (Libro libro in libros) 
        {
            if (libro.Titulo == titulo) 
            {
                libroEncontrado = libro;
                break;
            }
        }

        if (libroEncontrado != null) {
            libroEncontrado.Calificar(estrellas, comentario);
        } 
        else 
        {
            throw new KeyNotFoundException("Libro no ncontrado");
        }
    }

    public void CambiarCriterio(string criterio) 
    {
        if (criterio == "PROMEDIO")
        {
            estragiaRecomendacion = new RecomendacionPorPromedio();
        }
        else if (criterio == "VOTOS") 
        {
            estragiaRecomendacion = new RecomendacionPorVotos();
        }
    }

    public void MostrarMejorLibro(string genero) 
    {
        List<Libro> librosGenero = new List <Libro>();

        foreach (Libro libro in libros) 
            {
            if (libro.Genero == genero) 
            {
                librosGenero.Add(libro);
            }
        }

        Libro mejorLibro = estragiaRecomendacion.ObtenerMejorLibro(librosGenero);
        if (mejorLibro != null) 
        {
            Console.WriteLine(mejorLibro.Titulo);

        } else {
            Console.WriteLine("NINGUNO");
        }
    }
}
