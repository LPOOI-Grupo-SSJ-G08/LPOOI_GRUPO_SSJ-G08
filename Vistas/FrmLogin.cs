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
            bool bUsuarioEncontrado = false;
            Usuario oUsuario1 = new Usuario(1, "Juan", "juan", "Juan Gomez", 1);
            Usuario oUsuario2 = new Usuario(2, "Pedro", "pedro", "Pedro Mendez", 2);
            Usuario oUsuario3 = new Usuario(3, "Maria", "maria", "Maria Lopez", 3);

            Usuario[] usuarios = new Usuario[] { oUsuario1, oUsuario2, oUsuario3 };

            FrmMain frmMain = new FrmMain();

            string szUsuario = txtUsuario.Text;
            string szPassword = txtPassword.Text;

            if (szUsuario != String.Empty && szPassword != String.Empty)
            {
                foreach (Usuario usu in usuarios)
                {
                    if (usu.Usu_NombreUsuario == szUsuario && usu.Usu_Contrasenia == szPassword)
                    {
                        bUsuarioEncontrado = true;
                        break;
                    }
                }

                if (bUsuarioEncontrado)
                {
                    MessageBox.Show("Bienvenido " + szUsuario + "!");
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