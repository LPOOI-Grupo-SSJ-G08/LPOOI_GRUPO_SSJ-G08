namespace Vistas {
    partial class FrmAltaVentas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodProducto = new System.Windows.Forms.Label();
            this.lblProdPrecio = new System.Windows.Forms.Label();
            this.txtProdPrecio = new System.Windows.Forms.TextBox();
            this.lblProdCantidad = new System.Windows.Forms.Label();
            this.lblProdTotal = new System.Windows.Forms.Label();
            this.txtProdTotal = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.dgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.brnGuardarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtProdCodigo = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.nudProdCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(58, 23);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(103, 20);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(150, 23);
            this.cmbClientes.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(317, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(42, 285);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(75, 13);
            this.lblCodProducto.TabIndex = 4;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Location = new System.Drawing.Point(41, 328);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(76, 13);
            this.lblProdPrecio.TabIndex = 6;
            this.lblProdPrecio.Text = "Precio Unitario";
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrecio.Location = new System.Drawing.Point(123, 323);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.ReadOnly = true;
            this.txtProdPrecio.Size = new System.Drawing.Size(130, 21);
            this.txtProdPrecio.TabIndex = 7;
            // 
            // lblProdCantidad
            // 
            this.lblProdCantidad.AutoSize = true;
            this.lblProdCantidad.Location = new System.Drawing.Point(338, 282);
            this.lblProdCantidad.Name = "lblProdCantidad";
            this.lblProdCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblProdCantidad.TabIndex = 8;
            this.lblProdCantidad.Text = "Cantidad";
            // 
            // lblProdTotal
            // 
            this.lblProdTotal.AutoSize = true;
            this.lblProdTotal.Location = new System.Drawing.Point(356, 323);
            this.lblProdTotal.Name = "lblProdTotal";
            this.lblProdTotal.Size = new System.Drawing.Size(31, 13);
            this.lblProdTotal.TabIndex = 10;
            this.lblProdTotal.Text = "Total";
            // 
            // txtProdTotal
            // 
            this.txtProdTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTotal.Location = new System.Drawing.Point(393, 320);
            this.txtProdTotal.Name = "txtProdTotal";
            this.txtProdTotal.ReadOnly = true;
            this.txtProdTotal.Size = new System.Drawing.Size(130, 21);
            this.txtProdTotal.TabIndex = 11;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(252, 367);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.AllowUserToAddRows = false;
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(68, 413);
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.ReadOnly = true;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(451, 97);
            this.dgvProductosSeleccionados.TabIndex = 13;
            // 
            // brnGuardarVenta
            // 
            this.brnGuardarVenta.Location = new System.Drawing.Point(341, 527);
            this.brnGuardarVenta.Name = "brnGuardarVenta";
            this.brnGuardarVenta.Size = new System.Drawing.Size(75, 23);
            this.brnGuardarVenta.TabIndex = 14;
            this.brnGuardarVenta.Text = "GUARDAR";
            this.brnGuardarVenta.UseVisualStyleBackColor = true;
            this.brnGuardarVenta.Click += new System.EventHandler(this.brnGuardarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 527);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(369, 23);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(150, 21);
            this.dtpFechaVenta.TabIndex = 16;
            // 
            // txtProdCodigo
            // 
            this.txtProdCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCodigo.Location = new System.Drawing.Point(123, 280);
            this.txtProdCodigo.Name = "txtProdCodigo";
            this.txtProdCodigo.ReadOnly = true;
            this.txtProdCodigo.Size = new System.Drawing.Size(130, 21);
            this.txtProdCodigo.TabIndex = 17;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(54, 120);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(479, 135);
            this.dgvProductos.TabIndex = 18;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // nudProdCantidad
            // 
            this.nudProdCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdCantidad.Location = new System.Drawing.Point(393, 278);
            this.nudProdCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProdCantidad.Name = "nudProdCantidad";
            this.nudProdCantidad.Size = new System.Drawing.Size(130, 21);
            this.nudProdCantidad.TabIndex = 19;
            this.nudProdCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProdCantidad.ValueChanged += new System.EventHandler(this.nudProdCantidad_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // FrmAltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudProdCantidad);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtProdCodigo);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.brnGuardarVenta);
            this.Controls.Add(this.dgvProductosSeleccionados);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.txtProdTotal);
            this.Controls.Add(this.lblProdTotal);
            this.Controls.Add(this.lblProdCantidad);
            this.Controls.Add(this.txtProdPrecio);
            this.Controls.Add(this.lblProdPrecio);
            this.Controls.Add(this.lblCodProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmAltaVentas";
            this.Text = "FrmAltaVentas";
            this.Load += new System.EventHandler(this.FrmAltaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodProducto;
        private System.Windows.Forms.Label lblProdPrecio;
        private System.Windows.Forms.TextBox txtProdPrecio;
        private System.Windows.Forms.Label lblProdCantidad;
        private System.Windows.Forms.Label lblProdTotal;
        private System.Windows.Forms.TextBox txtProdTotal;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.DataGridView dgvProductosSeleccionados;
        private System.Windows.Forms.Button brnGuardarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtProdCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.NumericUpDown nudProdCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}