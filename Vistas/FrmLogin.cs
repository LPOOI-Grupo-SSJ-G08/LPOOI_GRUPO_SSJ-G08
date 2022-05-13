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
            string szUsuario = txtUsuario.Text;
            string szPassword = txtPassword.Text;

            if (szUsuario != String.Empty && szPassword != String.Empty)
            {
                int iRol = TrabajarUsuario.search_usuario(szUsuario, szPassword);

                if (iRol != 0)
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