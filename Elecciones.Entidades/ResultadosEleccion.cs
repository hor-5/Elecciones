using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class ResultadosEleccion
    {
        public int idResultadosEleccion { get; set; }
        public DateTime fechaEleccion { get; set; }
        public List<Boleta> conteoGeneral { get; set; }
        public PartidoPolitico ganadorElecciones { get; set; }
        public int cantidadTotalDeVotos { get; set; }
    }
}
