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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            
            InitializeComponent();
            this.cargarUsuarios();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
            Usuario ouser = new Usuario();
            string nombreCompleto, contrasenia, usuario,rol;
            int numRol=-1;

            var dialogoConfirmacion = MessageBox.Show("Desea Agregar a este usuario?","Confirmar", MessageBoxButtons.YesNo);
            if (dialogoConfirmacion == DialogResult.No)
            {
                MessageBox.Show("Usuario no agregado");
                return;
                // Limpiamos campos
            }
            try
            {
                switch (cmbRol.Text)
                {
                    case "Administrador":
                        numRol = 0;
                        break;
                    case "Auditor":
                        numRol = 1;
                        break;
                    case "Operador":
                        numRol = 2;
                        break;
                }
                ouser.Usu_Contrasenia = txtContrasenia.Text;
                ouser.Usu_ApellidoNombre = txtNombreompleto.Text;
                ouser.Usu_NombreUsuario = txtUsuario.Text;
                ouser.Rol_Codigo = numRol;
               // MessageBox.Show(ouser.ToString());

                TrabajarUsuario.agregarUsuario(ouser);
                this.cargarUsuarios();
                
            }
            catch (Exception efe)
            {
                MessageBox.Show("Ha fallado" + efe.Message);
            }
        }

        private void cargarUsuarios()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
