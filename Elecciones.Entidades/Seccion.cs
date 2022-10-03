using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Seccion
    {
        public int idSeccion { get; set; }
        public List<Circuito> aCircuitos { get; set; }
    }
}
