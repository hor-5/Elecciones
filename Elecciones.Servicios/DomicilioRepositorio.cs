

using Elecciones.Entidades;

namespace Elecciones.Servicios
{
    public class DomicilioRepositorio
    {
        public Domicilio crearDomicilio(int idDomicilio, string nombreCalle, int alturaDomicilio,
                                        string barrio, string provincia)
        {
            return new Domicilio(){
                                        idDomicilio = idDomicilio,
                                        nombreCalle = nombreCalle,
                                        alturaDomicilio = alturaDomicilio,
                                        barrio = barrio,
                                        provincia = provincia
                                    };
        }
    }
}
