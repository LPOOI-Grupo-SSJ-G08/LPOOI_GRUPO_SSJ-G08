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
    public partial class FrmBajaUsuario : Form
    {
        public FrmBajaUsuario()
        {
            InitializeComponent();
            cargarUsuarios();
        }
        
        private void cargarUsuarios()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TrabajarUsuario.baja_usuarios(Int32.Parse(txtIdUsuario.Text));
                cargarUsuarios();
            }
            catch (Exception efe)
            {
                MessageBox.Show("Ingrese un numero ");
            }
        }
    }
}
