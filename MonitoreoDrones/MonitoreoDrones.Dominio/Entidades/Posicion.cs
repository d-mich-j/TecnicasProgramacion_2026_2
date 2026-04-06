

namespace MonitoreoDrones.Dominio.Entidades {
    public class Posicion {
        //Atributos 

        public double Latitud { get; private set; }
        public double Longitud { get; private set; }

        //Constructor 

        public Posicion(double longitud, double latitud ) {
            Latitud =  latitud;
            Longitud = longitud;
        }

        //Metodos

    }
}
