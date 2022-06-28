namespace Vistas
{
    partial class FrmGestionProductos
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
            this.optDescripcion = new System.Windows.Forms.RadioButton();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.optNinguno = new System.Windows.Forms.RadioButton();
            this.lblOrden = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultas = new System.Windows.Forms.Label();
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
            this.lblCategoria.Location = new System.Drawing.Point(48, 122);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 22);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 214);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(109, 22);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(75, 306);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(66, 22);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(150, 117);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(268, 28);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(150, 209);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 28);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(150, 302);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(268, 28);
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
            this.btnAgregar.Location = new System.Drawing.Point(56, 458);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 46);
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
            this.btnCancelar.Location = new System.Drawing.Point(276, 458);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
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
            this.lblValidPrecio.Location = new System.Drawing.Point(146, 338);
            this.lblValidPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidPrecio.Name = "lblValidPrecio";
            this.lblValidPrecio.Size = new System.Drawing.Size(207, 20);
            this.lblValidPrecio.TabIndex = 14;
            this.lblValidPrecio.Text = "Proporcione un precio válido";
            this.lblValidPrecio.Visible = false;
            // 
            // lblValidDescripcion
            // 
            this.lblValidDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidDescripcion.AutoSize = true;
            this.lblValidDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblValidDescripcion.Location = new System.Drawing.Point(146, 246);
            this.lblValidDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidDescripcion.Name = "lblValidDescripcion";
            this.lblValidDescripcion.Size = new System.Drawing.Size(209, 20);
            this.lblValidDescripcion.TabIndex = 13;
            this.lblValidDescripcion.Text = "Proporcione una descripción";
            this.lblValidDescripcion.Visible = false;
            // 
            // lblValidCategoria
            // 
            this.lblValidCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidCategoria.AutoSize = true;
            this.lblValidCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblValidCategoria.Location = new System.Drawing.Point(146, 154);
            this.lblValidCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidCategoria.Name = "lblValidCategoria";
            this.lblValidCategoria.Size = new System.Drawing.Size(195, 20);
            this.lblValidCategoria.TabIndex = 12;
            this.lblValidCategoria.Text = "Proporcione una categoría";
            this.lblValidCategoria.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(134, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 29);
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
            this.btnGuardar.Location = new System.Drawing.Point(56, 535);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 46);
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
            this.btnEliminar.Location = new System.Drawing.Point(276, 535);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 46);
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
            this.panel1.Location = new System.Drawing.Point(651, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 615);
            this.panel1.TabIndex = 17;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(276, 77);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(142, 26);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.lblGestionProductos);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 86);
            this.panel2.TabIndex = 18;
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.lblGestionProductos.Location = new System.Drawing.Point(408, 25);
            this.lblGestionProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(288, 32);
            this.lblGestionProductos.TabIndex = 1;
            this.lblGestionProductos.Text = "Gestión de Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 320);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(642, 391);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.optDescripcion);
            this.panel3.Controls.Add(this.optCategoria);
            this.panel3.Controls.Add(this.optNinguno);
            this.panel3.Controls.Add(this.lblOrden);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.lblConsultas);
            this.panel3.Location = new System.Drawing.Point(0, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel3.Size = new System.Drawing.Size(642, 215);
            this.panel3.TabIndex = 20;
            // 
            // optDescripcion
            // 
            this.optDescripcion.AutoSize = true;
            this.optDescripcion.Location = new System.Drawing.Point(114, 106);
            this.optDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optDescripcion.Name = "optDescripcion";
            this.optDescripcion.Size = new System.Drawing.Size(117, 24);
            this.optDescripcion.TabIndex = 33;
            this.optDescripcion.Text = "Descripcion";
            this.optDescripcion.UseVisualStyleBackColor = true;
            this.optDescripcion.CheckedChanged += new System.EventHandler(this.optDescripcion_CheckedChanged);
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Location = new System.Drawing.Point(114, 138);
            this.optCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(103, 24);
            this.optCategoria.TabIndex = 32;
            this.optCategoria.Text = "Categoria";
            this.optCategoria.UseVisualStyleBackColor = true;
            this.optCategoria.CheckedChanged += new System.EventHandler(this.optCategoria_CheckedChanged);
            // 
            // optNinguno
            // 
            this.optNinguno.AutoSize = true;
            this.optNinguno.Checked = true;
            this.optNinguno.Location = new System.Drawing.Point(114, 171);
            this.optNinguno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optNinguno.Name = "optNinguno";
            this.optNinguno.Size = new System.Drawing.Size(93, 24);
            this.optNinguno.TabIndex = 31;
            this.optNinguno.TabStop = true;
            this.optNinguno.Text = "Ninguno";
            this.optNinguno.UseVisualStyleBackColor = true;
            this.optNinguno.CheckedChanged += new System.EventHandler(this.optNinguno_CheckedChanged);
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(18, 77);
            this.lblOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(112, 22);
            this.lblOrden.TabIndex = 26;
            this.lblOrden.Text = "Ordenar por:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultar.Location = new System.Drawing.Point(352, 123);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(195, 38);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultas avanzadas";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(224, 15);
            this.lblConsultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(119, 29);
            this.lblConsultas.TabIndex = 0;
            this.lblConsultas.Text = "Consultas";
            // 
            // FrmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1101, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGestionProductos";
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
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.RadioButton optDescripcion;
        private System.Windows.Forms.RadioButton optCategoria;
        private System.Windows.Forms.RadioButton optNinguno;
    }
}