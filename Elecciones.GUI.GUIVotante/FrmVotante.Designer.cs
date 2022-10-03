namespace Elecciones.GUI.GUIVotante
{
    partial class FrmVotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVotante));
            this.tbSelVotacion = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbVotacion = new MaterialSkin.Controls.MaterialTabControl();
            this.pageSeleccionarBoleta = new System.Windows.Forms.TabPage();
            this.imgCandidato6 = new System.Windows.Forms.PictureBox();
            this.imgCandidato5 = new System.Windows.Forms.PictureBox();
            this.imgCandidato4 = new System.Windows.Forms.PictureBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.imgCandidato3 = new System.Windows.Forms.PictureBox();
            this.imgCandidato2 = new System.Windows.Forms.PictureBox();
            this.imgCandidato1 = new System.Windows.Forms.PictureBox();
            this.lblNumeroDeMesaValor = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumeroDeMesa = new MaterialSkin.Controls.MaterialLabel();
            this.lblDniVotanteValor = new MaterialSkin.Controls.MaterialLabel();
            this.lblDniVotante = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreVotanteValor = new MaterialSkin.Controls.MaterialLabel();
            this.lblNombreVotante = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pageConfirmarVoto = new System.Windows.Forms.TabPage();
            this.boxConfirmarVoto = new System.Windows.Forms.GroupBox();
            this.btnVolver = new MaterialSkin.Controls.MaterialButton();
            this.btnVotar = new MaterialSkin.Controls.MaterialButton();
            this.txtPartido = new MaterialSkin.Controls.MaterialLabel();
            this.lblPartido = new MaterialSkin.Controls.MaterialLabel();
            this.txtCandidatoVicepresidente = new MaterialSkin.Controls.MaterialLabel();
            this.lblCandidatoVicepresidente = new MaterialSkin.Controls.MaterialLabel();
            this.txtCandidatoPresidente = new MaterialSkin.Controls.MaterialLabel();
            this.lblCandidatoPresidente = new MaterialSkin.Controls.MaterialLabel();
            this.txtAlerta = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbVotacion.SuspendLayout();
            this.pageSeleccionarBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato1)).BeginInit();
            this.pageConfirmarVoto.SuspendLayout();
            this.boxConfirmarVoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelVotacion
            // 
            this.tbSelVotacion.BaseTabControl = this.tbVotacion;
            this.tbSelVotacion.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSelVotacion.Depth = 0;
            this.tbSelVotacion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSelVotacion.Location = new System.Drawing.Point(-1, -4);
            this.tbSelVotacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelVotacion.Name = "tbSelVotacion";
            this.tbSelVotacion.Size = new System.Drawing.Size(1400, 38);
            this.tbSelVotacion.TabIndex = 3;
            this.tbSelVotacion.Text = "materialTabSelector1";
            // 
            // tbVotacion
            // 
            this.tbVotacion.Controls.Add(this.pageSeleccionarBoleta);
            this.tbVotacion.Controls.Add(this.pageConfirmarVoto);
            this.tbVotacion.Depth = 0;
            this.tbVotacion.Location = new System.Drawing.Point(6, 29);
            this.tbVotacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbVotacion.Multiline = true;
            this.tbVotacion.Name = "tbVotacion";
            this.tbVotacion.SelectedIndex = 0;
            this.tbVotacion.Size = new System.Drawing.Size(1300, 710);
            this.tbVotacion.TabIndex = 2;
            // 
            // pageSeleccionarBoleta
            // 
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato6);
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato5);
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato4);
            this.pageSeleccionarBoleta.Controls.Add(this.materialDivider2);
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato3);
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato2);
            this.pageSeleccionarBoleta.Controls.Add(this.imgCandidato1);
            this.pageSeleccionarBoleta.Controls.Add(this.lblNumeroDeMesaValor);
            this.pageSeleccionarBoleta.Controls.Add(this.lblNumeroDeMesa);
            this.pageSeleccionarBoleta.Controls.Add(this.lblDniVotanteValor);
            this.pageSeleccionarBoleta.Controls.Add(this.lblDniVotante);
            this.pageSeleccionarBoleta.Controls.Add(this.lblNombreVotanteValor);
            this.pageSeleccionarBoleta.Controls.Add(this.lblNombreVotante);
            this.pageSeleccionarBoleta.Controls.Add(this.materialDivider1);
            this.pageSeleccionarBoleta.Location = new System.Drawing.Point(4, 24);
            this.pageSeleccionarBoleta.Name = "pageSeleccionarBoleta";
            this.pageSeleccionarBoleta.Padding = new System.Windows.Forms.Padding(3);
            this.pageSeleccionarBoleta.Size = new System.Drawing.Size(1292, 682);
            this.pageSeleccionarBoleta.TabIndex = 0;
            this.pageSeleccionarBoleta.Text = "Seleccione la boleta";
            this.pageSeleccionarBoleta.UseVisualStyleBackColor = true;
            // 
            // imgCandidato6
            // 
            this.imgCandidato6.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato6.Image")));
            this.imgCandidato6.Location = new System.Drawing.Point(828, 394);
            this.imgCandidato6.Name = "imgCandidato6";
            this.imgCandidato6.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato6.TabIndex = 14;
            this.imgCandidato6.TabStop = false;
            this.imgCandidato6.Click += new System.EventHandler(this.imgCandidato6_Click);
            // 
            // imgCandidato5
            // 
            this.imgCandidato5.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato5.Image")));
            this.imgCandidato5.Location = new System.Drawing.Point(589, 394);
            this.imgCandidato5.Name = "imgCandidato5";
            this.imgCandidato5.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato5.TabIndex = 13;
            this.imgCandidato5.TabStop = false;
            this.imgCandidato5.Click += new System.EventHandler(this.imgCandidato5_Click);
            // 
            // imgCandidato4
            // 
            this.imgCandidato4.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato4.Image")));
            this.imgCandidato4.Location = new System.Drawing.Point(329, 394);
            this.imgCandidato4.Name = "imgCandidato4";
            this.imgCandidato4.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato4.TabIndex = 12;
            this.imgCandidato4.TabStop = false;
            this.imgCandidato4.Click += new System.EventHandler(this.imgCandidato4_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(395, 365);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(500, 5);
            this.materialDivider2.TabIndex = 11;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // imgCandidato3
            // 
            this.imgCandidato3.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato3.Image")));
            this.imgCandidato3.Location = new System.Drawing.Point(828, 147);
            this.imgCandidato3.Name = "imgCandidato3";
            this.imgCandidato3.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato3.TabIndex = 10;
            this.imgCandidato3.TabStop = false;
            this.imgCandidato3.Click += new System.EventHandler(this.imgCandidato3_Click);
            // 
            // imgCandidato2
            // 
            this.imgCandidato2.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato2.Image")));
            this.imgCandidato2.Location = new System.Drawing.Point(589, 147);
            this.imgCandidato2.Name = "imgCandidato2";
            this.imgCandidato2.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato2.TabIndex = 9;
            this.imgCandidato2.TabStop = false;
            this.imgCandidato2.Click += new System.EventHandler(this.imgCandidato2_Click);
            // 
            // imgCandidato1
            // 
            this.imgCandidato1.Image = ((System.Drawing.Image)(resources.GetObject("imgCandidato1.Image")));
            this.imgCandidato1.Location = new System.Drawing.Point(329, 147);
            this.imgCandidato1.Name = "imgCandidato1";
            this.imgCandidato1.Size = new System.Drawing.Size(122, 190);
            this.imgCandidato1.TabIndex = 8;
            this.imgCandidato1.TabStop = false;
            this.imgCandidato1.Click += new System.EventHandler(this.imgCandidato1_Click);
            // 
            // lblNumeroDeMesaValor
            // 
            this.lblNumeroDeMesaValor.AutoSize = true;
            this.lblNumeroDeMesaValor.Depth = 0;
            this.lblNumeroDeMesaValor.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumeroDeMesaValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblNumeroDeMesaValor.Location = new System.Drawing.Point(1143, 31);
            this.lblNumeroDeMesaValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroDeMesaValor.Name = "lblNumeroDeMesaValor";
            this.lblNumeroDeMesaValor.Size = new System.Drawing.Size(53, 29);
            this.lblNumeroDeMesaValor.TabIndex = 7;
            this.lblNumeroDeMesaValor.Text = "8056";
            // 
            // lblNumeroDeMesa
            // 
            this.lblNumeroDeMesa.AutoSize = true;
            this.lblNumeroDeMesa.Depth = 0;
            this.lblNumeroDeMesa.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumeroDeMesa.Location = new System.Drawing.Point(1148, 12);
            this.lblNumeroDeMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroDeMesa.Name = "lblNumeroDeMesa";
            this.lblNumeroDeMesa.Size = new System.Drawing.Size(40, 19);
            this.lblNumeroDeMesa.TabIndex = 6;
            this.lblNumeroDeMesa.Text = "Mesa";
            // 
            // lblDniVotanteValor
            // 
            this.lblDniVotanteValor.AutoSize = true;
            this.lblDniVotanteValor.Depth = 0;
            this.lblDniVotanteValor.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDniVotanteValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDniVotanteValor.Location = new System.Drawing.Point(177, 31);
            this.lblDniVotanteValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDniVotanteValor.Name = "lblDniVotanteValor";
            this.lblDniVotanteValor.Size = new System.Drawing.Size(89, 24);
            this.lblDniVotanteValor.TabIndex = 5;
            this.lblDniVotanteValor.Text = "20546122";
            // 
            // lblDniVotante
            // 
            this.lblDniVotante.AutoSize = true;
            this.lblDniVotante.Depth = 0;
            this.lblDniVotante.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDniVotante.Location = new System.Drawing.Point(177, 12);
            this.lblDniVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDniVotante.Name = "lblDniVotante";
            this.lblDniVotante.Size = new System.Drawing.Size(27, 19);
            this.lblDniVotante.TabIndex = 4;
            this.lblDniVotante.Text = "DNI";
            // 
            // lblNombreVotanteValor
            // 
            this.lblNombreVotanteValor.AutoSize = true;
            this.lblNombreVotanteValor.Depth = 0;
            this.lblNombreVotanteValor.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreVotanteValor.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNombreVotanteValor.Location = new System.Drawing.Point(6, 31);
            this.lblNombreVotanteValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreVotanteValor.Name = "lblNombreVotanteValor";
            this.lblNombreVotanteValor.Size = new System.Drawing.Size(102, 24);
            this.lblNombreVotanteValor.TabIndex = 3;
            this.lblNombreVotanteValor.Text = "Juan Perez";
            // 
            // lblNombreVotante
            // 
            this.lblNombreVotante.AutoSize = true;
            this.lblNombreVotante.Depth = 0;
            this.lblNombreVotante.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNombreVotante.Location = new System.Drawing.Point(6, 12);
            this.lblNombreVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNombreVotante.Name = "lblNombreVotante";
            this.lblNombreVotante.Size = new System.Drawing.Size(57, 19);
            this.lblNombreVotante.TabIndex = 2;
            this.lblNombreVotante.Text = "Nombre";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 67);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1299, 5);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pageConfirmarVoto
            // 
            this.pageConfirmarVoto.Controls.Add(this.boxConfirmarVoto);
            this.pageConfirmarVoto.Controls.Add(this.txtAlerta);
            this.pageConfirmarVoto.Controls.Add(this.materialDivider5);
            this.pageConfirmarVoto.Controls.Add(this.materialLabel1);
            this.pageConfirmarVoto.Location = new System.Drawing.Point(4, 24);
            this.pageConfirmarVoto.Name = "pageConfirmarVoto";
            this.pageConfirmarVoto.Padding = new System.Windows.Forms.Padding(3);
            this.pageConfirmarVoto.Size = new System.Drawing.Size(1292, 682);
            this.pageConfirmarVoto.TabIndex = 1;
            this.pageConfirmarVoto.Text = "Confirme su voto";
            this.pageConfirmarVoto.UseVisualStyleBackColor = true;
            // 
            // boxConfirmarVoto
            // 
            this.boxConfirmarVoto.Controls.Add(this.btnVolver);
            this.boxConfirmarVoto.Controls.Add(this.btnVotar);
            this.boxConfirmarVoto.Controls.Add(this.txtPartido);
            this.boxConfirmarVoto.Controls.Add(this.lblPartido);
            this.boxConfirmarVoto.Controls.Add(this.txtCandidatoVicepresidente);
            this.boxConfirmarVoto.Controls.Add(this.lblCandidatoVicepresidente);
            this.boxConfirmarVoto.Controls.Add(this.txtCandidatoPresidente);
            this.boxConfirmarVoto.Controls.Add(this.lblCandidatoPresidente);
            this.boxConfirmarVoto.Location = new System.Drawing.Point(3, 72);
            this.boxConfirmarVoto.Name = "boxConfirmarVoto";
            this.boxConfirmarVoto.Size = new System.Drawing.Size(1227, 506);
            this.boxConfirmarVoto.TabIndex = 6;
            this.boxConfirmarVoto.TabStop = false;
            this.boxConfirmarVoto.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVolver.Depth = 0;
            this.btnVolver.HighEmphasis = true;
            this.btnVolver.Icon = null;
            this.btnVolver.Location = new System.Drawing.Point(26, 399);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVolver.Size = new System.Drawing.Size(76, 36);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVolver.UseAccentColor = true;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVotar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVotar.Depth = 0;
            this.btnVotar.HighEmphasis = true;
            this.btnVotar.Icon = null;
            this.btnVotar.Location = new System.Drawing.Point(644, 399);
            this.btnVotar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVotar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVotar.Size = new System.Drawing.Size(147, 36);
            this.btnVotar.TabIndex = 6;
            this.btnVotar.Text = "Confirmar voto";
            this.btnVotar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVotar.UseAccentColor = false;
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // txtPartido
            // 
            this.txtPartido.AutoSize = true;
            this.txtPartido.Depth = 0;
            this.txtPartido.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtPartido.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.txtPartido.Location = new System.Drawing.Point(976, 54);
            this.txtPartido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(167, 29);
            this.txtPartido.TabIndex = 5;
            this.txtPartido.Text = "sin información";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Depth = 0;
            this.lblPartido.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPartido.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblPartido.Location = new System.Drawing.Point(976, 19);
            this.lblPartido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(136, 24);
            this.lblPartido.TabIndex = 4;
            this.lblPartido.Text = "Partido politico";
            // 
            // txtCandidatoVicepresidente
            // 
            this.txtCandidatoVicepresidente.AutoSize = true;
            this.txtCandidatoVicepresidente.Depth = 0;
            this.txtCandidatoVicepresidente.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCandidatoVicepresidente.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.txtCandidatoVicepresidente.Location = new System.Drawing.Point(461, 54);
            this.txtCandidatoVicepresidente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCandidatoVicepresidente.Name = "txtCandidatoVicepresidente";
            this.txtCandidatoVicepresidente.Size = new System.Drawing.Size(167, 29);
            this.txtCandidatoVicepresidente.TabIndex = 3;
            this.txtCandidatoVicepresidente.Text = "sin información";
            // 
            // lblCandidatoVicepresidente
            // 
            this.lblCandidatoVicepresidente.AutoSize = true;
            this.lblCandidatoVicepresidente.Depth = 0;
            this.lblCandidatoVicepresidente.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCandidatoVicepresidente.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCandidatoVicepresidente.Location = new System.Drawing.Point(461, 19);
            this.lblCandidatoVicepresidente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCandidatoVicepresidente.Name = "lblCandidatoVicepresidente";
            this.lblCandidatoVicepresidente.Size = new System.Drawing.Size(244, 24);
            this.lblCandidatoVicepresidente.TabIndex = 2;
            this.lblCandidatoVicepresidente.Text = "Candidato a vicepresidente";
            // 
            // txtCandidatoPresidente
            // 
            this.txtCandidatoPresidente.AutoSize = true;
            this.txtCandidatoPresidente.Depth = 0;
            this.txtCandidatoPresidente.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCandidatoPresidente.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.txtCandidatoPresidente.Location = new System.Drawing.Point(6, 54);
            this.txtCandidatoPresidente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCandidatoPresidente.Name = "txtCandidatoPresidente";
            this.txtCandidatoPresidente.Size = new System.Drawing.Size(167, 29);
            this.txtCandidatoPresidente.TabIndex = 1;
            this.txtCandidatoPresidente.Text = "sin información";
            // 
            // lblCandidatoPresidente
            // 
            this.lblCandidatoPresidente.AutoSize = true;
            this.lblCandidatoPresidente.Depth = 0;
            this.lblCandidatoPresidente.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCandidatoPresidente.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCandidatoPresidente.Location = new System.Drawing.Point(6, 19);
            this.lblCandidatoPresidente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCandidatoPresidente.Name = "lblCandidatoPresidente";
            this.lblCandidatoPresidente.Size = new System.Drawing.Size(208, 24);
            this.lblCandidatoPresidente.TabIndex = 0;
            this.lblCandidatoPresidente.Text = "Candidato a presidente";
            // 
            // txtAlerta
            // 
            this.txtAlerta.AutoSize = true;
            this.txtAlerta.Depth = 0;
            this.txtAlerta.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtAlerta.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.txtAlerta.Location = new System.Drawing.Point(167, 188);
            this.txtAlerta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAlerta.Name = "txtAlerta";
            this.txtAlerta.Size = new System.Drawing.Size(638, 41);
            this.txtAlerta.TabIndex = 4;
            this.txtAlerta.Text = "Debe seleccionar algún candidato primero";
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
            this.materialLabel1.Location = new System.Drawing.Point(7, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(259, 41);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Confirme su voto";
            // 
            // FrmVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 735);
            this.Controls.Add(this.tbSelVotacion);
            this.Controls.Add(this.tbVotacion);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVotante";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbVotacion.ResumeLayout(false);
            this.pageSeleccionarBoleta.ResumeLayout(false);
            this.pageSeleccionarBoleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCandidato1)).EndInit();
            this.pageConfirmarVoto.ResumeLayout(false);
            this.pageConfirmarVoto.PerformLayout();
            this.boxConfirmarVoto.ResumeLayout(false);
            this.boxConfirmarVoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbSelVotacion;
        private MaterialSkin.Controls.MaterialTabControl tbVotacion;
        private TabPage pageSeleccionarBoleta;
        private MaterialSkin.Controls.MaterialLabel lblNumeroDeMesaValor;
        private MaterialSkin.Controls.MaterialLabel lblNumeroDeMesa;
        private MaterialSkin.Controls.MaterialLabel lblDniVotanteValor;
        private MaterialSkin.Controls.MaterialLabel lblDniVotante;
        private MaterialSkin.Controls.MaterialLabel lblNombreVotanteValor;
        private MaterialSkin.Controls.MaterialLabel lblNombreVotante;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private TabPage pageConfirmarVoto;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox imgCandidato6;
        private PictureBox imgCandidato5;
        private PictureBox imgCandidato4;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private PictureBox imgCandidato3;
        private PictureBox imgCandidato2;
        private PictureBox imgCandidato1;
        private GroupBox boxConfirmarVoto;
        private MaterialSkin.Controls.MaterialLabel txtPartido;
        private MaterialSkin.Controls.MaterialLabel lblPartido;
        private MaterialSkin.Controls.MaterialLabel txtCandidatoVicepresidente;
        private MaterialSkin.Controls.MaterialLabel lblCandidatoVicepresidente;
        private MaterialSkin.Controls.MaterialLabel txtCandidatoPresidente;
        private MaterialSkin.Controls.MaterialLabel lblCandidatoPresidente;
        private MaterialSkin.Controls.MaterialLabel txtAlerta;
        private MaterialSkin.Controls.MaterialButton btnVolver;
        private MaterialSkin.Controls.MaterialButton btnVotar;
    }
}