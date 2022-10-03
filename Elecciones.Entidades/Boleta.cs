using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Boleta
    {
        public int idBoleta { get; set; }
        public PartidoPolitico partidoPolitico { get; set; }
    }
}
