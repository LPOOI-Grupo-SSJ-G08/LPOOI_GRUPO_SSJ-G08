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
    public partial class FrmAltaClientes : Form
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma, Color.SeaGreen, Color.DarkSeaGreen, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));

        }

        public FrmAltaClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string direccion = txtDireccion.Text;
            string cuit = txtCUIT.Text;
            string nroCarnet = txtNroCarnet.Text;

            if (nombre != String.Empty && apellido != String.Empty && dni != String.Empty && direccion != String.Empty && cuit != String.Empty && nroCarnet != String.Empty)
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que desea guardar este registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente(nombre, apellido, dni, direccion, cuit, nroCarnet);
                    MessageBox.Show(oCliente.MostrarDatos(), "Cliente agregado");
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
