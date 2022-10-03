namespace Elecciones.GUI.GUIAdministradores
{
    partial class FrmAdmMesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmMesa));
            this.tbMesa = new MaterialSkin.Controls.MaterialTabControl();
            this.pageAsignarVotante = new System.Windows.Forms.TabPage();
            this.lblNumeroMesaValor = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumeroMesa = new MaterialSkin.Controls.MaterialLabel();
            this.cardVotante = new MaterialSkin.Controls.MaterialCard();
            this.btnAsignarVoto = new MaterialSkin.Controls.MaterialButton();
            this.lblFechaNacValor = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.lblFechaNac = new MaterialSkin.Controls.MaterialLabel();
            this.lblDniValor = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.lblDni = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreVotante = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtBuscarVotante = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSeleccionarVotante = new MaterialSkin.Controls.MaterialLabel();
            this.pageConteoMesa = new System.Windows.Forms.TabPage();
            this.lblVotosRestantesMesa = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblVotosEmitidosEnMesa = new MaterialSkin.Controls.MaterialLabel();
            this.btnEnviarResultadosMesa = new MaterialSkin.Controls.MaterialButton();
            this.lblTotalPadron = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbSelMesa = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbMesa.SuspendLayout();
            this.pageAsignarVotante.SuspendLayout();
            this.cardVotante.SuspendLayout();
            this.pageConteoMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMesa
            // 
            this.tbMesa.Controls.Add(this.pageAsignarVotante);
            this.tbMesa.Controls.Add(this.pageConteoMesa);
            this.tbMesa.Depth = 0;
            this.tbMesa.Location = new System.Drawing.Point(6, 27);
            this.tbMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbMesa.Multiline = true;
            this.tbMesa.Name = "tbMesa";
            this.tbMesa.SelectedIndex = 0;
            this.tbMesa.Size = new System.Drawing.Size(1238, 417);
            this.tbMesa.TabIndex = 0;
            // 
            // pageAsignarVotante
            // 
            this.pageAsignarVotante.Controls.Add(this.lblNumeroMesaValor);
            this.pageAsignarVotante.Controls.Add(this.lblNumeroMesa);
            this.pageAsignarVotante.Controls.Add(this.cardVotante);
            this.pageAsignarVotante.Controls.Add(this.btnBuscar);
            this.pageAsignarVotante.Controls.Add(this.txtBuscarVotante);
            this.pageAsignarVotante.Controls.Add(this.materialDivider1);
            this.pageAsignarVotante.Controls.Add(this.lblSeleccionarVotante);
            this.pageAsignarVotante.Location = new System.Drawing.Point(4, 24);
            this.pageAsignarVotante.Name = "pageAsignarVotante";
            this.pageAsignarVotante.Padding = new System.Windows.Forms.Padding(3);
            this.pageAsignarVotante.Size = new System.Drawing.Size(1230, 389);
            this.pageAsignarVotante.TabIndex = 0;
            this.pageAsignarVotante.Text = "Asignar votante";
            this.pageAsignarVotante.UseVisualStyleBackColor = true;
            // 
            // lblNumeroMesaValor
            // 
            this.lblNumeroMesaValor.AutoSize = true;
            this.lblNumeroMesaValor.Depth = 0;
            this.lblNumeroMesaValor.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumeroMesaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblNumeroMesaValor.Location = new System.Drawing.Point(1105, 67);
            this.lblNumeroMesaValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroMesaValor.Name = "lblNumeroMesaValor";
            this.lblNumeroMesaValor.Size = new System.Drawing.Size(28, 58);
            this.lblNumeroMesaValor.TabIndex = 6;
            this.lblNumeroMesaValor.Text = "0";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Depth = 0;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumeroMesa.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblNumeroMesa.Location = new System.Drawing.Point(1093, 17);
            this.lblNumeroMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(86, 41);
            this.lblNumeroMesa.TabIndex = 5;
            this.lblNumeroMesa.Text = "Mesa";
            // 
            // cardVotante
            // 
            this.cardVotante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardVotante.Controls.Add(this.btnAsignarVoto);
            this.cardVotante.Controls.Add(this.lblFechaNacValor);
            this.cardVotante.Controls.Add(this.materialDivider3);
            this.cardVotante.Controls.Add(this.lblFechaNac);
            this.cardVotante.Controls.Add(this.lblDniValor);
            this.cardVotante.Controls.Add(this.materialDivider2);
            this.cardVotante.Controls.Add(this.lblDni);
            this.cardVotante.Controls.Add(this.lblNombreVotante);
            this.cardVotante.Depth = 0;
            this.cardVotante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardVotante.Location = new System.Drawing.Point(7, 147);
            this.cardVotante.Margin = new System.Windows.Forms.Padding(14);
            this.cardVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardVotante.Name = "cardVotante";
            this.cardVotante.Padding = new System.Windows.Forms.Padding(14);
            this.cardVotante.Size = new System.Drawing.Size(287, 202);
            this.cardVotante.TabIndex = 4;
            this.cardVotante.Visible = false;
            // 
            // btnAsignarVoto
            // 
            this.btnAsignarVoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignarVoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignarVoto.Depth = 0;
            this.btnAsignarVoto.HighEmphasis = true;
            this.btnAsignarVoto.Icon = null;
            this.btnAsignarVoto.Location = new System.Drawing.Point(63, 146);
            this.btnAsignarVoto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignarVoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignarVoto.Name = "btnAsignarVoto";
            this.btnAsignarVoto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsignarVoto.Size = new System.Drawing.Size(126, 36);
            this.btnAsignarVoto.TabIndex = 10;
            this.btnAsignarVoto.Text = "Asignar voto";
            this.btnAsignarVoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnAsignarVoto.UseAccentColor = false;
            this.btnAsignarVoto.UseVisualStyleBackColor = true;
            this.btnAsignarVoto.Click += new System.EventHandler(this.btnAsignarVoto_Click);
            // 
            // lblFechaNacValor
            // 
            this.lblFechaNacValor.AutoSize = true;
            this.lblFechaNacValor.Depth = 0;
            this.lblFechaNacValor.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaNacValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblFechaNacValor.Location = new System.Drawing.Point(172, 79);
            this.lblFechaNacValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNacValor.Name = "lblFechaNacValor";
            this.lblFechaNacValor.Size = new System.Drawing.Size(77, 17);
            this.lblFechaNacValor.TabIndex = 6;
            this.lblFechaNacValor.Text = "05/06/1994";
            this.lblFechaNacValor.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(22, 99);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(227, 3);
            this.materialDivider3.TabIndex = 5;
            this.materialDivider3.Text = "materialDivider3";
            this.materialDivider3.Click += new System.EventHandler(this.materialDivider3_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Depth = 0;
            this.lblFechaNac.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFechaNac.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblFechaNac.Location = new System.Drawing.Point(17, 82);
            this.lblFechaNac.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(114, 14);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            this.lblFechaNac.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // lblDniValor
            // 
            this.lblDniValor.AutoSize = true;
            this.lblDniValor.Depth = 0;
            this.lblDniValor.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDniValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblDniValor.Location = new System.Drawing.Point(184, 51);
            this.lblDniValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDniValor.Name = "lblDniValor";
            this.lblDniValor.Size = new System.Drawing.Size(65, 17);
            this.lblDniValor.TabIndex = 3;
            this.lblDniValor.Text = "37880949";
            this.lblDniValor.Click += new System.EventHandler(this.lblDniValor_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(22, 71);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(227, 3);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            this.materialDivider2.Click += new System.EventHandler(this.materialDivider2_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Depth = 0;
            this.lblDni.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDni.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblDni.Location = new System.Drawing.Point(17, 54);
            this.lblDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(21, 14);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // lblNombreVotante
            // 
            this.lblNombreVotante.AutoSize = true;
            this.lblNombreVotante.Depth = 0;
            this.lblNombreVotante.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreVotante.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNombreVotante.Location = new System.Drawing.Point(17, 14);
            this.lblNombreVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreVotante.Name = "lblNombreVotante";
            this.lblNombreVotante.Size = new System.Drawing.Size(163, 24);
            this.lblNombreVotante.TabIndex = 0;
            this.lblNombreVotante.Text = "Horacio Capdevila";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Icon")));
            this.btnBuscar.Location = new System.Drawing.Point(228, 79);
            this.btnBuscar.Mini = true;
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarVotante
            // 
            this.txtBuscarVotante.AllowPromptAsInput = true;
            this.txtBuscarVotante.AnimateReadOnly = false;
            this.txtBuscarVotante.AsciiOnly = false;
            this.txtBuscarVotante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscarVotante.BeepOnError = false;
            this.txtBuscarVotante.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscarVotante.Depth = 0;
            this.txtBuscarVotante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarVotante.HelperText = "Ingrese el DNI para buscar";
            this.txtBuscarVotante.HidePromptOnLeave = false;
            this.txtBuscarVotante.HideSelection = true;
            this.txtBuscarVotante.Hint = "Ingrese el dni del votante";
            this.txtBuscarVotante.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtBuscarVotante.LeadingIcon = null;
            this.txtBuscarVotante.Location = new System.Drawing.Point(6, 83);
            this.txtBuscarVotante.Mask = "00000009";
            this.txtBuscarVotante.MaxLength = 32767;
            this.txtBuscarVotante.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarVotante.Name = "txtBuscarVotante";
            this.txtBuscarVotante.PasswordChar = '\0';
            this.txtBuscarVotante.PrefixSuffixText = null;
            this.txtBuscarVotante.PromptChar = ' ';
            this.txtBuscarVotante.ReadOnly = false;
            this.txtBuscarVotante.RejectInputOnFirstFailure = false;
            this.txtBuscarVotante.ResetOnPrompt = true;
            this.txtBuscarVotante.ResetOnSpace = true;
            this.txtBuscarVotante.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscarVotante.SelectedText = "";
            this.txtBuscarVotante.SelectionLength = 0;
            this.txtBuscarVotante.SelectionStart = 0;
            this.txtBuscarVotante.ShortcutsEnabled = true;
            this.txtBuscarVotante.Size = new System.Drawing.Size(250, 36);
            this.txtBuscarVotante.SkipLiterals = true;
            this.txtBuscarVotante.TabIndex = 2;
            this.txtBuscarVotante.TabStop = false;
            this.txtBuscarVotante.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarVotante.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtBuscarVotante.TrailingIcon = null;
            this.txtBuscarVotante.UseSystemPasswordChar = false;
            this.txtBuscarVotante.UseTallSize = false;
            this.txtBuscarVotante.ValidatingType = null;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 67);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(581, 5);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblSeleccionarVotante
            // 
            this.lblSeleccionarVotante.AutoSize = true;
            this.lblSeleccionarVotante.Depth = 0;
            this.lblSeleccionarVotante.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSeleccionarVotante.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblSeleccionarVotante.Location = new System.Drawing.Point(6, 17);
            this.lblSeleccionarVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccionarVotante.Name = "lblSeleccionarVotante";
            this.lblSeleccionarVotante.Size = new System.Drawing.Size(299, 41);
            this.lblSeleccionarVotante.TabIndex = 0;
            this.lblSeleccionarVotante.Text = "Seleccionar votante";
            // 
            // pageConteoMesa
            // 
            this.pageConteoMesa.Controls.Add(this.lblVotosRestantesMesa);
            this.pageConteoMesa.Controls.Add(this.materialLabel4);
            this.pageConteoMesa.Controls.Add(this.lblVotosEmitidosEnMesa);
            this.pageConteoMesa.Controls.Add(this.btnEnviarResultadosMesa);
            this.pageConteoMesa.Controls.Add(this.lblTotalPadron);
            this.pageConteoMesa.Controls.Add(this.materialDivider5);
            this.pageConteoMesa.Controls.Add(this.materialLabel1);
            this.pageConteoMesa.Location = new System.Drawing.Point(4, 24);
            this.pageConteoMesa.Name = "pageConteoMesa";
            this.pageConteoMesa.Padding = new System.Windows.Forms.Padding(3);
            this.pageConteoMesa.Size = new System.Drawing.Size(1230, 389);
            this.pageConteoMesa.TabIndex = 1;
            this.pageConteoMesa.Text = "Conteo de mesa";
            this.pageConteoMesa.UseVisualStyleBackColor = true;
            // 
            // lblVotosRestantesMesa
            // 
            this.lblVotosRestantesMesa.AutoSize = true;
            this.lblVotosRestantesMesa.Depth = 0;
            this.lblVotosRestantesMesa.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVotosRestantesMesa.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblVotosRestantesMesa.HighEmphasis = true;
            this.lblVotosRestantesMesa.Location = new System.Drawing.Point(449, 138);
            this.lblVotosRestantesMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVotosRestantesMesa.Name = "lblVotosRestantesMesa";
            this.lblVotosRestantesMesa.Size = new System.Drawing.Size(34, 72);
            this.lblVotosRestantesMesa.TabIndex = 8;
            this.lblVotosRestantesMesa.Text = "0";
            this.lblVotosRestantesMesa.UseAccent = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(375, 82);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(176, 24);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Restantes por votar";
            // 
            // lblVotosEmitidosEnMesa
            // 
            this.lblVotosEmitidosEnMesa.AutoSize = true;
            this.lblVotosEmitidosEnMesa.Depth = 0;
            this.lblVotosEmitidosEnMesa.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVotosEmitidosEnMesa.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblVotosEmitidosEnMesa.HighEmphasis = true;
            this.lblVotosEmitidosEnMesa.Location = new System.Drawing.Point(144, 138);
            this.lblVotosEmitidosEnMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVotosEmitidosEnMesa.Name = "lblVotosEmitidosEnMesa";
            this.lblVotosEmitidosEnMesa.Size = new System.Drawing.Size(34, 72);
            this.lblVotosEmitidosEnMesa.TabIndex = 6;
            this.lblVotosEmitidosEnMesa.Text = "0";
            this.lblVotosEmitidosEnMesa.UseAccent = true;
            // 
            // btnEnviarResultadosMesa
            // 
            this.btnEnviarResultadosMesa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarResultadosMesa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEnviarResultadosMesa.Depth = 0;
            this.btnEnviarResultadosMesa.HighEmphasis = true;
            this.btnEnviarResultadosMesa.Icon = ((System.Drawing.Image)(resources.GetObject("btnEnviarResultadosMesa.Icon")));
            this.btnEnviarResultadosMesa.Location = new System.Drawing.Point(182, 266);
            this.btnEnviarResultadosMesa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarResultadosMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarResultadosMesa.Name = "btnEnviarResultadosMesa";
            this.btnEnviarResultadosMesa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnviarResultadosMesa.Size = new System.Drawing.Size(258, 36);
            this.btnEnviarResultadosMesa.TabIndex = 5;
            this.btnEnviarResultadosMesa.Text = "Enviar resultados finales";
            this.btnEnviarResultadosMesa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnEnviarResultadosMesa.UseAccentColor = false;
            this.btnEnviarResultadosMesa.UseVisualStyleBackColor = true;
            // 
            // lblTotalPadron
            // 
            this.lblTotalPadron.AutoSize = true;
            this.lblTotalPadron.Depth = 0;
            this.lblTotalPadron.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalPadron.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalPadron.Location = new System.Drawing.Point(82, 82);
            this.lblTotalPadron.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalPadron.Name = "lblTotalPadron";
            this.lblTotalPadron.Size = new System.Drawing.Size(156, 24);
            this.lblTotalPadron.TabIndex = 4;
            this.lblTotalPadron.Text = "Votos ejecutados";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(4, 61);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(581, 5);
            this.materialDivider5.TabIndex = 3;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(4, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(247, 41);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Conteo de mesa";
            // 
            // tbSelMesa
            // 
            this.tbSelMesa.BaseTabControl = this.tbMesa;
            this.tbSelMesa.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSelMesa.Depth = 0;
            this.tbSelMesa.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSelMesa.Location = new System.Drawing.Point(6, 2);
            this.tbSelMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelMesa.Name = "tbSelMesa";
            this.tbSelMesa.Size = new System.Drawing.Size(413, 19);
            this.tbSelMesa.TabIndex = 1;
            this.tbSelMesa.Text = "materialTabSelector1";
            // 
            // FrmAdmMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.tbSelMesa);
            this.Controls.Add(this.tbMesa);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdmMesa";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmMesa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbMesa.ResumeLayout(false);
            this.pageAsignarVotante.ResumeLayout(false);
            this.pageAsignarVotante.PerformLayout();
            this.cardVotante.ResumeLayout(false);
            this.cardVotante.PerformLayout();
            this.pageConteoMesa.ResumeLayout(false);
            this.pageConteoMesa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbMesa;
        private TabPage pageAsignarVotante;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblFechaNacValor;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel lblFechaNac;
        private MaterialSkin.Controls.MaterialLabel lblDniValor;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel lblDni;
        private MaterialSkin.Controls.MaterialLabel lblNombreVotante;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnBuscar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtBuscarVotante;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblSeleccionarVotante;
        private TabPage pageConteoMesa;
        private MaterialSkin.Controls.MaterialTabSelector tbSelMesa;
        private MaterialSkin.Controls.MaterialButton btnAsignarVoto;
        private MaterialSkin.Controls.MaterialLabel lblVotosRestantesMesa;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblVotosEmitidosEnMesa;
        private MaterialSkin.Controls.MaterialButton btnEnviarResultadosMesa;
        private MaterialSkin.Controls.MaterialLabel lblTotalPadron;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard cardVotante;
        private MaterialSkin.Controls.MaterialLabel lblNumeroMesaValor;
        private MaterialSkin.Controls.MaterialLabel lblNumeroMesa;
    }
}