using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ClasesBase;

namespace Vistas
{
    public partial class FrmEditarPerfil : Form
    {
        public Usuario oUsuario = new Usuario();
        Boolean cargoImg = false;

        public FrmEditarPerfil()
        {
            InitializeComponent();
        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            HideErrorLabels();
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            txtUsername.Text = oUsuario.Usu_NombreUsuario;
            txtPassword.Text = oUsuario.Usu_Contrasenia;
            txtNombre.Text = oUsuario.Usu_ApellidoNombre;
            imgUsuario.Image = oUsuario.Usu_Imagen;
        }

        private void imgUsuario_Paint(object sender, PaintEventArgs e)
        {
            Pen oPen = new Pen(ColorTranslator.FromHtml("#28262C"), 10f);
            e.Graphics.DrawEllipse(oPen, 0, 0, imgUsuario.Size.Width, imgUsuario.Size.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, imgUsuario.Size.Width, imgUsuario.Size.Height);
            imgUsuario.Region = new Region(path);
        }

        public void HideErrorLabels()
        {
            lblValidUsername.Hide();
            lblValidPassword.Hide();
            lblValidNombre.Hide();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (txtUsername.Text.Length != 8)
            {
                lblUsername.Show();
                bErrorFound = true;
            }
            if (txtPassword.Text.Length < 3)
            {
                lblValidPassword.Show();
                bErrorFound = true;
            }
            if (txtNombre.Text.Length < 3)
            {
                lblValidNombre.Show();
                bErrorFound = true;
            }
        }

        private void ValidarUsuarioExistente(ref bool bErrorFound)
        {
            if (!TrabajarUsuario.comprobar_NombreUsuarioExistente(txtUsername.Text))
            {
                bErrorFound = false;
            }
            else
            {
                if (TrabajarUsuario.buscar_por_nombre_usuario(txtUsername.Text).Usu_Id == this.oUsuario.Usu_Id)
                    bErrorFound = false;
                else
                {
                    MessageBox.Show("El usuario ya existe en el sistema");
                    bErrorFound = true;
                }
            }
        }

        private void btnCambiarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                imgUsuario.Image = new Bitmap(of.FileName);
            }
            cargoImg = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);
            ValidarUsuarioExistente(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Esta seguro de que desea guardar los cambios?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Usuario oUsuario = new Usuario();
                    oUsuario.Usu_Id = this.oUsuario.Usu_Id;
                    oUsuario.Usu_NombreUsuario = txtUsername.Text;
                    oUsuario.Usu_Contrasenia = txtPassword.Text;
                    oUsuario.Usu_ApellidoNombre = txtNombre.Text;
                    oUsuario.Usu_Imagen = imgUsuario.Image;
                    oUsuario.Rol_Codigo = this.oUsuario.Rol_Codigo;

                    if (!cargoImg)
                        TrabajarUsuario.modificar_usuario(oUsuario);
                    else
                        TrabajarUsuario.modificar_usuarioImg(oUsuario);
                }
                else
                {
                    CargarUsuario();
                }
            }
        }
    }
}
