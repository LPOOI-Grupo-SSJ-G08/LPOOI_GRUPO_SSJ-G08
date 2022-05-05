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
    public partial class FrmAltaProductos : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma, Color.SeaGreen, Color.DarkSeaGreen, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        public FrmAltaProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string categoria = txtCategoria.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;

            if (codigo != String.Empty && categoria != String.Empty && descripcion != String.Empty && precio != String.Empty)
            {
                if (Convert.ToDecimal(precio) > 0)
                {
                    DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar este registro?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogoResult == DialogResult.Yes)
                    {
                        Producto oProducto = new Producto(codigo, categoria, descripcion, Convert.ToDecimal(precio));
                        MessageBox.Show(oProducto.MostrarDatos(), "Producto agregado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe proporcionar un precio válido.", "Precio incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
