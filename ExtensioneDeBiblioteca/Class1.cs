using BiliotecaDeLibros;

namespace ExtensioneDeBiblioteca
{
    public static class LibroExtensiones 
    {
        public static bool EslibroAntiguo(this Libro libro) 
        {
            return ((DateTime.Now.Year - libro.AnioPublicacion) > 50);
        }

        public static string FormatoInformacion(this Libro libro) {
            return $"{libro.Autor} ({libro.Titulo} - {libro.AnioPublicacion})";
        }
    }
}
