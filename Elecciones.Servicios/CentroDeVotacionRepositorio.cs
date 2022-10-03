using Elecciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Servicios
{
    public class CentroDeVotacionRepositorio
    {
        public CentroDeVotacion crearCentroDeVotacion(int idCentro,string nombreCentroVot,
                                                       int cantidadElectores, List<MesaElectoral> padronCentroVotacion) 
        {
            return new CentroDeVotacion() {
                                            idCentroDeVotacion = idCentro,
                                            nombrePuntoDeVotacion = nombreCentroVot,
                                            cantidadElectores = cantidadElectores,
                                            aMesasElectorales = padronCentroVotacion
                                            };

        }

    }
}
