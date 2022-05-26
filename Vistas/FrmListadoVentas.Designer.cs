namespace Vistas
{
    partial class FrmListadoVentas
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnListarVentasPorCliente = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(685, 52);
            this.pnlEncabezado.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(263, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listado de Ventas";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(0, 58);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(479, 404);
            this.dgvVentas.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListarVentasPorCliente);
            this.panel1.Controls.Add(this.cmbClientes);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(485, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 404);
            this.panel1.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(15, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(97, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Seleccione cliente:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(18, 50);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(150, 21);
            this.cmbClientes.TabIndex = 1;
            // 
            // btnListarVentasPorCliente
            // 
            this.btnListarVentasPorCliente.Location = new System.Drawing.Point(18, 87);
            this.btnListarVentasPorCliente.Name = "btnListarVentasPorCliente";
            this.btnListarVentasPorCliente.Size = new System.Drawing.Size(150, 23);
            this.btnListarVentasPorCliente.TabIndex = 2;
            this.btnListarVentasPorCliente.Text = "Listar ventas por cliente";
            this.btnListarVentasPorCliente.UseVisualStyleBackColor = true;
            this.btnListarVentasPorCliente.Click += new System.EventHandler(this.btnListarVentasPorCliente_Click);
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEncabezado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListadoVentas";
            this.Text = "FrmListadoVentas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarVentasPorCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblCliente;
    }
}