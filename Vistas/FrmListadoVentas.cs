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
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getAllVentas();
            CargarComboClientes();
            lblRegistros.Visible = false;
            txtRegistros.Visible = false;
            txtRegistros.Enabled = false;
        }

        private void CargarComboClientes()
        {
            DataTable dt = TrabajarCliente.list_clientes();
            dt.Columns.Add("NombreCompleto", typeof(string), "Apellido + ', '+ Nombre");

            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "DNI";
            cmbClientes.DataSource = dt;
        }

        private void btnListarVentasPorCliente_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getVentasByCliente(cmbClientes.SelectedValue.ToString());
            lblRegistros.Visible = true;
            txtRegistros.Visible = true;
            txtRegistros.Text = TrabajarVenta.getCantidadVentasByCliente(cmbClientes.SelectedValue.ToString()).ToString();
        }

        private void btnListarVentasPorFechas_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getVentasByFechas(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            lblRegistros.Visible = true;
            txtRegistros.Visible = true;
            txtRegistros.Text = TrabajarVenta.getCantidadVentasByFecha(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59)).ToString();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            lblRegistros.Visible = false;
            txtRegistros.Visible = false;
            FrmListadoVentas_Load(null, null);
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este elemento?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                TrabajarVenta.delete_venta(Convert.ToInt32(dgvVentas.CurrentRow.Cells["Ven_Nro"].Value));
                FrmListadoVentas_Load(null, null);

                MessageBox.Show("La venta ha eliminada correctamente");
            }
        }

    }
}
