namespace Elecciones.GUI.GUIVotante
{
    partial class FrmPantallaSuspenso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaSuspenso));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.imgEscudoOficial = new System.Windows.Forms.PictureBox();
            this.lblMensajeSupenso = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscudoOficial)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.imgEscudoOficial);
            this.materialCard1.Controls.Add(this.lblMensajeSupenso);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(502, 82);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(529, 286);
            this.materialCard1.TabIndex = 0;
            // 
            // imgEscudoOficial
            // 
            this.imgEscudoOficial.Image = ((System.Drawing.Image)(resources.GetObject("imgEscudoOficial.Image")));
            this.imgEscudoOficial.Location = new System.Drawing.Point(237, 94);
            this.imgEscudoOficial.Name = "imgEscudoOficial";
            this.imgEscudoOficial.Size = new System.Drawing.Size(86, 137);
            this.imgEscudoOficial.TabIndex = 1;
            this.imgEscudoOficial.TabStop = false;
            // 
            // lblMensajeSupenso
            // 
            this.lblMensajeSupenso.AutoSize = true;
            this.lblMensajeSupenso.Depth = 0;
            this.lblMensajeSupenso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMensajeSupenso.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblMensajeSupenso.Location = new System.Drawing.Point(90, 56);
            this.lblMensajeSupenso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensajeSupenso.Name = "lblMensajeSupenso";
            this.lblMensajeSupenso.Size = new System.Drawing.Size(353, 19);
            this.lblMensajeSupenso.TabIndex = 0;
            this.lblMensajeSupenso.Text = "Solicitá en la mesa electoral que se asigne tu voto";
            // 
            // FrmPantallaSuspenso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 594);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPantallaSuspenso";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Supenso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEscudoOficial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox imgEscudoOficial;
        private MaterialSkin.Controls.MaterialLabel lblMensajeSupenso;
    }
}