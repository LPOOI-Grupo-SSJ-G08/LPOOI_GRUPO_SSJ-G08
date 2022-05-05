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
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                string szNombre = txtNombre.Text;
                string szApellido = txtApellido.Text;
                string szDni = txtDNI.Text;
                string szDireccion = txtDireccion.Text;
                string szCuit = txtCUIT.Text;
                string szNroCarnet = txtNroCarnet.Text;

                DialogResult dialogResult = MessageBox.Show("¿Esta seguro de que desea guardar este registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente(szNombre, szApellido, szDni, szDireccion, szCuit, szNroCarnet);
                    MessageBox.Show("Datos del cliente: " +
                                     "\n\n DNI : " + oCliente.Cli_DNI +
                                     "\n Apellido : " + oCliente.Cli_Apellido +
                                     "\n Nombre : " + oCliente.Cli_Nombre +
                                     "\n Dirección : " + oCliente.Cli_Direccion +
                                     "\n CUIT OS: " + oCliente.Os_CUIT +
                                     "\n Nro. de Carnet : " + oCliente.Cli_NroCarnet);
                    ClearTextBoxs();
                }

            }                  
        }

        public void HideErrorLabels()
        {
            lblValidDni.Hide();
            lblValidApellido.Hide();
            lblValidNombre.Hide();
            lblValidDireccion.Hide();
            lblValidCUIT.Hide();
            lblValidNroCarnet.Hide();
        }

        private void ClearTextBoxs()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCUIT.Clear();
            txtNroCarnet.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (txtDNI.Text.Length != 8)
            {
                lblValidDni.Show();
                bErrorFound = true;
            }
            if (txtApellido.Text.Length < 3)
            {
                lblValidApellido.Show();
                bErrorFound = true;
            }
            if (txtNombre.Text.Length < 3)
            {
                lblValidNombre.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblValidDireccion.Show();
                bErrorFound = true;
            }
            if (!txtCUIT.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtCUIT.Text))
            {
                lblValidCUIT.Show();
                bErrorFound = true;
            }
            if (!txtNroCarnet.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtNroCarnet.Text))
            {
                lblValidNroCarnet.Show();
                bErrorFound = true;
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
