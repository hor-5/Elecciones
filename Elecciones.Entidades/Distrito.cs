using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Distrito
    {
        public int idDistrito { get; set; }
        public string nombreDistrito { get; set; }
        public List<Seccion> aSecciones { get; set; }
    }
}
