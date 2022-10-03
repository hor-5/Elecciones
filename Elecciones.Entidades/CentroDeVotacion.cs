using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class CentroDeVotacion
    {
        public int idCentroDeVotacion { get; set; }
        public string nombrePuntoDeVotacion { get; set; }
        public int cantidadElectores { get; set; }
        public List<MesaElectoral> aMesasElectorales { get; set; }
    }
}
