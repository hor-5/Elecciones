using Elecciones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elecciones.Servicios
{
    public class VotanteRepositorio
    {
        public Votante crearVotante(int idVotante,string dni, 
                                    string nombre,string apellido, Domicilio domicilio,
                                    DateTime fechaNac, string centroVotacionAsignado,
                                    int mesaAsignada,Boolean votoEjecutado) 
        {

            return new Votante() { 
                                    idVotante=idVotante,
                                    dni=dni,
                                    nombre = nombre,
                                    apellido = apellido,
                                    domicilio=domicilio,
                                    fechaNacimiento = fechaNac,
                                    centroDeVotacionAsignado = centroVotacionAsignado,
                                    mesaAsignada = mesaAsignada,
                                    votoEjecutado = votoEjecutado
                                  };
        }


    }
}
