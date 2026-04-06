using MonitoreoDrones.Dominio.Entidades;
using MonitoreoDrones.Dominio.Enum;
using System.Reflection.Metadata.Ecma335;

namespace MonitoreoDrones.Extensiones {
    public static class ExtensionesDron 
    {
        //Metodos 

        public static bool TieneBateriaBaja(this Dron dron) {
          /*  if (dron.NivelBateria <= 20)
                return true;
        }
        return false;*/

        return dron.NivelBateria <= 20;
    }

    public static bool PuedeInicirMision (this Dron dron) {
            return dron.Estado == EstadoDron.Inactivo && dron.NivelBateria > 20;
    }


}
