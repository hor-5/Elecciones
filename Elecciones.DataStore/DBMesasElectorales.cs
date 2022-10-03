using Elecciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.DataStore
{
    public class DBMesasElectorales
    {
        private List<MesaElectoral> mesasElectorales = new List<MesaElectoral>() { 
            new MesaElectoral() {idMesaElectoral=01,numeroDeMesa=9015 },
            new MesaElectoral() {idMesaElectoral=01,numeroDeMesa=8755 },
        };

        public List<MesaElectoral> getTodasLasMesas() {
            return mesasElectorales;
        }
        public MesaElectoral getMesaPorNumeroDeMesa(int numMesa) {
            MesaElectoral resultado = null;
            foreach (MesaElectoral mesa in mesasElectorales) {
                if (mesa.numeroDeMesa == numMesa) {
                    resultado = mesa;
                    break;
                }
            }
            return resultado;
        }

    }
}
