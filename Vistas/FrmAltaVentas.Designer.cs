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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClienteDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.tpgAgregarProducto = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarFiltrosBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tltAgregarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tltBuscarProducto = new System.Windows.Forms.ToolTip(this.components);
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).BeginInit();
            this.tabCtlVenta.SuspendLayout();
            this.tpgDetalleVenta.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpgAgregarProducto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCodProducto
            // 
            this.lblCodProducto.AutoSize = true;
            this.lblCodProducto.Location = new System.Drawing.Point(29, 98);
            this.lblCodProducto.Name = "lblCodProducto";
            this.lblCodProducto.Size = new System.Drawing.Size(75, 13);
            this.lblCodProducto.TabIndex = 4;
            this.lblCodProducto.Text = "Cod. Producto";
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Location = new System.Drawing.Point(28, 143);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(76, 13);
            this.lblProdPrecio.TabIndex = 6;
            this.lblProdPrecio.Text = "Precio Unitario";
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtProdPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrecio.Location = new System.Drawing.Point(110, 138);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.ReadOnly = true;
            this.txtProdPrecio.Size = new System.Drawing.Size(100, 21);
            this.txtProdPrecio.TabIndex = 7;
            // 
            // lblProdCantidad
            // 
            this.lblProdCantidad.AutoSize = true;
            this.lblProdCantidad.Location = new System.Drawing.Point(55, 187);
            this.lblProdCantidad.Name = "lblProdCantidad";
            this.lblProdCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblProdCantidad.TabIndex = 8;
            this.lblProdCantidad.Text = "Cantidad";
            // 
            // lblProdTotal
            // 
            this.lblProdTotal.AutoSize = true;
            this.lblProdTotal.Location = new System.Drawing.Point(73, 233);
            this.lblProdTotal.Name = "lblProdTotal";
            this.lblProdTotal.Size = new System.Drawing.Size(31, 13);
            this.lblProdTotal.TabIndex = 10;
            this.lblProdTotal.Text = "Total";
            // 
            // txtProdTotal
            // 
            this.txtProdTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtProdTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTotal.Location = new System.Drawing.Point(110, 228);
            this.txtProdTotal.Name = "txtProdTotal";
            this.txtProdTotal.ReadOnly = true;
            this.txtProdTotal.Size = new System.Drawing.Size(100, 21);
            this.txtProdTotal.TabIndex = 11;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnAgregarDetalle.FlatAppearance.BorderSize = 0;
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(59, 305);
            this.btnAgregarDetalle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(120, 28);
            this.btnAgregarDetalle.TabIndex = 12;
            this.btnAgregarDetalle.Text = "AÑADIR";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            this.btnAgregarDetalle.MouseLeave += new System.EventHandler(this.btnAgregarDetalle_MouseLeave);
            this.btnAgregarDetalle.MouseHover += new System.EventHandler(this.btnAgregarDetalle_MouseHover);
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosSeleccionados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(10, 49);
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.ReadOnly = true;
            this.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(448, 244);
            this.dgvProductosSeleccionados.TabIndex = 13;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.btnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarVenta.ForeColor = System.Drawing.Color.MintCream;
            this.btnGuardarVenta.Location = new System.Drawing.Point(385, 327);
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
            this.btnCancelar.Location = new System.Drawing.Point(211, 327);
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
            this.dtpFechaVenta.Location = new System.Drawing.Point(70, 35);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(150, 21);
            this.dtpFechaVenta.TabIndex = 16;
            // 
            // txtProdCodigo
            // 
            this.txtProdCodigo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtProdCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdCodigo.Location = new System.Drawing.Point(110, 93);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.Location = new System.Drawing.Point(13, 68);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(10);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(460, 287);
            this.dgvProductos.TabIndex = 18;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // nudProdCantidad
            // 
            this.nudProdCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudProdCantidad.Location = new System.Drawing.Point(110, 183);
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
            // tabCtlVenta
            // 
            this.tabCtlVenta.Controls.Add(this.tpgDetalleVenta);
            this.tabCtlVenta.Controls.Add(this.tpgAgregarProducto);
            this.tabCtlVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCtlVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtlVenta.ItemSize = new System.Drawing.Size(100, 22);
            this.tabCtlVenta.Location = new System.Drawing.Point(0, 96);
            this.tabCtlVenta.Multiline = true;
            this.tabCtlVenta.Name = "tabCtlVenta";
            this.tabCtlVenta.Padding = new System.Drawing.Point(20, 3);
            this.tabCtlVenta.SelectedIndex = 0;
            this.tabCtlVenta.Size = new System.Drawing.Size(745, 400);
            this.tabCtlVenta.TabIndex = 22;
            // 
            // tpgDetalleVenta
            // 
            this.tpgDetalleVenta.BackColor = System.Drawing.Color.White;
            this.tpgDetalleVenta.Controls.Add(this.btnGuardarVenta);
            this.tpgDetalleVenta.Controls.Add(this.btnCancelar);
            this.tpgDetalleVenta.Controls.Add(this.panel4);
            this.tpgDetalleVenta.Controls.Add(this.panel3);
            this.tpgDetalleVenta.Location = new System.Drawing.Point(4, 26);
            this.tpgDetalleVenta.Name = "tpgDetalleVenta";
            this.tpgDetalleVenta.Padding = new System.Windows.Forms.Padding(10);
            this.tpgDetalleVenta.Size = new System.Drawing.Size(737, 370);
            this.tpgDetalleVenta.TabIndex = 0;
            this.tpgDetalleVenta.Text = "Detalles";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSubtitle);
            this.panel4.Controls.Add(this.btnAgregarNuevoProducto);
            this.panel4.Controls.Add(this.dgvProductosSeleccionados);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 306);
            this.panel4.TabIndex = 20;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(143, 15);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(184, 16);
            this.lblSubtitle.TabIndex = 16;
            this.lblSubtitle.Text = "Productos seleccionados";
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregarNuevoProducto.BackgroundImage = global::Vistas.Properties.Resources.plus;
            this.btnAgregarNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(436, 15);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(22, 22);
            this.btnAgregarNuevoProducto.TabIndex = 17;
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = false;
            this.btnAgregarNuevoProducto.Click += new System.EventHandler(this.btnAgregarNuevoProducto_Click);
            this.btnAgregarNuevoProducto.MouseHover += new System.EventHandler(this.btnAgregarNuevoProducto_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dtpFechaVenta);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Location = new System.Drawing.Point(479, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 306);
            this.panel3.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtClienteNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtClienteDNI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClienteApellido);
            this.groupBox1.Location = new System.Drawing.Point(9, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 211);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.MintCream;
            this.btnBuscar.Image = global::Vistas.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(43, 166);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBuscar.Size = new System.Drawing.Size(150, 30);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Seleccionar cliente";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(70, 118);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(150, 20);
            this.txtClienteNombre.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Apellido:";
            // 
            // txtClienteDNI
            // 
            this.txtClienteDNI.Location = new System.Drawing.Point(70, 30);
            this.txtClienteDNI.Name = "txtClienteDNI";
            this.txtClienteDNI.Size = new System.Drawing.Size(150, 20);
            this.txtClienteDNI.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "DNI:";
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(70, 74);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(150, 20);
            this.txtClienteApellido.TabIndex = 20;
            // 
            // tpgAgregarProducto
            // 
            this.tpgAgregarProducto.BackColor = System.Drawing.Color.White;
            this.tpgAgregarProducto.Controls.Add(this.panel2);
            this.tpgAgregarProducto.Controls.Add(this.pictureBox1);
            this.tpgAgregarProducto.Controls.Add(this.btnLimpiarFiltrosBuscar);
            this.tpgAgregarProducto.Controls.Add(this.label3);
            this.tpgAgregarProducto.Controls.Add(this.btnBuscarProducto);
            this.tpgAgregarProducto.Controls.Add(this.txtBusquedaProducto);
            this.tpgAgregarProducto.Controls.Add(this.dgvProductos);
            this.tpgAgregarProducto.Location = new System.Drawing.Point(4, 26);
            this.tpgAgregarProducto.Name = "tpgAgregarProducto";
            this.tpgAgregarProducto.Padding = new System.Windows.Forms.Padding(10);
            this.tpgAgregarProducto.Size = new System.Drawing.Size(737, 370);
            this.tpgAgregarProducto.TabIndex = 1;
            this.tpgAgregarProducto.Text = "Agregar producto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblConsultas);
            this.panel2.Controls.Add(this.txtProdCodigo);
            this.panel2.Controls.Add(this.txtProdTotal);
            this.panel2.Controls.Add(this.lblProdTotal);
            this.panel2.Controls.Add(this.lblProdCantidad);
            this.panel2.Controls.Add(this.txtProdPrecio);
            this.panel2.Controls.Add(this.lblProdPrecio);
            this.panel2.Controls.Add(this.nudProdCantidad);
            this.panel2.Controls.Add(this.btnAgregarDetalle);
            this.panel2.Controls.Add(this.lblCodProducto);
            this.panel2.Location = new System.Drawing.Point(479, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 352);
            this.panel2.TabIndex = 26;
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(83, 32);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(73, 20);
            this.lblConsultas.TabIndex = 20;
            this.lblConsultas.Text = "Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(312, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.tltBuscarProducto.SetToolTip(this.pictureBox1, "Puede buscar por Categoría o Nombre del Producto.");
            // 
            // btnLimpiarFiltrosBuscar
            // 
            this.btnLimpiarFiltrosBuscar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiarFiltrosBuscar.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltrosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltrosBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiarFiltrosBuscar.Location = new System.Drawing.Point(413, 32);
            this.btnLimpiarFiltrosBuscar.Name = "btnLimpiarFiltrosBuscar";
            this.btnLimpiarFiltrosBuscar.Size = new System.Drawing.Size(60, 23);
            this.btnLimpiarFiltrosBuscar.TabIndex = 24;
            this.btnLimpiarFiltrosBuscar.Text = "Limpiar";
            this.btnLimpiarFiltrosBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltrosBuscar.Click += new System.EventHandler(this.btnLimpiarFiltrosBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ingrese su búsqueda";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarProducto.Location = new System.Drawing.Point(347, 32);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarProducto.TabIndex = 21;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Location = new System.Drawing.Point(126, 32);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(180, 20);
            this.txtBusquedaProducto.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(299, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 24);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Realizar Venta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 56);
            this.panel1.TabIndex = 24;
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnConsultarVentas.FlatAppearance.BorderSize = 0;
            this.btnConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarVentas.Location = new System.Drawing.Point(592, 72);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(130, 30);
            this.btnConsultarVentas.TabIndex = 24;
            this.btnConsultarVentas.Text = "Consultar Ventas";
            this.btnConsultarVentas.UseVisualStyleBackColor = false;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // FrmAltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 496);
            this.Controls.Add(this.btnConsultarVentas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCtlVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaVentas";
            this.Text = "FrmAltaVentas";
            this.Load += new System.EventHandler(this.FrmAltaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdCantidad)).EndInit();
            this.tabCtlVenta.ResumeLayout(false);
            this.tpgDetalleVenta.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpgAgregarProducto.ResumeLayout(false);
            this.tpgAgregarProducto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.ToolTip tltBuscarProducto;
        private System.Windows.Forms.Button btnLimpiarFiltrosBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox txtClienteNombre;
        internal System.Windows.Forms.TextBox txtClienteApellido;
        internal System.Windows.Forms.TextBox txtClienteDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Button btnConsultarVentas;
    }
}