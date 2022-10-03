using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class PartidoPolitico
    {
        public int idPartidoPolitico { get; set; }
        public string nombrePartidoPolitico { get; set; }
        public List<Candidato> candidatos { get; set; }
    }
}
