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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.optDES = new System.Windows.Forms.RadioButton();
            this.optASC = new System.Windows.Forms.RadioButton();
            this.optNinguno = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 202);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1026, 508);
            this.dgvClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 80);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(398, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(178, 138);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(223, 26);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(174, 109);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(142, 20);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "Ingrese búsqueda:";
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(603, 109);
            this.lblOrdenar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(156, 20);
            this.lblOrdenar.TabIndex = 4;
            this.lblOrdenar.Text = "Ordenar por apellido:";
            // 
            // optDES
            // 
            this.optDES.AutoSize = true;
            this.optDES.Location = new System.Drawing.Point(681, 140);
            this.optDES.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optDES.Name = "optDES";
            this.optDES.Size = new System.Drawing.Size(60, 24);
            this.optDES.TabIndex = 5;
            this.optDES.TabStop = true;
            this.optDES.Text = "Z-A";
            this.optDES.UseVisualStyleBackColor = true;
            this.optDES.CheckedChanged += new System.EventHandler(this.optDES_CheckedChanged);
            // 
            // optASC
            // 
            this.optASC.AutoSize = true;
            this.optASC.Location = new System.Drawing.Point(609, 140);
            this.optASC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optASC.Name = "optASC";
            this.optASC.Size = new System.Drawing.Size(60, 24);
            this.optASC.TabIndex = 6;
            this.optASC.TabStop = true;
            this.optASC.Text = "A-Z";
            this.optASC.UseVisualStyleBackColor = true;
            this.optASC.CheckedChanged += new System.EventHandler(this.optASC_CheckedChanged);
            // 
            // optNinguno
            // 
            this.optNinguno.AutoSize = true;
            this.optNinguno.Location = new System.Drawing.Point(754, 140);
            this.optNinguno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optNinguno.Name = "optNinguno";
            this.optNinguno.Size = new System.Drawing.Size(93, 24);
            this.optNinguno.TabIndex = 7;
            this.optNinguno.TabStop = true;
            this.optNinguno.Text = "Ninguno";
            this.optNinguno.UseVisualStyleBackColor = true;
            this.optNinguno.CheckedChanged += new System.EventHandler(this.optNinguno_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(412, 135);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1026, 711);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.optNinguno);
            this.Controls.Add(this.optASC);
            this.Controls.Add(this.optDES);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.RadioButton optDES;
        private System.Windows.Forms.RadioButton optASC;
        private System.Windows.Forms.RadioButton optNinguno;
        private System.Windows.Forms.Button btnLimpiar;
    }
}