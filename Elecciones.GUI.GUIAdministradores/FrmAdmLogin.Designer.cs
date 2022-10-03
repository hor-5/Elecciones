namespace Elecciones.GUI.GUIAdministradores
{
    partial class FrmAdmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmLogin));
            this.cardLogueo = new MaterialSkin.Controls.MaterialCard();
            this.btnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.lblClave = new MaterialSkin.Controls.MaterialLabel();
            this.txtClave = new MaterialSkin.Controls.MaterialTextBox();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.cardLogueo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardLogueo
            // 
            this.cardLogueo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardLogueo.Controls.Add(this.btnIngresar);
            this.cardLogueo.Controls.Add(this.lblClave);
            this.cardLogueo.Controls.Add(this.txtClave);
            this.cardLogueo.Controls.Add(this.lblUsuario);
            this.cardLogueo.Controls.Add(this.txtUsuario);
            this.cardLogueo.Depth = 0;
            this.cardLogueo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardLogueo.Location = new System.Drawing.Point(473, 188);
            this.cardLogueo.Margin = new System.Windows.Forms.Padding(14);
            this.cardLogueo.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardLogueo.Name = "cardLogueo";
            this.cardLogueo.Padding = new System.Windows.Forms.Padding(14);
            this.cardLogueo.Size = new System.Drawing.Size(340, 265);
            this.cardLogueo.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.HighEmphasis = true;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(127, 200);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngresar.Size = new System.Drawing.Size(91, 36);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnIngresar.UseAccentColor = true;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Depth = 0;
            this.lblClave.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblClave.Location = new System.Drawing.Point(46, 115);
            this.lblClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(80, 19);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "contraseña";
            // 
            // txtClave
            // 
            this.txtClave.AnimateReadOnly = false;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Depth = 0;
            this.txtClave.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClave.Hint = "Ingrese su contraseña";
            this.txtClave.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtClave.LeadingIcon")));
            this.txtClave.Location = new System.Drawing.Point(46, 137);
            this.txtClave.MaxLength = 50;
            this.txtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClave.Multiline = false;
            this.txtClave.Name = "txtClave";
            this.txtClave.Password = true;
            this.txtClave.Size = new System.Drawing.Size(249, 36);
            this.txtClave.TabIndex = 2;
            this.txtClave.Text = "";
            this.txtClave.TrailingIcon = null;
            this.txtClave.UseTallSize = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsuario.Location = new System.Drawing.Point(46, 39);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.Hint = "Ingrese su usuario";
            this.txtUsuario.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtUsuario.LeadingIcon")));
            this.txtUsuario.Location = new System.Drawing.Point(46, 61);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(249, 36);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseTallSize = false;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // FrmAdmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cardLogueo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.cardLogueo.ResumeLayout(false);
            this.cardLogueo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardLogueo;
        private MaterialSkin.Controls.MaterialButton btnIngresar;
        private MaterialSkin.Controls.MaterialLabel lblClave;
        private MaterialSkin.Controls.MaterialTextBox txtClave;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
    }
}