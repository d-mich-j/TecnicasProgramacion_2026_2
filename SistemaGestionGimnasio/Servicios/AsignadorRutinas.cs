using SistemaGestionGimnasio.Modelo;
namespace SistemaGestionGimnasio.Servicios {
    public class AsignadorRutinas {
        public void AsignarRutinaAUsuario(Usuario usuario, Rutina rutina) {
            usuario.AsignarRutina(rutina);
        }
        public void AsignarUsuarioAEntrenador(Usuario usuario, Entrenador entrenador) {
            entrenador.AsignarUsuario(usuario);
        }
    }
}
