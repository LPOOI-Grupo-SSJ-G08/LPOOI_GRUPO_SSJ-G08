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
                //this.Close();
                Application.Exit();
            }
        }

        private void AbrirFormHijo(Form frmHijo)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                pnlContenedor.Controls.RemoveAt(0);
            }
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            pnlContenedor.Controls.Add(frmHijo);
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
            if (lblRolActual.Text != "Auditor")
            {
                mnuItemUsuarios.Visible = false;
                mnuItemProductos.Visible = false;
                mnuItemClientes.Visible = false;
                mnuItemVentas.Visible = false;
            }
            else
            {
                //AbrirFormHijo(new FrmGestionUsuarios());
            }
            if (lblRolActual.Text == "Administrador")
            {
                mnuItemUsuarios.Visible = true;
                mnuItemProductos.Visible = true;
                //AbrirFormHijo(new FrmGestionUsuarios());
            }
            if (lblRolActual.Text == "Operador")
            {
                mnuItemClientes.Visible = true;
                mnuItemVentas.Visible = true;
                //AbrirFormHijo(new FrmGestionClientes());
            }
        }

        private void mnuItemUsuarios_Click(object sender, EventArgs e)
        {
            PintarBotones();
            mnuItemUsuarios.BackColor = SystemColors.ControlDark;
            //AbrirFormHijo(new FrmUsuario());
            //AbrirFormHijo(new FrmGestionUsuarios());
        }

        private void mnuItemProductos_Click(object sender, EventArgs e)
        {
            PintarBotones();
            mnuItemProductos.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaProductos());
        }

        private void mnuItemClientes_Click(object sender, EventArgs e)
        {
            PintarBotones();
            mnuItemClientes.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaClientes());
        }

        private void mnuItemVentas_Click(object sender, EventArgs e)
        {
            PintarBotones();
            mnuItemVentas.BackColor = SystemColors.ControlDark;
            //AbrirFormHijo(new FrmAltaVentas());
        }

        private void mnuItemObrasSociales_Click(object sender, EventArgs e)
        {
            PintarBotones();
            mnuItemObrasSociales.BackColor = SystemColors.ControlDark;
            AbrirFormHijo(new FrmAltaObrasSociales());
        }

        private void PintarBotones()
        {
            for (int i = 0; i < mnuStrip.Items.Count; i++)
            {
                mnuStrip.Items[i].BackColor = SystemColors.Control;
            }
        }
    }
}
