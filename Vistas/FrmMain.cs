using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma, Color.SeaGreen, Color.DarkSeaGreen, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogoResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmAltaClientes frmAltaClientes = new FrmAltaClientes();
            frmAltaClientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmAltaProductos frmAltaProductos = new FrmAltaProductos();
            frmAltaProductos.Show();
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            FrmAltaObrasSociales frmAltaObrasSociales = new FrmAltaObrasSociales();
            frmAltaObrasSociales.Show();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSeaGreen;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SeaGreen;
        }

    }
}
