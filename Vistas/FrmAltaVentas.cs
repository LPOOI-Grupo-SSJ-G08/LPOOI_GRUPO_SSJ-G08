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
    public partial class FrmAltaVentas : Form {

        private DataTable Productos;
        private DataTable ProductosDetalles;

        public FrmAltaVentas() {
            InitializeComponent();
        }

        private void FrmAltaVentas_Load(object sender, EventArgs e) {
            cargarClientes();
            cargarProductos(); 
            setDateTimePicker();
            setValuesDefault(); 
            iniciarDetalleProductos();
        }

        private void iniciarDetalleProductos() {
            ProductosDetalles = new DataTable();
            ProductosDetalles.Clear();
            ProductosDetalles.Columns.Add("Código", typeof(string));
            ProductosDetalles.Columns.Add("Precio Unitario", typeof(decimal));
            ProductosDetalles.Columns.Add("Cantidad", typeof(decimal));
            ProductosDetalles.Columns.Add("Total", typeof(decimal));
            dgvProductosSeleccionados.DataSource = ProductosDetalles;
        }

        private void cargarClientes() {
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "Cli_DNI";
            DataTable dt = TrabajarVenta.getAllClientes();
            dt.Columns.Add("NombreCompleto", typeof(string), "Cli_Apellido + ', ' + Cli_Nombre");
            cmbClientes.DataSource = dt;

            label2.Text = cmbClientes.ValueMember;
        }

        private void setDateTimePicker() {
            dtpFechaVenta.MinDate = DateTime.Today;
            dtpFechaVenta.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpFechaVenta.Format = DateTimePickerFormat.Custom;
        }

        private void cargarProductos() {
            //cmbProductos.DisplayMember = "CodigoDescripcion";
            //cmbProductos.ValueMember = "Prod_Codigo";
            DataTable dt = TrabajarVenta.getAllProductos();
            Productos = dt;
            Productos.Columns["Prod_Codigo"].ColumnName = "Código";
            Productos.Columns["Prod_Categoria"].ColumnName = "Categoría";
            Productos.Columns["Prod_Descripcion"].ColumnName = "Descripción";
            Productos.Columns["Prod_Precio"].ColumnName = "Precio";
            dgvProductos.DataSource = Productos;
            //dt.Columns.Add("CodigoDescripcion", typeof(string), "Prod_codigo + ' - ' + Prod_Descripcion");
            //cmbProductos.DataSource = dt;
        }

        private void setValuesDefault() {
            nudProdCantidad.Value = 1;
            txtProdTotal.Text = "";
            txtProdPrecio.Text = "";
            txtProdCodigo.Text = "";
        }

        private void actualizarPrecio() {
            txtProdTotal.Text = (nudProdCantidad.Value * Convert.ToDecimal(txtProdPrecio.Text)).ToString();
            //Convert.ToDecimal(txtProdCantidad.Text)
        }

        private void agregarProducto() {
            DataRow detalle = ProductosDetalles.NewRow();
            detalle["Código"] = txtProdCodigo.Text;
            detalle["Precio Unitario"] = txtProdPrecio.Text;
            detalle["Cantidad"] = nudProdCantidad.Value;
            detalle["Total"] = txtProdTotal.Text;
            ProductosDetalles.Rows.Add(detalle);
            setValuesDefault();
        }

        private void cmbProductos_SelectionChangeCommitted(object sender, EventArgs e) {

            dgvProductosSeleccionados.DataSource = Productos;
            
            /*
            DataRow[] prods = Productos.Select("Prod_Codigo=" + cmbProductos.SelectedValue.ToString());
            label1.Text += "\n" + prods;
            DataRow p = prods[0];
            txtProdPrecio.Text = p["Prod_Precio"].ToString();
             * 
             * */
            DataRow[] dr = Productos.Select("OP001=Prod_Codigo");
            //txtProdCantidad.Text = dr[0]["Prod_Precio"].ToString();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e) {
            if(dgvProductos.SelectedRows.Count > 0) {
                int filaActual = dgvProductos.CurrentRow.Index;
                txtProdCodigo.Text = dgvProductos.Rows[filaActual].Cells["Código"].Value.ToString();
                txtProdPrecio.Text = dgvProductos.Rows[filaActual].Cells["Precio"].Value.ToString();
                actualizarPrecio();
            }
        }

        private void nudProdCantidad_ValueChanged(object sender, EventArgs e) {
            actualizarPrecio();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e) {
            agregarProducto();
        }

        private void brnGuardarVenta_Click(object sender, EventArgs e) {
            //label2.Text = ProductosDetalles.Rows.Count.ToString();
            if (VentaDetalleIsEmpty()) {
                
                Venta oVenta = new Venta();
                oVenta.Cli_DNI = cmbClientes.SelectedValue.ToString();
                oVenta.Ven_Fecha = dtpFechaVenta.Value;
                int ventaNro = TrabajarVenta.agregarVenta(oVenta);
                //label1.Text = Convert.ToString(ventaNro);
                //label2.Text = ProductosDetalles.Rows.Count.ToString();
                
                foreach (DataRow row in ProductosDetalles.Rows) {
                    
                    VentaDetalle oVentaDetalle = new VentaDetalle();
                    oVentaDetalle.Ven_Nro = ventaNro;
                    oVentaDetalle.Prod_Codigo = row[0].ToString();
                    oVentaDetalle.Det_Precio = Convert.ToDecimal(row[1].ToString());
                    oVentaDetalle.Det_Cantidad = Convert.ToDecimal(row[2].ToString());
                    oVentaDetalle.Det_Total = Convert.ToDecimal(row[3].ToString());

                    TrabajarVenta.agregarDetalleVenta(oVentaDetalle);
                }
            }
        }

        private bool VentaDetalleIsEmpty() {
            return ProductosDetalles.Rows.Count > 0;
        }
    }
}
