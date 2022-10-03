namespace Elecciones.Entidades
{
    public class Votante
    {
        public int idVotante { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Domicilio domicilio { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string centroDeVotacionAsignado { get; set; }
        public int mesaAsignada { get; set; }
        public int? numComprobanteDeVoto { get; set; }
        public bool votoEjecutado { get; set; }



    }
}