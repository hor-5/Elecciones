using Elecciones.Entidades;
using Elecciones.GUI.GUIVotante;
using Elecciones.Servicios;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Elecciones.GUI.GUIAdministradores
{
    public partial class FrmAdmLogin : MaterialForm
    {

        ServiciosDeSeguridad serviciosDeSeguridad = new ServiciosDeSeguridad();
        MesaElectoralRepositorio mesaElectoralRepositorio = new MesaElectoralRepositorio();
        public FrmAdmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            Usuario usuarioSeleccionado = serviciosDeSeguridad.login(txtUsuario.Text, txtClave.Text);

            if (usuarioSeleccionado != null) {
                if (usuarioSeleccionado.esSuperUsuario)
                {
                    //abrir admin general
                    FrmAdmGeneral admGeneral = new FrmAdmGeneral();
                    admGeneral.Show();
                    this.Hide();

                }
                else {
                    
                    //setear mesa electoral
                    MesaElectoral mesaSeleccionada = mesaElectoralRepositorio.getMesaElectoral(usuarioSeleccionado.mesaAsignada);
                    //abrir admin mesa
                    FrmVotante frmvotante = new FrmVotante(new Votante(), mesaSeleccionada);
                    FrmAdmMesa admMesa = new FrmAdmMesa(frmvotante, mesaSeleccionada);
                    admMesa.Show();
                    this.Hide();
                }
            }
            else
            {

                MaterialMessageBox.Show("Ingrese un usuario válido");
            }
        }
    }
}
