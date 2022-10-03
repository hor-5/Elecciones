using Elecciones.Entidades;
using Elecciones.GUI.GUIVotante;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Elecciones.GUI.GUIAdministradores
{
    public partial class FrmAdmMesa : MaterialForm
    {
        FrmVotante frmVotante;
        MesaElectoral mesaActual;
        public FrmAdmMesa(FrmVotante frmVotante, MesaElectoral mesaActual)
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.frmVotante = frmVotante;
            this.mesaActual = mesaActual;
            completarDatos();
        }

        public void completarDatos() {
            lblNumeroMesaValor.Text = mesaActual.numeroDeMesa.ToString();
        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider3_Click(object sender, EventArgs e)
        {

        }

        private void lblDniValor_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarVoto_Click(object sender, EventArgs e)
        {
            String dniBuscado = lblDniValor.Text;
            Votante votanteEncontrado = buscarVotante(dniBuscado);
            frmVotante.completarDatosVotante(votanteEncontrado);
            frmVotante.Show();

            MaterialMessageBox.Show($"Votante {votanteEncontrado.nombre} {votanteEncontrado.apellido} asigando a la mesa");
        }
        private Votante buscarVotante(String dniBuscado) {
            Votante resultado = null;
            foreach (Votante votante in mesaActual.aVotantesAsignados)
            {
                if (votante.dni == dniBuscado)
                {
                    resultado = votante;
                }
            }

            return resultado;
        }

        private void completarDatosCardVotante(Votante votante) {
            cardVotante.Visible = true;
            lblNombreVotante.Text = $"{votante.nombre} {votante.apellido}";
            lblDniValor.Text = votante.dni;
            lblFechaNacValor.Text = votante.fechaNacimiento.ToString("dd/MM/yyyy");          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String dniBuscado = txtBuscarVotante.Text;
            Votante votanteEncontrado = buscarVotante(dniBuscado);
            if (votanteEncontrado != null)
            {
                completarDatosCardVotante(votanteEncontrado);
                MaterialMessageBox.Show($"Votante encontrado {votanteEncontrado.nombre} {votanteEncontrado.apellido}");
            }
            else {
                MaterialMessageBox.Show($"No hay ningun votante registrado en la mesa con el dni {dniBuscado}");
            }

        }
    }
}
