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
    public partial class FrmBuscarCliente : Form
    {
        public FrmBuscarCliente()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            loadClientes();
            cargarCombosObrasSociales();
        }

        private void loadClientes()
        {
            dgvClientes.DataSource = TrabajarCliente.list_clientes();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                realizarBusqueda();
            }
        }

        private void realizarBusqueda()
        {
            if (txtBusqueda.Text != String.Empty) {
                int order = Convert.ToInt32(optA.Checked);
                DataTable dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
                dgvClientes.DataSource = dt;
                contarRegistrosDevueltos(dt);
            } else {
                loadClientes();
            }
        }
       

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmAltaVentas frmAltaVentas = Owner as FrmAltaVentas;


            if (dgvClientes.SelectedRows.Count != 0)
            {
                //frmAltaVentas.cmbClientes.SelectedValue = dgvClientes.CurrentRow.Cells[0].Value;
                frmAltaVentas.txtClienteDNI.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                frmAltaVentas.txtClienteNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                frmAltaVentas.txtClienteApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un registro de la tabla");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            realizarBusqueda();
        }

        private void contarRegistrosDevueltos(DataTable dt) {
            lblCountRegistros.Text = Convert.ToString(dt.Rows.Count);
        }

        private void optA_CheckedChanged(object sender, EventArgs e) {
            DataTable dt;

            if (txtBusqueda.Text.Length == 0) {
                dt = TrabajarCliente.list_cliente_por_apellido('1'); // 0 para listar en ascendente 
            } else {
                int order = Convert.ToInt32(optA.Checked);
                dt = TrabajarCliente.search_clientes_order(txtBusqueda.Text, order);
            }

            dgvClientes.DataSource = dt;
            dgvClientes.Refresh();
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

            dgvClientes.DataSource = dt;
            dgvClientes.Refresh();
            contarRegistrosDevueltos(dt);
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtBusqueda.Clear();
            loadClientes();
        }

        private void cargarCombosObrasSociales() {
            cmbObraSocialConsulta.DisplayMember = "CUITRazonSocial";
            cmbObraSocialConsulta.ValueMember = "OS_CUIT";
            cmbObraSocialConsulta.DataSource = getTablaObrasSocial();
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
            dgvClientes.DataSource = dt;
            contarRegistrosDevueltos(dt);
        }
    }
}
