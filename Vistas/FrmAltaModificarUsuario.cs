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
    public partial class FrmAltaModificarUsuario : Form
    {
        Usuario usuarioTmp;
        public FrmAltaModificarUsuario()
        {
            InitializeComponent();
            this.cargarUsuarios();
        }
        
        public FrmAltaModificarUsuario(Usuario usuario)
        {
            this.usuarioTmp = usuario;
            InitializeComponent();
            this.cargarUsuarios();
            txtUsuario.Text = this.usuarioTmp.Usu_NombreUsuario;
            txtNombreompleto.Text = this.usuarioTmp.Usu_ApellidoNombre;
            txtContrasenia.Text = this.usuarioTmp.Usu_Contrasenia;
            switch (this.usuarioTmp.Rol_Codigo)
            {
                case 0:
                    cmbRol.Text = "Administrador";
                    break;
                case 1:
                    cmbRol.Text = "Auditor";
                    break;
                case 2:
                    cmbRol.Text = "Operador";
                    break;
            }

            btnAgregar.Text = "Modificar";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.usuarioTmp == null)
            {
                this.AgregarUsuario();
            }
            else
            {
                this.ModificarUsuarios();
            }

        }

        private void setUsuario(Usuario ouser)
        {
            int numRol = ouser.Rol_Codigo;
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
        }

        private void AgregarUsuario()
        {
            Usuario ouser = new Usuario();

                var dialogoConfirmacion = MessageBox.Show("Desea Agregar a este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                if (dialogoConfirmacion == DialogResult.No)
                {
                    MessageBox.Show("Usuario no agregado");
                    return;
                    // Limpiamos campos
                }
                try
                {
                   this.setUsuario(ouser);
                   TrabajarUsuario.agregarUsuario(ouser);
                   this.cargarUsuarios();

                }
                catch (Exception efe)
                {
                    MessageBox.Show("Ha fallado" + efe.Message);
                }
        }


        private void ModificarUsuarios()
        {
            this.setUsuario(this.usuarioTmp);
            TrabajarUsuario.modificar_usuario(this.usuarioTmp);
            this.cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
            this.Close();
        }

        

        
    }
}
