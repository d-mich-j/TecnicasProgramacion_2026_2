namespace BiliotecaDeLibros
{
    public class Libro
    {
        //Atributos
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        //Constructor
        public Libro (string titulo, string autor, int anioPubliacion) {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPubliacion;
        }
    }
    
    public class GestorLibros {
        private List<Libro> libros = new List<Libro>();

        //Metodos 

        public void AgregarLibro (Libro libro) {
            libros.Add(libro);
        }

        public void EliminarLibro (string titulo) {
            libros.RemoveAll(l => l.Titulo == titulo);
        }

        public List <Libro > BuscarLibrosPorAutor(string autor) {
            return libros.FindAll(l => l.Autor == autor);
        }

        public void MostrarLibros() {
            foreach (Libro libro in libros) {
                Console.WriteLine($"Titulo: {libro.Titulo} ");
                Console.WriteLine($"Autor: {libro.Autor} ");
                Console.WriteLine($"Anio de Pulicacion: {libro.AnioPublicacion} \n ");

            }
        }
    }
}
