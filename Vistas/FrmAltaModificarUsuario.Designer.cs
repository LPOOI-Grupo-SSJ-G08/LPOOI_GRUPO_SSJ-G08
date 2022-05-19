namespace Vistas
{
    partial class FrmAltaModificarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombreompleto = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.lblValidUsuario = new System.Windows.Forms.Label();
            this.lblValidContrasenia = new System.Windows.Forms.Label();
            this.lblValidNombreCompleto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(153, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(202, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(153, 104);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(202, 20);
            this.txtContrasenia.TabIndex = 5;
            // 
            // txtNombreompleto
            // 
            this.txtNombreompleto.Location = new System.Drawing.Point(153, 154);
            this.txtNombreompleto.Name = "txtNombreompleto";
            this.txtNombreompleto.Size = new System.Drawing.Size(202, 20);
            this.txtNombreompleto.TabIndex = 6;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Auditor",
            "Operador"});
            this.cmbRol.Location = new System.Drawing.Point(153, 213);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(202, 21);
            this.cmbRol.TabIndex = 7;
            this.cmbRol.Text = "Operador";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(237, 305);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(60, 305);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(118, 39);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Location = new System.Drawing.Point(389, 49);
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.Size = new System.Drawing.Size(429, 229);
            this.dgvListaUsuarios.TabIndex = 10;
            // 
            // lblValidUsuario
            // 
            this.lblValidUsuario.AutoSize = true;
            this.lblValidUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblValidUsuario.Location = new System.Drawing.Point(150, 70);
            this.lblValidUsuario.Name = "lblValidUsuario";
            this.lblValidUsuario.Size = new System.Drawing.Size(160, 13);
            this.lblValidUsuario.TabIndex = 16;
            this.lblValidUsuario.Text = "Debe contener al menos 3 letras";
            this.lblValidUsuario.Visible = false;
            // 
            // lblValidContrasenia
            // 
            this.lblValidContrasenia.AutoSize = true;
            this.lblValidContrasenia.ForeColor = System.Drawing.Color.Red;
            this.lblValidContrasenia.Location = new System.Drawing.Point(150, 127);
            this.lblValidContrasenia.Name = "lblValidContrasenia";
            this.lblValidContrasenia.Size = new System.Drawing.Size(160, 13);
            this.lblValidContrasenia.TabIndex = 17;
            this.lblValidContrasenia.Text = "Debe contener al menos 3 letras";
            this.lblValidContrasenia.Visible = false;
            // 
            // lblValidNombreCompleto
            // 
            this.lblValidNombreCompleto.AutoSize = true;
            this.lblValidNombreCompleto.ForeColor = System.Drawing.Color.Red;
            this.lblValidNombreCompleto.Location = new System.Drawing.Point(150, 177);
            this.lblValidNombreCompleto.Name = "lblValidNombreCompleto";
            this.lblValidNombreCompleto.Size = new System.Drawing.Size(160, 13);
            this.lblValidNombreCompleto.TabIndex = 18;
            this.lblValidNombreCompleto.Text = "Debe contener al menos 3 letras";
            this.lblValidNombreCompleto.Visible = false;
            // 
            // FrmAltaModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 396);
            this.Controls.Add(this.lblValidNombreCompleto);
            this.Controls.Add(this.lblValidContrasenia);
            this.Controls.Add(this.lblValidUsuario);
            this.Controls.Add(this.dgvListaUsuarios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtNombreompleto);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaModificarUsuario";
            this.Text = "FrmAltaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombreompleto;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.Label lblValidUsuario;
        private System.Windows.Forms.Label lblValidContrasenia;
        private System.Windows.Forms.Label lblValidNombreCompleto;
    }
}