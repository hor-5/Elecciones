using Elecciones.Entidades;
using Elecciones.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Elecciones.GUI.GUIVotante
{
    public partial class FrmVotante : MaterialForm
    {
        static VotanteRepositorio votanteRepositorio = new VotanteRepositorio();
        static DomicilioRepositorio domRepositorio = new DomicilioRepositorio();
        static Domicilio domicilioEjemplo = domRepositorio.crearDomicilio(88, "Alvear", 548, "Recoleta", "Buenos Aires");
        private Votante votanteActual;
        private MesaElectoral mesaActual;

        public FrmVotante(Votante votante,MesaElectoral mesaElectoral)
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            votanteActual = votante;
            mesaActual = mesaElectoral;
            completarDatosVotante();
        }
        private void llenarDatos(string presidente, string vicepresidente, string partido)
        {
            //esto recibiria la Boleta
            txtAlerta.Visible = false;
            boxConfirmarVoto.Visible = true;
            txtCandidatoPresidente.Text = presidente;
            txtCandidatoVicepresidente.Text = vicepresidente;
            txtPartido.Text = partido;
        }
        private void irAPestaniaConfirmar()
        {
            tbVotacion.SelectedIndex++;
        }

        private void completarDatosVotante()
        {
            lblNombreVotanteValor.Text = votanteActual.nombre + " " + votanteActual.apellido;
            lblDniVotanteValor.Text = votanteActual.dni;
            lblNumeroDeMesaValor.Text = mesaActual.numeroDeMesa.ToString();
        }
        public void completarDatosVotante(Votante votante)
        {
            lblNombreVotanteValor.Text = votante.nombre + " " + votante.apellido;
            lblDniVotanteValor.Text = votante.dni;
            lblNumeroDeMesaValor.Text = mesaActual.numeroDeMesa.ToString();
            this.votanteActual = votante;
        }


        private void imgCandidato1_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("Alberto Fernandez", "Cristina Fernández de K.", "Frente de todos");
        }

        private void imgCandidato2_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("José Luis Espert", "Luis Rosales", "Despertar");
        }

        private void imgCandidato3_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("Mauricio Macri", "Miguel Angel Pichetto", "Juntos por el cambio");
        }

        private void imgCandidato4_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("Roberto Lavagna", "Juan Manuel Urtubey", "Consenso federal");
        }

        private void imgCandidato5_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("J.J. Gomez Centurión", "Cynthia Liliana Hotton", "Frente NOS");
        }

        private void imgCandidato6_Click(object sender, EventArgs e)
        {
            irAPestaniaConfirmar();
            llenarDatos("Nicolas del Caño", "Myriam Bregman", "Frente de izquierda");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            tbVotacion.SelectedIndex--;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("Voto emitido");
            tbVotacion.Visible = false;
            tbSelVotacion.Visible = false;
        }
    }
}
