namespace Vistas
{
    partial class FrmMain
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRolActual = new System.Windows.Forms.Label();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuItemSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemObrasSociales = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(538, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblRolActual);
            this.panel1.Controls.Add(this.lblUsuarioActual);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(139, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 60);
            this.panel1.TabIndex = 5;
            // 
            // lblRolActual
            // 
            this.lblRolActual.AutoSize = true;
            this.lblRolActual.Location = new System.Drawing.Point(420, 32);
            this.lblRolActual.Name = "lblRolActual";
            this.lblRolActual.Size = new System.Drawing.Size(23, 13);
            this.lblRolActual.TabIndex = 6;
            this.lblRolActual.Text = "Rol";
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActual.Location = new System.Drawing.Point(420, 9);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(107, 16);
            this.lblUsuarioActual.TabIndex = 5;
            this.lblUsuarioActual.Text = "Nombre Usuario";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(139, 66);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(646, 496);
            this.pnlContenedor.TabIndex = 7;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSistema,
            this.mnuItemUsuarios,
            this.mnuItemProductos,
            this.mnuItemClientes,
            this.mnuItemVentas,
            this.mnuItemObrasSociales});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(136, 562);
            this.mnuStrip.TabIndex = 11;
            this.mnuStrip.Text = "menuStrip2";
            // 
            // mnuItemSistema
            // 
            this.mnuItemSistema.AutoSize = false;
            this.mnuItemSistema.Name = "mnuItemSistema";
            this.mnuItemSistema.Size = new System.Drawing.Size(130, 60);
            this.mnuItemSistema.Text = "Sistema";
            this.mnuItemSistema.Click += new System.EventHandler(this.mnuItemSistema_Click);
            // 
            // mnuItemUsuarios
            // 
            this.mnuItemUsuarios.AutoSize = false;
            this.mnuItemUsuarios.Name = "mnuItemUsuarios";
            this.mnuItemUsuarios.Size = new System.Drawing.Size(130, 60);
            this.mnuItemUsuarios.Text = "Usuarios";
            this.mnuItemUsuarios.Click += new System.EventHandler(this.mnuItemUsuarios_Click);
            // 
            // mnuItemProductos
            // 
            this.mnuItemProductos.AutoSize = false;
            this.mnuItemProductos.Name = "mnuItemProductos";
            this.mnuItemProductos.Size = new System.Drawing.Size(130, 60);
            this.mnuItemProductos.Text = "Productos";
            this.mnuItemProductos.Click += new System.EventHandler(this.mnuItemProductos_Click);
            // 
            // mnuItemClientes
            // 
            this.mnuItemClientes.AutoSize = false;
            this.mnuItemClientes.Name = "mnuItemClientes";
            this.mnuItemClientes.Size = new System.Drawing.Size(130, 60);
            this.mnuItemClientes.Text = "Clientes";
            this.mnuItemClientes.Click += new System.EventHandler(this.mnuItemClientes_Click);
            // 
            // mnuItemVentas
            // 
            this.mnuItemVentas.AutoSize = false;
            this.mnuItemVentas.Name = "mnuItemVentas";
            this.mnuItemVentas.Size = new System.Drawing.Size(130, 60);
            this.mnuItemVentas.Text = "Ventas";
            this.mnuItemVentas.Click += new System.EventHandler(this.mnuItemVentas_Click);
            // 
            // mnuItemObrasSociales
            // 
            this.mnuItemObrasSociales.AutoSize = false;
            this.mnuItemObrasSociales.Name = "mnuItemObrasSociales";
            this.mnuItemObrasSociales.Size = new System.Drawing.Size(130, 60);
            this.mnuItemObrasSociales.Text = "Obras Sociales";
            this.mnuItemObrasSociales.Click += new System.EventHandler(this.mnuItemObrasSociales_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContenedor;
        public System.Windows.Forms.Label lblRolActual;
        public System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuItemVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuItemObrasSociales;

    }
}