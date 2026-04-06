

using MonitoreoDrones.Dominio.Enum;
using System.Transactions;

namespace MonitoreoDrones.Dominio.Entidades 
{
    internal class Dron 
    {
        //Atributos 
        public int Id { get; set; }
        public string Modelo { get; set; }
        public double NivelBateria { get; set; }
        public EstadoDron Estado {get; set;}
        public Posicion Posicion { get; set; }
        public Mision Mision { get; set; }

        //Construcor

        public Dron(int id, string modelo, double nivelBateria, Posicion posicion ) 
        {
            Id = id;
            Modelo = modelo;
            NivelBateria = nivelBateria;
            Posicion = posicion;
            Estado = EstadoDron.Inactivo;
        }

        //Metodos

        public void AsignarMision(Mision mision ) 
        {
            if (Estado != EstadoDron.Inactivo) {
                throw new InvalidOperationException("El dron no esta disponible");
            }
            Estado = EstadoDron.EnMision;
            Mision = mision;

        }

        public void ActualizarBateria(double nivel) {
            NivelBateria = nivel;
            if (NivelBateria <= 5) {
                Estado = EstadoDron.Mantenimiento;
            }
        }

    }
}
