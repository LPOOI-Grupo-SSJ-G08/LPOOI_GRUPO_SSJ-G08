using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas {
    public partial class FrmConsultaProductos : Form {
        public FrmConsultaProductos() {
            InitializeComponent();
        }

        private void FrmConsultaProductos_Load(object sender, EventArgs e) {
            cargarComboClientes();
            cargarTodosProductosVendidos();
        }

        private void btnBuscarPorFechas_Click(object sender, EventArgs e) {
            DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicial.Text);
            DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.Text);
            DataSet ds = TrabajarProducto.list_productos_vendidos_rango_fechas(fechaInicial, fechaFinal);

            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e) {
            DataSet ds = TrabajarProducto.list_productos_vendidos_por_cliente(cmbClientes.SelectedValue.ToString());

            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
        }

        private void cargarComboClientes() {
            DataTable dtClientes = TrabajarCliente.list_clientes();
            dtClientes.Columns.Add("NombreCompleto", typeof(string), "Apellido + ', ' + Nombre");
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "DNI";
            cmbClientes.DataSource = dtClientes;
        }

        private void cargarTodosProductosVendidos() {
            DataSet ds = TrabajarProducto.list_todos_productos_vendidos();

            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e) {
            cargarTodosProductosVendidos();
        }
    }
}
