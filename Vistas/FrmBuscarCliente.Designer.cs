namespace Vistas
{
    partial class FrmBuscarCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbObraSocialConsulta = new System.Windows.Forms.ComboBox();
            this.optZ = new System.Windows.Forms.RadioButton();
            this.optA = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMostrar2 = new System.Windows.Forms.Label();
            this.lblMostrar1 = new System.Windows.Forms.Label();
            this.lblCountRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(16, 181);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(880, 357);
            this.dgvClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 64);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(353, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.MintCream;
<<<<<<< HEAD
            this.btnSeleccionar.Location = new System.Drawing.Point(668, 98);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 18, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(187, 37);
=======
            this.btnSeleccionar.Location = new System.Drawing.Point(532, 71);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(140, 34);
>>>>>>> master
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Obra Social:";
            // 
            // cmbObraSocialConsulta
            // 
            this.cmbObraSocialConsulta.FormattingEnabled = true;
            this.cmbObraSocialConsulta.Location = new System.Drawing.Point(336, 127);
            this.cmbObraSocialConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbObraSocialConsulta.Name = "cmbObraSocialConsulta";
            this.cmbObraSocialConsulta.Size = new System.Drawing.Size(221, 24);
            this.cmbObraSocialConsulta.TabIndex = 40;
            this.cmbObraSocialConsulta.SelectionChangeCommitted += new System.EventHandler(this.cmbObraSocialConsulta_SelectionChangeCommitted);
            // 
            // optZ
            // 
            this.optZ.AutoSize = true;
            this.optZ.Location = new System.Drawing.Point(161, 128);
            this.optZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optZ.Name = "optZ";
            this.optZ.Size = new System.Drawing.Size(52, 21);
            this.optZ.TabIndex = 39;
            this.optZ.TabStop = true;
            this.optZ.Text = "Z-A";
            this.optZ.UseVisualStyleBackColor = true;
            this.optZ.CheckedChanged += new System.EventHandler(this.optZ_CheckedChanged);
            // 
            // optA
            // 
            this.optA.AutoSize = true;
            this.optA.Checked = true;
            this.optA.Location = new System.Drawing.Point(97, 128);
            this.optA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optA.Name = "optA";
            this.optA.Size = new System.Drawing.Size(52, 21);
            this.optA.TabIndex = 38;
            this.optA.TabStop = true;
            this.optA.Text = "A-Z";
            this.optA.UseVisualStyleBackColor = true;
            this.optA.CheckedChanged += new System.EventHandler(this.optA_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(179, 82);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(199, 22);
            this.txtBusqueda.TabIndex = 37;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese su búsqueda:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(25, 130);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(65, 17);
            this.lblOrden.TabIndex = 35;
            this.lblOrden.Text = "Ordenar:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Location = new System.Drawing.Point(479, 82);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 26);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(391, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 26);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMostrar2
            // 
            this.lblMostrar2.AutoSize = true;
            this.lblMostrar2.Location = new System.Drawing.Point(819, 542);
            this.lblMostrar2.Margin = new System.Windows.Forms.Padding(0);
            this.lblMostrar2.Name = "lblMostrar2";
            this.lblMostrar2.Size = new System.Drawing.Size(78, 17);
            this.lblMostrar2.TabIndex = 44;
            this.lblMostrar2.Text = "resultados.";
            // 
            // lblMostrar1
            // 
            this.lblMostrar1.AutoSize = true;
            this.lblMostrar1.Location = new System.Drawing.Point(721, 542);
            this.lblMostrar1.Margin = new System.Windows.Forms.Padding(0);
            this.lblMostrar1.Name = "lblMostrar1";
            this.lblMostrar1.Size = new System.Drawing.Size(75, 17);
            this.lblMostrar1.TabIndex = 43;
            this.lblMostrar1.Text = "Mostrando";
            // 
            // lblCountRegistros
            // 
            this.lblCountRegistros.AutoSize = true;
            this.lblCountRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRegistros.Location = new System.Drawing.Point(795, 542);
            this.lblCountRegistros.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountRegistros.Name = "lblCountRegistros";
            this.lblCountRegistros.Size = new System.Drawing.Size(26, 17);
            this.lblCountRegistros.TabIndex = 42;
            this.lblCountRegistros.Text = "00";
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(912, 569);
            this.Controls.Add(this.lblMostrar2);
            this.Controls.Add(this.lblMostrar1);
            this.Controls.Add(this.lblCountRegistros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbObraSocialConsulta);
            this.Controls.Add(this.optZ);
            this.Controls.Add(this.optA);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBuscarCliente";
            this.Text = "FrmBuscarCliente";
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbObraSocialConsulta;
        private System.Windows.Forms.RadioButton optZ;
        private System.Windows.Forms.RadioButton optA;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMostrar2;
        private System.Windows.Forms.Label lblMostrar1;
        private System.Windows.Forms.Label lblCountRegistros;
    }
}