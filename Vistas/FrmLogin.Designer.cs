namespace Vistas
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRecuperarPsw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(150, 277);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(150, 46);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_MouseHover);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AllowDrop = true;
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(140, 83);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(224, 31);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowDrop = true;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(140, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // imgPassword
            // 
            this.imgPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgPassword.BackColor = System.Drawing.Color.Transparent;
            this.imgPassword.Image = global::Vistas.Properties.Resources.password;
            this.imgPassword.Location = new System.Drawing.Point(86, 166);
            this.imgPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(45, 46);
            this.imgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPassword.TabIndex = 6;
            this.imgPassword.TabStop = false;
            // 
            // imgUsuario
            // 
            this.imgUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgUsuario.BackColor = System.Drawing.Color.Transparent;
            this.imgUsuario.Image = global::Vistas.Properties.Resources.user;
            this.imgUsuario.Location = new System.Drawing.Point(86, 72);
            this.imgUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(45, 46);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 5;
            this.imgUsuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblRecuperarPsw);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.imgPassword);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.imgUsuario);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(138, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 385);
            this.panel1.TabIndex = 7;
            // 
            // lblRecuperarPsw
            // 
            this.lblRecuperarPsw.AutoSize = true;
            this.lblRecuperarPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarPsw.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRecuperarPsw.Location = new System.Drawing.Point(63, 235);
            this.lblRecuperarPsw.Name = "lblRecuperarPsw";
            this.lblRecuperarPsw.Size = new System.Drawing.Size(325, 25);
            this.lblRecuperarPsw.TabIndex = 7;
            this.lblRecuperarPsw.Text = "¿Olvidaste tu usuario o contraseña?";
            this.lblRecuperarPsw.Click += new System.EventHandler(this.lblRecuperarPsw_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(726, 557);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox imgPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecuperarPsw;
    }
}

