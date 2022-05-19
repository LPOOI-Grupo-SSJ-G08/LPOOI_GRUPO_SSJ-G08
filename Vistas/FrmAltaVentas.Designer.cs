﻿namespace Vistas {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtProdCodigo = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.nudProdCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCtlVenta = new System.Windows.Forms.TabControl();
            this.tpgDetalleVenta = new System.Windows.Forms.TabPage();
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tpgAgregarProducto = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tltAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).BeginInit();
            this.tabCtlVenta.SuspendLayout();
            this.tpgDetalleVenta.SuspendLayout();
            this.tpgAgregarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(15, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 15);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(66, 27);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(170, 23);
            this.cmbClientes.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(276, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(50, 230);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(75, 13);
            this.lblCodProducto.TabIndex = 4;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Location = new System.Drawing.Point(49, 273);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(76, 13);
            this.lblProdPrecio.TabIndex = 6;
            this.lblProdPrecio.Text = "Precio Unitario";
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrecio.Location = new System.Drawing.Point(131, 268);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.ReadOnly = true;
            this.txtProdPrecio.Size = new System.Drawing.Size(100, 21);
            this.txtProdPrecio.TabIndex = 7;
            // 
            // lblProdCantidad
            // 
            this.lblProdCantidad.AutoSize = true;
            this.lblProdCantidad.Location = new System.Drawing.Point(277, 230);
            this.lblProdCantidad.Name = "lblProdCantidad";
            this.lblProdCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblProdCantidad.TabIndex = 8;
            this.lblProdCantidad.Text = "Cantidad";
            // 
            // lblProdTotal
            // 
            this.lblProdTotal.AutoSize = true;
            this.lblProdTotal.Location = new System.Drawing.Point(295, 273);
            this.lblProdTotal.Name = "lblProdTotal";
            this.lblProdTotal.Size = new System.Drawing.Size(31, 13);
            this.lblProdTotal.TabIndex = 10;
            this.lblProdTotal.Text = "Total";
            // 
            // txtProdTotal
            // 
            this.txtProdTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTotal.Location = new System.Drawing.Point(332, 268);
            this.txtProdTotal.Name = "txtProdTotal";
            this.txtProdTotal.ReadOnly = true;
            this.txtProdTotal.Size = new System.Drawing.Size(100, 21);
            this.txtProdTotal.TabIndex = 11;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(180, 342);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(120, 28);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "AÑADIR";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosSeleccionados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(13, 120);
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.ReadOnly = true;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(460, 180);
            this.dgvProductosSeleccionados.TabIndex = 13;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.MintCream;
            this.btnGuardarVenta.Location = new System.Drawing.Point(263, 330);
            this.btnGuardarVenta.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(140, 30);
            this.btnGuardarVenta.TabIndex = 14;
            this.btnGuardarVenta.Text = "GUARDAR VENTA";
            this.btnGuardarVenta.UseVisualStyleBackColor = false;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.MintCream;
            this.btnCancelar.Location = new System.Drawing.Point(84, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Location = new System.Drawing.Point(323, 28);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(150, 21);
            this.dtpFechaVenta.TabIndex = 16;
            // 
            // txtProdCodigo
            // 
            this.txtProdCodigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCodigo.Location = new System.Drawing.Point(131, 225);
            this.txtProdCodigo.Name = "txtProdCodigo";
            this.txtProdCodigo.ReadOnly = true;
            this.txtProdCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtProdCodigo.TabIndex = 17;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.Location = new System.Drawing.Point(13, 13);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(460, 170);
            this.dgvProductos.TabIndex = 18;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // nudProdCantidad
            // 
            this.nudProdCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdCantidad.Location = new System.Drawing.Point(332, 226);
            this.nudProdCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProdCantidad.Name = "nudProdCantidad";
            this.nudProdCantidad.Size = new System.Drawing.Size(100, 21);
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
            this.label1.Location = new System.Drawing.Point(47, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // tabCtlVenta
            // 
            this.tabCtlVenta.Controls.Add(this.tpgDetalleVenta);
            this.tabCtlVenta.Controls.Add(this.tpgAgregarProducto);
            this.tabCtlVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCtlVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlVenta.ItemSize = new System.Drawing.Size(100, 22);
            this.tabCtlVenta.Location = new System.Drawing.Point(20, 74);
            this.tabCtlVenta.Multiline = true;
            this.tabCtlVenta.Name = "tabCtlVenta";
            this.tabCtlVenta.Padding = new System.Drawing.Point(20, 3);
            this.tabCtlVenta.SelectedIndex = 0;
            this.tabCtlVenta.Size = new System.Drawing.Size(494, 418);
            this.tabCtlVenta.TabIndex = 22;
            // 
            // tpgDetalleVenta
            // 
            this.tpgDetalleVenta.BackColor = System.Drawing.Color.White;
            this.tpgDetalleVenta.Controls.Add(this.btnAgregarNuevoProducto);
            this.tpgDetalleVenta.Controls.Add(this.lblSubtitle);
            this.tpgDetalleVenta.Controls.Add(this.dgvProductosSeleccionados);
            this.tpgDetalleVenta.Controls.Add(this.btnCancelar);
            this.tpgDetalleVenta.Controls.Add(this.dtpFechaVenta);
            this.tpgDetalleVenta.Controls.Add(this.lblFecha);
            this.tpgDetalleVenta.Controls.Add(this.btnGuardarVenta);
            this.tpgDetalleVenta.Controls.Add(this.cmbClientes);
            this.tpgDetalleVenta.Controls.Add(this.lblCliente);
            this.tpgDetalleVenta.Location = new System.Drawing.Point(4, 26);
            this.tpgDetalleVenta.Name = "tpgDetalleVenta";
            this.tpgDetalleVenta.Padding = new System.Windows.Forms.Padding(10);
            this.tpgDetalleVenta.Size = new System.Drawing.Size(486, 388);
            this.tpgDetalleVenta.TabIndex = 0;
            this.tpgDetalleVenta.Text = "Detalles";
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarNuevoProducto.BackgroundImage = global::Vistas.Properties.Resources.plus;
            this.btnAgregarNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(451, 86);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(22, 22);
            this.btnAgregarNuevoProducto.TabIndex = 17;
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoProducto.Click += new System.EventHandler(this.btnAgregarNuevoProducto_Click);
            this.btnAgregarNuevoProducto.MouseHover += new System.EventHandler(this.btnAgregarNuevoProducto_MouseHover);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(147, 86);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(184, 16);
            this.lblSubtitle.TabIndex = 16;
            this.lblSubtitle.Text = "Productos seleccionados";
            // 
            // tpgAgregarProducto
            // 
            this.tpgAgregarProducto.BackColor = System.Drawing.Color.White;
            this.tpgAgregarProducto.Controls.Add(this.dgvProductos);
            this.tpgAgregarProducto.Controls.Add(this.txtProdCodigo);
            this.tpgAgregarProducto.Controls.Add(this.lblCodProducto);
            this.tpgAgregarProducto.Controls.Add(this.nudProdCantidad);
            this.tpgAgregarProducto.Controls.Add(this.lblProdPrecio);
            this.tpgAgregarProducto.Controls.Add(this.txtProdPrecio);
            this.tpgAgregarProducto.Controls.Add(this.lblProdCantidad);
            this.tpgAgregarProducto.Controls.Add(this.lblProdTotal);
            this.tpgAgregarProducto.Controls.Add(this.txtProdTotal);
            this.tpgAgregarProducto.Controls.Add(this.btnAgregarDetalle);
            this.tpgAgregarProducto.Location = new System.Drawing.Point(4, 26);
            this.tpgAgregarProducto.Name = "tpgAgregarProducto";
            this.tpgAgregarProducto.Padding = new System.Windows.Forms.Padding(10);
            this.tpgAgregarProducto.Size = new System.Drawing.Size(486, 388);
            this.tpgAgregarProducto.TabIndex = 1;
            this.tpgAgregarProducto.Text = "Agregar producto";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(210, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 20);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Nueva Venta";
            // 
            // FrmAltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 512);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabCtlVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaVentas";
            this.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.Text = "FrmAltaVentas";
            this.Load += new System.EventHandler(this.FrmAltaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).EndInit();
            this.tabCtlVenta.ResumeLayout(false);
            this.tpgDetalleVenta.ResumeLayout(false);
            this.tpgDetalleVenta.PerformLayout();
            this.tpgAgregarProducto.ResumeLayout(false);
            this.tpgAgregarProducto.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.TextBox txtProdCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.NumericUpDown nudProdCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabCtlVenta;
        private System.Windows.Forms.TabPage tpgDetalleVenta;
        private System.Windows.Forms.TabPage tpgAgregarProducto;
        private System.Windows.Forms.Button btnAgregarNuevoProducto;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip tltAgregarProducto;
    }
}