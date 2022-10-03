using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class MesaElectoral
    {
        public int idMesaElectoral { get; set; }
        public int numeroDeMesa { get; set; }

        //public Votante presidenteDeMesa { get; set; }        
        public List<Votante> aVotantesAsignados { get; set; }

    }
}
