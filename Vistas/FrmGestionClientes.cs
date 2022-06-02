﻿using System;
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
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            load_clientes();
            HabilitarAcciones(false);
            ttipBusqueda.SetToolTip(txtBusqueda, "Buscar por Apellido o Dirección");
        }

        private void load_clientes()
        {
            dgwClientes.DataSource = TrabajarCliente.list_clientes();
        }

        private void HabilitarAcciones(bool b)
        {
            btnAgregar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = b;
            txtDNI.Enabled = !b;
            cambiarColor(btnAgregar);
            cambiarColor(btnGuardar);
            cambiarColor(btnEliminar);
        }

        private void cambiarColor(Button btn)
        {

            if (btn.Enabled==false)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea agregar este elemento?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Os_CUIT = txtCUIT.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    TrabajarCliente.insert_cliente(oCliente);

                    ClearTextBoxs();
                    load_clientes();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            HabilitarAcciones(false);
            HideErrorLabels();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Esta seguro de que desea guardar los cambios?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Cliente oCliente = new Cliente();
                    oCliente.Cli_DNI = txtDNI.Text;
                    oCliente.Cli_Nombre = txtNombre.Text;
                    oCliente.Cli_Apellido = txtApellido.Text;
                    oCliente.Cli_Direccion = txtDireccion.Text;
                    oCliente.Os_CUIT = txtCUIT.Text;
                    oCliente.Cli_NroCarnet = txtNroCarnet.Text;

                    TrabajarCliente.update_cliente(oCliente);

                    load_clientes();
                    HabilitarAcciones(false);
                    ClearTextBoxs();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResult = MessageBox.Show("¿Esta seguro de que desea eliminar este elemento?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogoResult == DialogResult.Yes)
            {
                TrabajarCliente.delete_cliente(txtDNI.Text);

                load_clientes();
                HabilitarAcciones(false);
                ClearTextBoxs();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            realizarBusqueda();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            load_clientes();
            txtBusqueda.Clear();
        }

        private void dgwClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCUIT.Text = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                txtNroCarnet.Text = dgwClientes.CurrentRow.Cells["Nro de Carnet"].Value.ToString();

                HabilitarAcciones(true);
            }
        }

        public void HideErrorLabels()
        {
            lblValidDNI.Hide();
            lblValidApellido.Hide();
            lblValidNombre.Hide();
            lblValidDireccion.Hide();
            lblValidCUIT.Hide();
            lblValidNroCarnet.Hide();
        }

        private void ClearTextBoxs()
        {
            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCUIT.Clear();
            txtNroCarnet.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (txtDNI.Text.Length != 8)
            {
                lblValidDNI.Show();
                bErrorFound = true;
            }
            if (txtApellido.Text.Length < 3)
            {
                lblValidApellido.Show();
                bErrorFound = true;
            }
            if (txtNombre.Text.Length < 3)
            {
                lblValidNombre.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                lblValidDireccion.Show();
                bErrorFound = true;
            }
            if (!txtCUIT.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtCUIT.Text))
            {
                lblValidCUIT.Show();
                bErrorFound = true;
            }
            if (!txtNroCarnet.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtNroCarnet.Text))
            {
                lblValidNroCarnet.Show();
                bErrorFound = true;
            }
        }

   /*     private void cmbOrdenCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds;
            switch(cmbOrdenCliente.Text){
                case "Ninguno":
             
                    dgwClientes.DataSource = TrabajarCliente.list_clientes();
                    break;

                case "A-Z":
                    ds = TrabajarCliente.list_cliente_por_apellido('1'); //1 para listar en ascendente
                    dgwClientes.DataSource = ds.Tables[0] ;
                    dgwClientes.Refresh();
                    break;
                case "Z-A":
                    ds = TrabajarCliente.list_cliente_por_apellido('0'); // 0 para listar en descendente
                    dgwClientes.DataSource = ds.Tables[0];
                    dgwClientes.Refresh();
                    break;
            }
        }
        */
        private void chxOrdenar1_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            if (chkOrdenar1.Checked)
            {
                chkOrdenar2.Enabled = false;
                ds = TrabajarCliente.list_cliente_por_apellido('1'); //1 para listar en ascendente
                dgwClientes.DataSource = ds.Tables[0];
                dgwClientes.Refresh();
            }
            else
            {
                chkOrdenar2.Enabled = true;
                dgwClientes.DataSource = TrabajarCliente.list_clientes();
            }
        }

        private void chxOrdenar2_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            if (chkOrdenar2.Checked)
            {
                chkOrdenar1.Enabled = false;
                ds = TrabajarCliente.list_cliente_por_apellido('0'); // 0 para listar en descendente
                dgwClientes.DataSource = ds.Tables[0];
                dgwClientes.Refresh();
            }
            else
            {
                chkOrdenar1.Enabled = true;
                dgwClientes.DataSource = TrabajarCliente.list_clientes();
            }

        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                realizarBusqueda();
            }
        }

        private void realizarBusqueda() {
            if (txtBusqueda.Text != String.Empty) {
                dgwClientes.DataSource = TrabajarCliente.search_clientes(txtBusqueda.Text);
            } else {
                load_clientes();
            }
        }

    }
}
