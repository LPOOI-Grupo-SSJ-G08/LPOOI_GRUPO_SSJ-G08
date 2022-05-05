using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma, Color.SeaGreen, Color.DarkSeaGreen, LinearGradientMode.BackwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioEncontrado = false;
            Usuario usuario1 = new Usuario(1, "Juan", "juan", "Juan Gomez", 1);
            Usuario usuario2 = new Usuario(2, "Pedro", "pedro", "Pedro Mendez", 2);
            Usuario usuario3 = new Usuario(3, "Maria", "maria", "Maria Lopez", 3);

            Usuario[] usuarios = new Usuario[] { usuario1, usuario2, usuario3 };

            FrmMain frmMain = new FrmMain();

            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario != String.Empty && password != String.Empty)
            {
                foreach (Usuario usu in usuarios)
                {
                    if (usu.Usu_NombreUsuario == usuario && usu.Usu_Contrasenia == password)
                    {
                        usuarioEncontrado = true;
                        break;
                    }
                }

                if (usuarioEncontrado)
                {
                    MessageBox.Show("Bienvenido " + usuario + "!");
                    txtPassword.Text = String.Empty;
                    this.Hide();
                    Form FrmMain = new FrmMain();
                    FrmMain.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos", "Fallo de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = String.Empty;
                    txtPassword.Text = String.Empty;
                    txtUsuario.Select();
                }
            }
            else
            {
                MessageBox.Show("Faltan llenar campos", "Fallo de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.DarkSeaGreen;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.SeaGreen;
        }

        

    }
}