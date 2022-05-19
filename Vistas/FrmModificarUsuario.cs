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
    public partial class FrmModificarUsuario : Form
    {
        Usuario usuarioTmp;
        public FrmModificarUsuario()
        {
            InitializeComponent();
            this.cargarUsuarios();
            this.esconder();
        }
        
        public FrmModificarUsuario(Usuario usuario)
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

            this.esconder();
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
                }
                try
                {
                    if (this.comprobarAltaModificarUsuario() && !this.comprobarUsuarioExistente(txtUsuario.Text))
                    {
                       this.setUsuario(ouser);
                       TrabajarUsuario.agregarUsuario(ouser);
                       this.cargarUsuarios();
                       this.esconder();
                       this.limpiarCampos(); 
                    }
                   

                }
                catch (Exception efe)
                {
                    MessageBox.Show("Ha fallado - " + efe.Message);
                }
        }


        private void ModificarUsuarios()
        {   
            try
            {


                if (this.comprobarAltaModificarUsuario() && !this.comprobarUsuarioExistente(txtUsuario.Text))
                {
                    var dialogoConfirmacion = MessageBox.Show("Desea modificar a este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                    if (dialogoConfirmacion == DialogResult.No)
                    {
                        MessageBox.Show("Usuario no modificado");
                        return;
                    }
                    this.setUsuario(this.usuarioTmp);
                    TrabajarUsuario.modificar_usuario(this.usuarioTmp);
                    MessageBox.Show("Usuario modificado correctamente");
                    this.cargarUsuarios();
                    this.esconder();
                }
                            
            }
            catch (Exception efe)
            {
                MessageBox.Show("No se ha podido modificar el usuario "+ efe);
            }
        }

        private bool comprobarAltaModificarUsuario()
        {
            bool bandera=true;
            try
            {
                if (txtUsuario.TextLength < 3)
                {
                    lblValidUsuario.Show();
                    bandera = false;
                }
                else
                    lblValidUsuario.Hide();
                
                if (txtContrasenia.TextLength < 3)
                {                  
                    lblValidContrasenia.Show();
                    bandera = false;
                }
                else
                    lblValidContrasenia.Hide();

                if (txtNombreompleto.TextLength < 3)
                {
                    lblValidNombreCompleto.Show();
                    bandera = false;
                }
                else
                    lblValidNombreCompleto.Hide();

            }
            catch (Exception efe)
            {
                    lblValidUsuario.Show();
                    lblValidContrasenia.Show();
                    lblValidNombreCompleto.Show();
                    bandera = false;
            }

            return bandera;
        }
        private void cargarUsuarios()
        {
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmUsuario = new FrmGestionUsuarios();
            frmUsuario.Show();
            this.Close();
        }

        private void esconder()
        {
            lblValidUsuario.Hide();
            lblValidContrasenia.Hide();
            lblValidNombreCompleto.Hide();
        }


        private void limpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
            txtNombreompleto.Clear();

        }


        private bool comprobarUsuarioExistente(string nombreUsuario)
        {
            if (TrabajarUsuario.comprobar_NombreUsuarioExistente(nombreUsuario))
            {
                MessageBox.Show("El usuario ya existe en el sistema");
                return true;
            }
            else
            {
                return false;
            }            
        }
        
    }
}
