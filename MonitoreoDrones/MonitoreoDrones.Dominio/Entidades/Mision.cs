

namespace MonitoreoDrones.Dominio.Entidades 
{
    internal class Mision {
        //Atributos 
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int DuracionEstimada { get; set; }
        public bool Completada { get; set; }

        //Constructor
        public Mision(int id, string tipo, int duracion, bool completada) {
            Id = id;
            Tipo = tipo;
            DuracionEstimada = duracion;
            Completada = false;
        }

        //Metodos 
        public void CompletarMision() {
            Completada = true;
        }

    }

    
}
