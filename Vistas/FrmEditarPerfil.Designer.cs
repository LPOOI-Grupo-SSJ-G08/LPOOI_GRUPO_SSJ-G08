namespace Vistas
{
    partial class FrmEditarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarPerfil));
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImgUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValidUsername = new System.Windows.Forms.Label();
            this.lblValidPassword = new System.Windows.Forms.Label();
            this.lblValidNombre = new System.Windows.Forms.Label();
            this.btnCambiarImagen = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(98, 96);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(98, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 21);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(98, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(98, 208);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(98, 268);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(119, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(98, 294);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 21);
            this.txtNombre.TabIndex = 6;
            // 
            // lblImgUsuario
            // 
            this.lblImgUsuario.AutoSize = true;
            this.lblImgUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgUsuario.Location = new System.Drawing.Point(384, 96);
            this.lblImgUsuario.Name = "lblImgUsuario";
            this.lblImgUsuario.Size = new System.Drawing.Size(91, 17);
            this.lblImgUsuario.TabIndex = 7;
            this.lblImgUsuario.Text = "Foto de perfil";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(97, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 26);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Tu perfil";
            // 
            // lblValidUsername
            // 
            this.lblValidUsername.AutoSize = true;
            this.lblValidUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblValidUsername.Location = new System.Drawing.Point(99, 145);
            this.lblValidUsername.Name = "lblValidUsername";
            this.lblValidUsername.Size = new System.Drawing.Size(160, 13);
            this.lblValidUsername.TabIndex = 10;
            this.lblValidUsername.Text = "Debe contener al menos 3 letras";
            // 
            // lblValidPassword
            // 
            this.lblValidPassword.AutoSize = true;
            this.lblValidPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblValidPassword.Location = new System.Drawing.Point(99, 231);
            this.lblValidPassword.Name = "lblValidPassword";
            this.lblValidPassword.Size = new System.Drawing.Size(160, 13);
            this.lblValidPassword.TabIndex = 11;
            this.lblValidPassword.Text = "Debe contener al menos 3 letras";
            // 
            // lblValidNombre
            // 
            this.lblValidNombre.AutoSize = true;
            this.lblValidNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblValidNombre.Location = new System.Drawing.Point(99, 317);
            this.lblValidNombre.Name = "lblValidNombre";
            this.lblValidNombre.Size = new System.Drawing.Size(160, 13);
            this.lblValidNombre.TabIndex = 12;
            this.lblValidNombre.Text = "Debe contener al menos 3 letras";
            // 
            // btnCambiarImagen
            // 
            this.btnCambiarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnCambiarImagen.FlatAppearance.BorderSize = 0;
            this.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagen.Location = new System.Drawing.Point(401, 231);
            this.btnCambiarImagen.Name = "btnCambiarImagen";
            this.btnCambiarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarImagen.TabIndex = 13;
            this.btnCambiarImagen.Text = "Cambiar";
            this.btnCambiarImagen.UseVisualStyleBackColor = false;
            this.btnCambiarImagen.Click += new System.EventHandler(this.btnCambiarImagen_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::Vistas.Properties.Resources._16check_icon;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(387, 284);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // imgUsuario
            // 
            this.imgUsuario.Location = new System.Drawing.Point(387, 122);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(100, 100);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            this.imgUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.imgUsuario_Paint);
            // 
            // FrmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.btnCambiarImagen);
            this.Controls.Add(this.lblValidNombre);
            this.Controls.Add(this.lblValidPassword);
            this.Controls.Add(this.lblValidUsername);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblImgUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.imgUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.FrmEditarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblImgUsuario;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValidUsername;
        private System.Windows.Forms.Label lblValidPassword;
        private System.Windows.Forms.Label lblValidNombre;
        private System.Windows.Forms.Button btnCambiarImagen;
    }
}