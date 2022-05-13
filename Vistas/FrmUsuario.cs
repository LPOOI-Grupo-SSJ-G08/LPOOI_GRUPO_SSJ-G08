using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
            frmAltaUsuario.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            FrmModificarUsuario frmModificarUsuario = new FrmModificarUsuario();
            frmModificarUsuario.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            FrmBajaUsuario frmBajaUsuario = new FrmBajaUsuario();
            frmBajaUsuario.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
