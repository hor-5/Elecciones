using Elecciones.DataStore;
using Elecciones.Entidades;

namespace Elecciones.Servicios
{
    public class ServiciosDeSeguridad
    {
        DBVotantes dbVotantes = new DBVotantes();
        DBUsuarios dBUsuarios = new DBUsuarios();
        public List<Votante> getPadronCompleto() {
            return dbVotantes.getPadron();
        }

        public List<Votante> getPadronMesa(int numMesa) {
            return dbVotantes.consultarPadronMesa(numMesa);
        }

        public Usuario login(String usuarioIngresado, String claveIngresada) {            
            Usuario resultado = null;
            foreach (Usuario usuario in dBUsuarios.getUsuarios()) {
                if (usuario.nombreUsuario == usuarioIngresado && usuario.clave == claveIngresada) {
                    resultado = usuario;
                    break;
                }
            }
            return resultado;
        }
    }
}