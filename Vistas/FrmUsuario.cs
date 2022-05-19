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
    public partial class FrmUsuario : Form
    {
        Usuario usuarioTmp;
        public FrmUsuario()
        {
            InitializeComponent();
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaModificarUsuario frmAltaUsuario = new FrmAltaModificarUsuario();
            frmAltaUsuario.Show();
            this.Close();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            FrmAltaModificarUsuario frmAltaUsuario = new FrmAltaModificarUsuario(this.usuarioTmp);
            frmAltaUsuario.Show();
            this.Close();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {   
            try
            {
                var dialogoConfirmacion = MessageBox.Show("Desea eliminar a " + dgvListaUsuarios.CurrentRow.Cells[1].Value+"?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogoConfirmacion == DialogResult.No)
                {
                    MessageBox.Show("Usuario no eliminado");
                    return;
                }

                TrabajarUsuario.baja_usuarios((int)dgvListaUsuarios.CurrentRow.Cells[0].Value);
                dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
                MessageBox.Show("Usuario eliminado correctamente");
            }
            catch(Exception efe)
            {
                MessageBox.Show("Problemas al eliminar usuario " + efe);
            }
               
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (txtNombreUsuario.Text == "")
            {
                dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
            }

            
            if (txtNombreUsuario.TextLength >= 2)
            {
                dgvListaUsuarios.DataSource = TrabajarUsuario.buscar_usuario(txtNombreUsuario.Text);
            }
        }

        private void dgvListaUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            
            if (dgvListaUsuarios.CurrentRow != null) {
                int valor = (int)dgvListaUsuarios.CurrentRow.Cells[0].Value;
                this.usuarioTmp = TrabajarUsuario.buscar_usuario(valor);
            }
        }
    }
}
