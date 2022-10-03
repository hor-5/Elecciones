using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Candidato : Votante
    {
        public int idCandidato { get; set; }
        public string cargoDePostulacion { get; set; }

    }
}
