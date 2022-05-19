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
        private Form activeForm = null;

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
                this.activeForm.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Activate();
                frmLogin.Show();
                this.Close();
            }
        }

        private void AbrirFormHijo(Form frmHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            this.activeForm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            this.pnlContenedor.Controls.Add(frmHijo);
            pnlContenedor.Tag = frmHijo;
            frmHijo.Show();
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmInicio());
            //btnSistema.BackColor = SystemColors.ControlDark;

            if (lblRolActual.Text != "Auditor")
            {
                btnUsuarios.Enabled = false;
                btnProductos.Enabled = false;
                btnClientes.Enabled = false;
                btnVentas.Enabled = false;
            }
            if (lblRolActual.Text == "Administrador")
            {
                btnUsuarios.Enabled = true;
                btnProductos.Enabled = true;
            }
            if (lblRolActual.Text == "Operador")
            {
                btnClientes.Enabled = true;
                btnVentas.Enabled = true;
            }
        }

        private void PintarBotones()
        {
            //for (int i = 0; i < mnuStrip.Items.Count; i++)
            //{
            //    mnuStrip.Items[i].BackColor = SystemColors.Control;
            //}
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnSistema.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmInicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnUsuarios.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmGestionUsuarios());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnProductos.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaProductos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnClientes.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmGestionClientes());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnVentas.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaVentas());
        }

        private void btnListadoVentas_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnListadoVentas.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmListadoVentas());
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            //PintarBotones();
            //btnObrasSociales.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaObrasSociales());
        }

    }
}
