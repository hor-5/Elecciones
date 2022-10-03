namespace Elecciones.GUI.GUIAdministradores
{
    partial class FrmAdmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmGeneral));
            this.tbSelMesa = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbAdmin = new MaterialSkin.Controls.MaterialTabControl();
            this.pageResultados = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblNombreVotante = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSeleccionarVotante = new MaterialSkin.Controls.MaterialLabel();
            this.pageEstadisticas = new System.Windows.Forms.TabPage();
            this.lblVotosRestantesMesa = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblVotosEmitidosEnMesa = new MaterialSkin.Controls.MaterialLabel();
            this.btnEnviarResultadosMesa = new MaterialSkin.Controls.MaterialButton();
            this.lblTotalPadron = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbAdmin.SuspendLayout();
            this.pageResultados.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pageEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSelMesa
            // 
            this.tbSelMesa.BaseTabControl = this.tbAdmin;
            this.tbSelMesa.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tbSelMesa.Depth = 0;
            this.tbSelMesa.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSelMesa.Location = new System.Drawing.Point(6, 4);
            this.tbSelMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSelMesa.Name = "tbSelMesa";
            this.tbSelMesa.Size = new System.Drawing.Size(413, 19);
            this.tbSelMesa.TabIndex = 3;
            this.tbSelMesa.Text = "materialTabSelector1";
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.pageResultados);
            this.tbAdmin.Controls.Add(this.pageEstadisticas);
            this.tbAdmin.Depth = 0;
            this.tbAdmin.Location = new System.Drawing.Point(6, 29);
            this.tbAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbAdmin.Multiline = true;
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.SelectedIndex = 0;
            this.tbAdmin.Size = new System.Drawing.Size(788, 417);
            this.tbAdmin.TabIndex = 2;
            // 
            // pageResultados
            // 
            this.pageResultados.Controls.Add(this.materialCard3);
            this.pageResultados.Controls.Add(this.materialCard2);
            this.pageResultados.Controls.Add(this.materialCard1);
            this.pageResultados.Controls.Add(this.materialDivider1);
            this.pageResultados.Controls.Add(this.lblSeleccionarVotante);
            this.pageResultados.Location = new System.Drawing.Point(4, 24);
            this.pageResultados.Name = "pageResultados";
            this.pageResultados.Padding = new System.Windows.Forms.Padding(3);
            this.pageResultados.Size = new System.Drawing.Size(780, 389);
            this.pageResultados.TabIndex = 0;
            this.pageResultados.Text = "Resultados de la elección";
            this.pageResultados.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(518, 89);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(200, 200);
            this.materialCard3.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(17, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 24);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Tercer lugar";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(266, 89);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(200, 200);
            this.materialCard2.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(129, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Segundo lugar";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblNombreVotante);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(9, 89);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 200);
            this.materialCard1.TabIndex = 4;
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
            this.lblNombreVotante.Size = new System.Drawing.Size(111, 24);
            this.lblNombreVotante.TabIndex = 0;
            this.lblNombreVotante.Text = "Primer lugar";
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
            this.lblSeleccionarVotante.Location = new System.Drawing.Point(9, 20);
            this.lblSeleccionarVotante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccionarVotante.Name = "lblSeleccionarVotante";
            this.lblSeleccionarVotante.Size = new System.Drawing.Size(290, 41);
            this.lblSeleccionarVotante.TabIndex = 0;
            this.lblSeleccionarVotante.Text = "Centro de computo";
            // 
            // pageEstadisticas
            // 
            this.pageEstadisticas.Controls.Add(this.lblVotosRestantesMesa);
            this.pageEstadisticas.Controls.Add(this.materialLabel4);
            this.pageEstadisticas.Controls.Add(this.lblVotosEmitidosEnMesa);
            this.pageEstadisticas.Controls.Add(this.btnEnviarResultadosMesa);
            this.pageEstadisticas.Controls.Add(this.lblTotalPadron);
            this.pageEstadisticas.Controls.Add(this.materialDivider5);
            this.pageEstadisticas.Controls.Add(this.materialLabel1);
            this.pageEstadisticas.Location = new System.Drawing.Point(4, 24);
            this.pageEstadisticas.Name = "pageEstadisticas";
            this.pageEstadisticas.Padding = new System.Windows.Forms.Padding(3);
            this.pageEstadisticas.Size = new System.Drawing.Size(780, 389);
            this.pageEstadisticas.TabIndex = 1;
            this.pageEstadisticas.Text = "Detalle de resultados";
            this.pageEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lblVotosRestantesMesa
            // 
            this.lblVotosRestantesMesa.AutoSize = true;
            this.lblVotosRestantesMesa.Depth = 0;
            this.lblVotosRestantesMesa.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVotosRestantesMesa.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lblVotosRestantesMesa.HighEmphasis = true;
            this.lblVotosRestantesMesa.Location = new System.Drawing.Point(452, 141);
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
            this.materialLabel4.Location = new System.Drawing.Point(378, 85);
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
            this.lblVotosEmitidosEnMesa.Location = new System.Drawing.Point(147, 141);
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
            this.btnEnviarResultadosMesa.Location = new System.Drawing.Point(185, 269);
            this.btnEnviarResultadosMesa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarResultadosMesa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarResultadosMesa.Name = "btnEnviarResultadosMesa";
            this.btnEnviarResultadosMesa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEnviarResultadosMesa.Size = new System.Drawing.Size(258, 36);
            this.btnEnviarResultadosMesa.TabIndex = 5;
            this.btnEnviarResultadosMesa.Text = "Enviar resultados finales";
            this.btnEnviarResultadosMesa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEnviarResultadosMesa.UseAccentColor = false;
            this.btnEnviarResultadosMesa.UseVisualStyleBackColor = true;
            // 
            // lblTotalPadron
            // 
            this.lblTotalPadron.AutoSize = true;
            this.lblTotalPadron.Depth = 0;
            this.lblTotalPadron.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalPadron.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTotalPadron.Location = new System.Drawing.Point(85, 85);
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
            this.materialLabel1.Location = new System.Drawing.Point(7, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(247, 41);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Conteo de mesa";
            // 
            // FrmAdmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSelMesa);
            this.Controls.Add(this.tbAdmin);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdmGeneral";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminGeneral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbAdmin.ResumeLayout(false);
            this.pageResultados.ResumeLayout(false);
            this.pageResultados.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pageEstadisticas.ResumeLayout(false);
            this.pageEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector tbSelMesa;
        private MaterialSkin.Controls.MaterialTabControl tbAdmin;
        private TabPage pageResultados;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblNombreVotante;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblSeleccionarVotante;
        private TabPage pageEstadisticas;
        private MaterialSkin.Controls.MaterialLabel lblVotosRestantesMesa;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblVotosEmitidosEnMesa;
        private MaterialSkin.Controls.MaterialButton btnEnviarResultadosMesa;
        private MaterialSkin.Controls.MaterialLabel lblTotalPadron;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}