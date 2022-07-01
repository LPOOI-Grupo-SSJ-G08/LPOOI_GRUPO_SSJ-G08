using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmInicio : Form
    {
        public Usuario oUsuario;

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FrmEditarPerfil frmEditarPerfil = new FrmEditarPerfil();
            frmEditarPerfil.oUsuario = oUsuario;
            frmEditarPerfil.Show();
        }

    }
}
