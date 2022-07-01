namespace Vistas
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(169, 318);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(366, 46);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido Usuario";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(163, 380);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(378, 31);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Se ha logueado con el rol de ..";
            // 
            // imgUsuario
            // 
            this.imgUsuario.Location = new System.Drawing.Point(276, 51);
            this.imgUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(155, 159);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUsuario.TabIndex = 3;
            this.imgUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPerfil.Image")));
            this.btnEditarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPerfil.Location = new System.Drawing.Point(303, 251);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnEditarPerfil.Size = new System.Drawing.Size(100, 30);
            this.btnEditarPerfil.TabIndex = 5;
            this.btnEditarPerfil.Text = "Editar perfil";
            this.btnEditarPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 428);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.imgUsuario);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBienvenida;
        public System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditarPerfil;
    }
}