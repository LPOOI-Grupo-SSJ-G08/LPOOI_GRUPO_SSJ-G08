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
            this.grdVentas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToAddRows = false;
            this.grdVentas.AllowUserToDeleteRows = false;
            this.grdVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdVentas.BackgroundColor = System.Drawing.Color.Black;
            this.grdVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentas.Location = new System.Drawing.Point(22, 23);
            this.grdVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ReadOnly = true;
            this.grdVentas.RowTemplate.Height = 28;
            this.grdVentas.Size = new System.Drawing.Size(291, 140);
            this.grdVentas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(22, 180);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(92, 30);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 227);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grdVentas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListadoVentas";
            this.Text = "FrmListadoVentas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVentas;
        private System.Windows.Forms.Button btnVolver;
    }
}