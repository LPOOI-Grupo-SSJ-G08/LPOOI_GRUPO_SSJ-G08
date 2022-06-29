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
    public partial class FrmMain : Form
    {
        private Form activeForm = null;
        private static Button btnBotonActual;
        private static Button btnBotonAnterior;
        public Usuario userMain = new Usuario();

        public FrmMain()
        {
            InitializeComponent();
            btnBotonActual = btnSistema;
            btnBotonAnterior = btnSistema;
            PintarBotones(btnSistema);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogoResult == DialogResult.Yes)
            {
                this.activeForm.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Activate();
                frmLogin.Show();
                this.Close();
            }
        }

        internal void AbrirFormHijo(Form frmHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            this.activeForm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            this.pnlContenedor.Controls.Add(frmHijo);
            pnlContenedor.Tag = frmHijo;
            frmHijo.Show();
        }
        
        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Crimson;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#1B998B");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            userMain = TrabajarUsuario.buscar_por_nombre_usuario(lblUsuarioActual.Text);
            frmInicio.lblBienvenida.Text = "Bienvenido/a " + lblUsuarioActual.Text + "!";
            frmInicio.lblRol.Text = "Se logueó con el rol de " + lblRolActual.Text;
            frmInicio.lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            frmInicio.lblRol.TextAlign = ContentAlignment.MiddleCenter;
            frmInicio.imgUsuario.Image = userMain.Usu_Imagen;
            imgUsuarioMain.Image = userMain.Usu_Imagen;
            imgUsuarioMain.Visible = false;
            AbrirFormHijo(frmInicio);

            if (lblRolActual.Text != "Auditor")
            {
                btnUsuarios.Enabled = false;
                btnProductos.Enabled = false;
                btnClientes.Enabled = false;
                btnVentas.Enabled = false;
                cambiarColor(btnUsuarios);
                cambiarColor(btnProductos);
                cambiarColor(btnClientes);
                cambiarColor(btnVentas);
            }
            if (lblRolActual.Text == "Administrador")
            {
                btnUsuarios.Enabled = true;
                btnProductos.Enabled = true;
                cambiarColor(btnUsuarios);
                cambiarColor(btnProductos);
            }
            if (lblRolActual.Text == "Operador")
            {
                btnClientes.Enabled = true;
                btnVentas.Enabled = true;
                cambiarColor(btnClientes);
                cambiarColor(btnVentas);
            }
        }

        private void cambiarColor(Button btn)
        {

            if (btn.Enabled == false)
            {
                btn.BackColor = ColorTranslator.FromHtml("#A1A5A2");
            }
            else
            {
                btn.BackColor = ColorTranslator.FromHtml("#007BFF");
            }
        }

        private void PintarBotones(Button btn)
        {
            try
            {
                btnBotonAnterior = btnBotonActual;
                btnBotonAnterior.BackColor = ColorTranslator.FromHtml("#007BFF");
                btnBotonActual = btn;
            }
            catch (Exception efe)
            {
            }
            btnBotonActual.BackColor = ColorTranslator.FromHtml("#28262C");
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            PintarBotones(btnSistema);
            FrmInicio frmInicio = new FrmInicio();
            userMain = TrabajarUsuario.buscar_por_nombre_usuario(lblUsuarioActual.Text);
            frmInicio.lblBienvenida.Text = "Bienvenido/a " + lblUsuarioActual.Text + "!";
            frmInicio.lblRol.Text = "Se logueó con el rol de " + lblRolActual.Text;
            frmInicio.lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            frmInicio.lblRol.TextAlign = ContentAlignment.MiddleCenter;
            frmInicio.imgUsuario.Image = userMain.Usu_Imagen;
            imgUsuarioMain.Visible = false;
            AbrirFormHijo(frmInicio);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PintarBotones(btnUsuarios);
            AbrirFormHijo(new FrmGestionUsuarios());
            imgUsuarioMain.Visible = true;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            PintarBotones(btnProductos);
            AbrirFormHijo(new FrmGestionProductos());
            imgUsuarioMain.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            PintarBotones(btnClientes);
            AbrirFormHijo(new FrmGestionClientes());
            imgUsuarioMain.Visible = true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            PintarBotones(btnVentas);
            AbrirFormHijo(new FrmAltaVentas());
            imgUsuarioMain.Visible = true;
        }

        private void btnListadoVentas_Click(object sender, EventArgs e)
        {
            PintarBotones(btnListadoVentas);
            AbrirFormHijo(new FrmListadoVentas());
            imgUsuarioMain.Visible = true;
        }

        private void btnObrasSociales_Click(object sender, EventArgs e)
        {
            PintarBotones(btnObrasSociales);
            AbrirFormHijo(new FrmAltaObrasSociales());
            imgUsuarioMain.Visible = true;
        }

    }
}
