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
            DataTable dt = TrabajarVenta.getAllVentas();
            dgvVentas.DataSource = dt;
            contarRegistrosDevueltos(dt);

            CargarComboClientes();
        }

        private void CargarComboClientes()
        {
            DataTable dt = TrabajarCliente.list_clientes();
            dt.Columns.Add("NombreCompleto", typeof(string), "Apellido + ', '+ Nombre");

            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "DNI";
            cmbClientes.DataSource = dt;
        }
        /*
        private void btnListarVentasPorCliente_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = TrabajarVenta.getVentasByCliente(cmbClientes.SelectedValue.ToString());
            lblRegistros.Visible = true;
            txtRegistros.Visible = true;
            txtRegistros.Text = TrabajarVenta.getCantidadVentasByCliente(cmbClientes.SelectedValue.ToString()).ToString();
        }
         * */

        private void btnListarVentasPorFechas_Click(object sender, EventArgs e)
        {
            DataTable dt = TrabajarVenta.getVentasByFechas(dtpFechaInicio.Value.Date, dtpFechaFin.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59));
            dgvVentas.DataSource = dt;
            contarRegistrosDevueltos(dt);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            FrmListadoVentas_Load(null, null);
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                TrabajarVenta.delete_venta(Convert.ToInt32(dgvVentas.CurrentRow.Cells["Nro. Venta"].Value));
                FrmListadoVentas_Load(null, null);

                MessageBox.Show("La venta ha eliminada correctamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se elimino la venta", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e) {
            DataTable dt =  TrabajarVenta.getVentasByCliente(cmbClientes.SelectedValue.ToString());
            dgvVentas.DataSource = dt;
            contarRegistrosDevueltos(dt);
        }

        private void contarRegistrosDevueltos(DataTable dt) {
            lblCountRegistros.Text = Convert.ToString(dt.Rows.Count);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                int resp = Util.PDFWriter((DataTable)dgvVentas.DataSource, savefiledialoge.FileName, "VENTAS");
                if (resp == 0)
                    MessageBox.Show("¡Archivo creado correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al crear el archivo");
            }
        }
    }
}
