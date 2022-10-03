using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public bool esSuperUsuario { get; set; }
        public int mesaAsignada{get;set;}

        //public void setMesaAsignada(int numMesa) {
        //    if (!esSuperUsuario)
        //    {
        //        this.mesaAsignada = numMesa;
        //    }
        //}

        //public int getMesaAsignada()
        //{
        //    int resultado = 0;
        //    if (!esSuperUsuario)
        //    {
        //        resultado = mesaAsignada;
        //    }
        //    return resultado;
        //}


    }
}
