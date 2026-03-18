using BiliotecaDeLibros;
using ExtensioneDeBiblioteca;
using ValidacionesBiblioteca;


GestorLibros gestor = new GestorLibros();

//Agregar libro

gestor.AgregarLibro(new Libro("El Señor de los Anillos", "Tolkien", 1954 ));
gestor.AgregarLibro(new Libro("Dune", "Herbert", 1965));
gestor.AgregarLibro(new Libro("Juego de tronos", "George", 1996));

//Mostrar libros
Console.WriteLine("Libros en la biblioteca");
gestor.MostrarLibros();

//Usar metodo de extension Informacion de un libro

Libro libro = gestor.BuscarLibrosPorAutor("George")[0];
Console.WriteLine(libro.FormatoInformacion());

Libro libro2 = gestor.BuscarLibrosPorAutor("Tolkien")[0];
Console.WriteLine(libro2.FormatoInformacion());

Console.WriteLine();

