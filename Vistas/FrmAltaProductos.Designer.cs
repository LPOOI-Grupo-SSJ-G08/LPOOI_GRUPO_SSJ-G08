namespace Vistas
{
    partial class FrmAltaProductos
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblValidPrecio = new System.Windows.Forms.Label();
            this.lblValidDescripcion = new System.Windows.Forms.Label();
            this.lblValidCategoria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGestionProductos = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.cmbOrdenarProducto = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(32, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(63, 15);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(50, 199);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(100, 76);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(180, 21);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(100, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 21);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(100, 196);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 21);
            this.txtPrecio.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(37, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(184, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblValidPrecio
            // 
            this.lblValidPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidPrecio.AutoSize = true;
            this.lblValidPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblValidPrecio.Location = new System.Drawing.Point(97, 220);
            this.lblValidPrecio.Name = "lblValidPrecio";
            this.lblValidPrecio.Size = new System.Drawing.Size(142, 13);
            this.lblValidPrecio.TabIndex = 14;
            this.lblValidPrecio.Text = "Proporcione un precio válido";
            this.lblValidPrecio.Visible = false;
            // 
            // lblValidDescripcion
            // 
            this.lblValidDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidDescripcion.AutoSize = true;
            this.lblValidDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblValidDescripcion.Location = new System.Drawing.Point(97, 160);
            this.lblValidDescripcion.Name = "lblValidDescripcion";
            this.lblValidDescripcion.Size = new System.Drawing.Size(142, 13);
            this.lblValidDescripcion.TabIndex = 13;
            this.lblValidDescripcion.Text = "Proporcione una descripción";
            this.lblValidDescripcion.Visible = false;
            // 
            // lblValidCategoria
            // 
            this.lblValidCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidCategoria.AutoSize = true;
            this.lblValidCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblValidCategoria.Location = new System.Drawing.Point(97, 100);
            this.lblValidCategoria.Name = "lblValidCategoria";
            this.lblValidCategoria.Size = new System.Drawing.Size(134, 13);
            this.lblValidCategoria.TabIndex = 12;
            this.lblValidCategoria.Text = "Proporcione una categoría";
            this.lblValidCategoria.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(89, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 20);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Nuevo Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(37, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(184, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblValidPrecio);
            this.panel1.Controls.Add(this.lblValidDescripcion);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.lblValidCategoria);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Location = new System.Drawing.Point(384, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 400);
            this.panel1.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(184, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(96, 20);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.lblGestionProductos);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 56);
            this.panel2.TabIndex = 18;
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblGestionProductos.Location = new System.Drawing.Point(247, 16);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(191, 24);
            this.lblGestionProductos.TabIndex = 1;
            this.lblGestionProductos.Text = "Gestión de Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 228);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(378, 234);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.cmbOrdenarProducto);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.lblConsultas);
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(378, 160);
            this.panel3.TabIndex = 20;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(238, 125);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(130, 25);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultas avanzadas";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(149, 10);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(80, 20);
            this.lblConsultas.TabIndex = 0;
            this.lblConsultas.Text = "Consultas";
            // 
            // cmbOrdenarProducto
            // 
            this.cmbOrdenarProducto.FormattingEnabled = true;
            this.cmbOrdenarProducto.Items.AddRange(new object[] {
            "Ninguno",
            "Categoria",
            "Descripcion"});
            this.cmbOrdenarProducto.Location = new System.Drawing.Point(8, 128);
            this.cmbOrdenarProducto.Name = "cmbOrdenarProducto";
            this.cmbOrdenarProducto.Size = new System.Drawing.Size(164, 21);
            this.cmbOrdenarProducto.TabIndex = 2;
            this.cmbOrdenarProducto.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenarProducto_SelectedIndexChanged);
            // 
            // FrmAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAltaProductos";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.FrmAltaProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValidPrecio;
        private System.Windows.Forms.Label lblValidDescripcion;
        private System.Windows.Forms.Label lblValidCategoria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblGestionProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbOrdenarProducto;
    }
}