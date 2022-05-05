using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaObrasSociales : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma, Color.SeaGreen, Color.DarkSeaGreen, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        public FrmAltaObrasSociales()
        {
            InitializeComponent();
        }

        private void btnAgregarObraSocial_Click(object sender, EventArgs e)
        {
            string cuit = txtCUIT.Text;
            string razonSocial = txtRazonSocial.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if (cuit != String.Empty && razonSocial != String.Empty && direccion != String.Empty && telefono != String.Empty)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar este registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    ObraSocial oObraSocial = new ObraSocial(cuit, razonSocial, direccion, telefono);
                    MessageBox.Show(oObraSocial.MostrarDatos(), "Obra Social agregada");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos.", "Faltan llenar campos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
