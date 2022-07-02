using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.IO;

namespace Vistas
{   
    public partial class FrmGestionUsuarios : Form
    {
        Usuario usuarioTmp;
        Boolean cargoImg = false;

        public FrmGestionUsuarios()
        {
            InitializeComponent();
            cargarUsuarios();
            cargar_combo_roles();
            this.esconder();
            dgvListaUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }

        private void cargar_combo_roles()
        {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = TrabajarUsuario.get_roles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                       if (txtCorreo.Text != "")
                           ouser.Usu_Correo = txtCorreo.Text;
                       if (ouser.Usu_Imagen == null)
                           TrabajarUsuario.agregarUsuario(ouser);
                       else
                           TrabajarUsuario.agregarUsuarioImg(ouser);
                       this.cargarUsuarios();
                       this.esconder();
                       this.limpiarCampos();
                       this.HabilitarAcciones(false);
                    }
                }
                catch (Exception efe)
                {
                    MessageBox.Show("Ha fallado - " + efe.Message);
                }
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
                limpiarCampos();
                this.HabilitarAcciones(false);
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
            DataTable dt;
            if (txtNombreUsuario.TextLength >= 2) {
                dt = TrabajarUsuario.buscar_usuario(txtNombreUsuario.Text);
            } else {
                dt = TrabajarUsuario.list_usuarios();
            }
            contarRegistrosDevueltos(dt);
        }


        private void setUsuario(Usuario ouser)
        {
            ouser.Usu_Contrasenia = txtContrasenia.Text;
            ouser.Usu_ApellidoNombre = txtNombreCompleto.Text;
            ouser.Usu_NombreUsuario = txtUsuario.Text;
            ouser.Rol_Codigo = (int)cmbRol.SelectedValue;
            ouser.Usu_Imagen = imgUsuario.Image;
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

                if (txtNombreCompleto.TextLength < 3)
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
            DataTable dt = TrabajarUsuario.list_usuarios();
            dgvListaUsuarios.DataSource = dt;
            dgvListaUsuarios.Columns["Imagen"].Visible = false;
            dgvListaUsuarios.Columns["Rol_codigo"].Visible = false;
            contarRegistrosDevueltos(dt);
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
            txtNombreCompleto.Clear();
            txtCorreo.Clear();
            imgUsuario.Image = null;
        }


        private bool comprobarUsuarioExistenteModificar(string nombreUsuario)
        {
            if (!TrabajarUsuario.comprobar_NombreUsuarioExistente(nombreUsuario))
            {
                return false;
            }
            else
            {
                if (TrabajarUsuario.buscar_por_nombre_usuario(nombreUsuario).Usu_Id == this.usuarioTmp.Usu_Id)
                    return false;
                else
                {
                    MessageBox.Show("El usuario ya existe en el sistema");
                    return true;
                }
            }
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

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaUsuarios.CurrentRow.Cells["Id"].Value.ToString() != "")
            {
                int valor = (int)dgvListaUsuarios.CurrentRow.Cells[0].Value;
                this.usuarioTmp = TrabajarUsuario.buscar_usuario(valor);
                cmbRol.Text = dgvListaUsuarios.CurrentRow.Cells["rol"].Value.ToString();
                txtUsuario.Text = this.usuarioTmp.Usu_NombreUsuario;
                txtContrasenia.Text = this.usuarioTmp.Usu_Contrasenia;
                txtNombreCompleto.Text = this.usuarioTmp.Usu_ApellidoNombre;
                if (dgvListaUsuarios.CurrentRow.Cells["Imagen"].Value.ToString() != "")
                    imgUsuario.Image = Util.ByteToImage((byte[])dgvListaUsuarios.CurrentRow.Cells["Imagen"].Value);
                else
                    imgUsuario.Image = Image.FromFile(Util.CompleteImagePath("no-photo.png"));
                    this.HabilitarAcciones(true);
                    txtCorreo.Text = dgvListaUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            }
            cargoImg = false;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.comprobarAltaModificarUsuario() && !this.comprobarUsuarioExistenteModificar(txtNombreUsuario.Text))
                {
                    var dialogoConfirmacion = MessageBox.Show("Desea modificar a este usuario?", "Confirmar", MessageBoxButtons.YesNo);
                    if (dialogoConfirmacion == DialogResult.No)
                    {
                        MessageBox.Show("Usuario no modificado");
                        return;
                    }
                    this.setUsuario(this.usuarioTmp);
                    usuarioTmp.Usu_Correo = txtCorreo.Text;
                    if (!cargoImg)
                        TrabajarUsuario.modificar_usuario(this.usuarioTmp);
                    else
                        TrabajarUsuario.modificar_usuarioImg(this.usuarioTmp);
                    MessageBox.Show("Usuario modificado correctamente");
                    this.cargarUsuarios();
                    this.esconder();
                    this.HabilitarAcciones(false);
                }

            }
            catch (Exception efe)
            {
                MessageBox.Show("No se ha podido modificar el usuario " + efe);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.usuarioTmp = null;
            this.limpiarCampos();
            this.esconder();
            this.HabilitarAcciones(false);
            cargoImg = false;
        }

        private void HabilitarAcciones(bool b)
        {
            btnAgregar.Enabled = !b;
            btnModificarUsuario.Enabled = b;
            btnEliminarUsuario.Enabled = b;
            cambiarColor(btnAgregar);
            cambiarColor(btnModificarUsuario);
            cambiarColor(btnEliminarUsuario);
        }

        private void cambiarColor(Button btn)
        {

            if (btn.Enabled == false)
            {
                btn.BackColor = ColorTranslator.FromHtml("#575B58");
            }
            else
            {
                if (!(btn.Text == "Eliminar"))
                {
                    btn.BackColor = ColorTranslator.FromHtml("#1B998B");
                }
                else
                {
                    btn.BackColor = Color.Crimson;
                }
            }
        }

        private void btnSeleccionarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                //imgUsuario.ImageLocation = of.FileName;
                imgUsuario.Image = new Bitmap(of.FileName);
            }
            cargoImg = true;
        }

        private void contarRegistrosDevueltos(DataTable dt) {
            lblCountRegistros.Text = Convert.ToString(dt.Rows.Count);
        }
    }
}
