using Elecciones.Entidades;

namespace Elecciones.DataStore
{
    public class DBVotantes
    {
        private List<Votante> padronElectoral = new List<Votante>()
        {
            new Votante()
            {idVotante=44,dni="40555788",nombre="Lorena",apellido="Juarez",
            domicilio = new Domicilio(){idDomicilio=174,nombreCalle="astrada",alturaDomicilio=4785,barrio="Saavedra",provincia="Buenos Aires"},
            fechaNacimiento = new DateTime(1999,06,25),centroDeVotacionAsignado = "Escuela 5", mesaAsignada = 8755, votoEjecutado = false},
            new Votante()
            {idVotante=45,dni="37880949",nombre="Horacio",apellido="Capdevila",
            domicilio = new Domicilio(){idDomicilio=175,nombreCalle="mitre",alturaDomicilio=545,barrio="Saavedra",provincia="Buenos Aires"},
            fechaNacimiento = new DateTime(1994,06,05),centroDeVotacionAsignado = "Escuela 5", mesaAsignada = 8755, votoEjecutado = false},
            new Votante()
            {idVotante=88,dni="38456789",nombre="Agustin",apellido="Fuentes",
            domicilio = new Domicilio(){idDomicilio=177,nombreCalle="astrada",alturaDomicilio=4787,barrio="Saavedra",provincia="Buenos Aires"},
            fechaNacimiento = new DateTime(1993,08,10),centroDeVotacionAsignado = "Escuela 5", mesaAsignada = 8755, votoEjecutado = false},
            new Votante()
            {idVotante=75,dni="40578477",nombre="Luciana",apellido="Lopez",
            domicilio = new Domicilio(){idDomicilio=6,nombreCalle="av corrientes",alturaDomicilio=955,barrio="Centro",provincia="Buenos Aires"},
            fechaNacimiento = new DateTime(2002,12,14),centroDeVotacionAsignado = "Escuela 20", mesaAsignada = 9015, votoEjecutado = false},
            new Votante()
            {idVotante=44,dni="9877544",nombre="Julio",apellido="Araujo",
            domicilio = new Domicilio(){idDomicilio=14,nombreCalle="av corrientes",alturaDomicilio=870,barrio="Centro",provincia="Buenos Aires"},
            fechaNacimiento = new DateTime(1932,02,01),centroDeVotacionAsignado = "Escuela 20", mesaAsignada = 9015, votoEjecutado = false},
        };

        public List<Votante> getPadron()
        {
            return this.padronElectoral;
        }

        public List<Votante> consultarPadronMesa(int numeroMesa)
        {

            List<Votante> padronMesa = new List<Votante>();
            foreach (Votante votante in padronElectoral)
            {
                if (votante.mesaAsignada == numeroMesa)
                {
                    padronMesa.Add(votante);
                }
            }

            return padronMesa;
        }

        public void actualizarPadronElectoral(List<Votante> votantes)
        {
            this.padronElectoral = votantes;
        }
        


    }
}