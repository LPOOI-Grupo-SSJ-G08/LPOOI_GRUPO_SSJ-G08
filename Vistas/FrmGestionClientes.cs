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
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e) {
            load_clientes();
            HabilitarAcciones(false);
            ttipBusqueda.SetToolTip(txtBusqueda, "Buscar por Apellido o Dirección");
            cargarCombosObrasSociales();
        }

        private void load_clientes() {
            int order = Convert.ToInt32(optA.Checked);
            DataTable dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
            dgwClientes.DataSource = dt;
            contarRegistrosDevueltos(dt);
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
                    oCliente.Os_CUIT = cmbObraSocial.SelectedValue.ToString();
                    //oCliente.Os_CUIT = txtCUIT.Text;
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
                    oCliente.Os_CUIT = cmbObraSocial.SelectedValue.ToString();
                    //oCliente.Os_CUIT = txtCUIT.Text;
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

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtBusqueda.Clear();
            load_clientes();
        }

        private void dgwClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDNI.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                //txtCUIT.Text = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                cmbObraSocial.SelectedValue = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
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
            //txtCUIT.Clear();
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
            /*
            if (!txtCUIT.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtCUIT.Text))
            {
                lblValidCUIT.Show();
                bErrorFound = true;
            }
            */
            if (!txtNroCarnet.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtNroCarnet.Text))
            {
                lblValidNroCarnet.Show();
                bErrorFound = true;
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                realizarBusqueda();
            }
        }

        private void realizarBusqueda() {
            if (txtBusqueda.Text != String.Empty) {
                int order = Convert.ToInt32(optA.Checked);
                DataTable dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
                dgwClientes.DataSource = dt;
                contarRegistrosDevueltos(dt);
            } else {
                load_clientes();
            }
        }

        private void optA_CheckedChanged(object sender, EventArgs e) {
            DataTable dt;

            if (txtBusqueda.Text.Length == 0) {
                dt = TrabajarCliente.list_cliente_por_apellido('1'); // 0 para listar en ascendente 
            } else {
                int order = Convert.ToInt32(optA.Checked);
                dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
            }
             
            dgwClientes.DataSource = dt;
            dgwClientes.Refresh();
            contarRegistrosDevueltos(dt);
        }

        private void optZ_CheckedChanged(object sender, EventArgs e) {
            DataTable dt;

            if (txtBusqueda.Text.Length == 0) {
                dt = TrabajarCliente.list_cliente_por_apellido('0'); //1 para listar en descendente
            } else {
                int order = Convert.ToInt32(optA.Checked);
                dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
            }

            dgwClientes.DataSource = dt;
            dgwClientes.Refresh();
            contarRegistrosDevueltos(dt);
        }

        private void cargarCombosObrasSociales() {
            cmbObraSocial.DisplayMember = cmbObraSocialConsulta.DisplayMember = "CUITRazonSocial";
            cmbObraSocial.ValueMember = cmbObraSocialConsulta.ValueMember = "OS_CUIT";
            cmbObraSocial.DataSource = getTablaObrasSocial();
            cmbObraSocialConsulta.DataSource = getTablaObrasSocial();
            cmbObraSocial.Refresh();
            cmbObraSocialConsulta.Refresh();
        }

        private DataTable getTablaObrasSocial() {
            DataTable dt = TrabajarObraSocial.showAllObrasSociales();
            dt.Columns.Add("CUITRazonSocial", typeof(string), "OS_CUIT + ' - ' + OS_RazonSocial");
            return dt;
        }

        private void cmbObraSocialConsulta_SelectionChangeCommitted(object sender, EventArgs e) {
            txtBusqueda.Text = "";
            int order = Convert.ToInt32(optA.Checked);
            string cuit = cmbObraSocialConsulta.SelectedValue.ToString();
            DataTable dt = TrabajarCliente.search_clientes_cuit_obra_social(cuit, order);
            dgwClientes.DataSource = dt;
            contarRegistrosDevueltos(dt);
        }

        /*
        private void cambiarLabelsMostrarRegistros() {
            lblMostrar1.Visible = !lblMostrar1.Visible;
            lblMostrar2.Visible = !lblMostrar2.Visible;
            lblCountRegistros.Visible = !lblCountRegistros.Visible;
        }

        private void cambiarMostrarRegistros() {
            if (lblCountRegistros.Visible) {
                cambiarLabelsMostrarRegistros();
            }
        }
         * */

        private void contarRegistrosDevueltos(DataTable dt) {
            lblCountRegistros.Text = Convert.ToString(dt.Rows.Count);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string nombrePdf = folderBrowserDialog1.SelectedPath + "\\Clientes_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + DateTime.Now.ToString("HHmmss");
                int resp = Util.PDFWriter((DataTable)dgwClientes.DataSource, nombrePdf);
                if (resp == 0)
                    MessageBox.Show("¡Archivo creado correctamente!");
                else
                    MessageBox.Show("Error al crear el archivo");
            }
        }
    }
}
