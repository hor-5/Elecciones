using Elecciones.DataStore;
using Elecciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Servicios
{
    public class MesaElectoralRepositorio
    {
        DBMesasElectorales mesasElectorales = new DBMesasElectorales();
        ServiciosDeSeguridad serviciosDeSeguridad = new ServiciosDeSeguridad();
        public MesaElectoral crearMesaElectoral(int idMesa, int numMesa, 
                                                List<Votante> aVotantes)
        {
            return new MesaElectoral() {
                                        idMesaElectoral=idMesa,
                                        numeroDeMesa = numMesa,                                        
                                        aVotantesAsignados = aVotantes
                                        };

        }

        public MesaElectoral getMesaElectoral(int numMesa) {

            List<Votante> padronMesa = serviciosDeSeguridad.getPadronMesa(numMesa);
            MesaElectoral mesaSeleccionada = mesasElectorales.getMesaPorNumeroDeMesa(numMesa);
            mesaSeleccionada.aVotantesAsignados = padronMesa;

            return mesaSeleccionada;
        }
    }
}
