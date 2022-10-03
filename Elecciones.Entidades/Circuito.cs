using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Circuito
    {        
        public int idCircuito { get; set; }
        public int numeroDeCircuito { get; set; }        
        public List<CentroDeVotacion> aCentrosDeVotacion { get; set; }
    }
}
