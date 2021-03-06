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
            //CargarClientes();
            CargarProductos(); 
            setDateTimePicker();
            setValuesDefaultVentaDetalle(); 
            IniciarDetalleProductos();
        }

        private void IniciarDetalleProductos() {
            ProductosDetalles = new DataTable();
            ProductosDetalles.Clear();
            ProductosDetalles.Columns.Add("Código", typeof(string));
            ProductosDetalles.Columns.Add("Precio Unitario", typeof(decimal));
            ProductosDetalles.Columns.Add("Cantidad", typeof(decimal));
            ProductosDetalles.Columns.Add("Total", typeof(decimal));
            dgvProductosSeleccionados.DataSource = ProductosDetalles;
        }

        /*
        private void CargarClientes() {
            cmbClientes.DisplayMember = "NombreCompleto";
            cmbClientes.ValueMember = "Cli_DNI";
            DataTable dt = TrabajarVenta.getAllClientes();
            dt.Columns.Add("NombreCompleto", typeof(string), "Cli_Apellido + ', ' + Cli_Nombre");
            cmbClientes.DataSource = dt;

            label2.Text = cmbClientes.ValueMember;
        }
         * */

        private void setDateTimePicker() {
            dtpFechaVenta.MinDate = DateTime.Today;
            dtpFechaVenta.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpFechaVenta.Format = DateTimePickerFormat.Custom;
        }

        private void CargarProductos() {
            //cmbProductos.DisplayMember = "CodigoDescripcion";
            //cmbProductos.ValueMember = "Prod_Codigo";
            DataTable dt = TrabajarProducto.list_productos();
            Productos = dt;
            /*
            Productos.Columns["Prod_Codigo"].ColumnName = "Código";
            Productos.Columns["Prod_Categoria"].ColumnName = "Categoría";
            Productos.Columns["Prod_Descripcion"].ColumnName = "Descripción";
            Productos.Columns["Prod_Precio"].ColumnName = "Precio";
             * */
            dgvProductos.DataSource = Productos;
            //dt.Columns.Add("CodigoDescripcion", typeof(string), "Prod_codigo + ' - ' + Prod_Descripcion");
            //cmbProductos.DataSource = dt;
        }

        private void setValuesDefaultVentaDetalle() {
            nudProdCantidad.Value = 1;
            txtProdTotal.Text = "";
            txtProdPrecio.Text = "";
            txtProdCodigo.Text = "";
        }

        private void setValuesDefault() {
            dtpFechaVenta.MinDate = DateTime.Today;
            IniciarDetalleProductos();
            txtClienteDNI.Text = "";
            txtClienteApellido.Text = "";
            txtClienteNombre.Text = "";
        }

        private void ActualizarPrecio() {
            txtProdTotal.Text = (nudProdCantidad.Value * Convert.ToDecimal(txtProdPrecio.Text)).ToString();
            //Convert.ToDecimal(txtProdCantidad.Text)
        }

        private void AgregarProducto() {
            if (!DetalleVentaEstaVacio()) {
                if (EstaEnTabla(txtProdCodigo.Text))
                {
                    ActualizarRow();
                }
                else
                {
                    DataRow detalle = ProductosDetalles.NewRow();
                    detalle["Código"] = txtProdCodigo.Text;
                    detalle["Precio Unitario"] = txtProdPrecio.Text;
                    detalle["Cantidad"] = nudProdCantidad.Value;
                    detalle["Total"] = txtProdTotal.Text;
                    ProductosDetalles.Rows.Add(detalle);
                }
                setValuesDefaultVentaDetalle();

                //Seleccionar el panel activo luego de añadir un producto
                tabCtlVenta.SelectedTab = tpgDetalleVenta;
            } else {
                MessageBox.Show("Seleccione un producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool EstaEnTabla(string pCodigo)
        {
            bool bFound = false;
            foreach (DataRow row in ProductosDetalles.Rows)
            {
                if (row["Código"].ToString() == pCodigo)
                    bFound = true;
            }
            return bFound;
        }

        private void ActualizarRow()
        {
            foreach (DataRow row in ProductosDetalles.Rows)
            {
                if (row["Código"].ToString() == txtProdCodigo.Text)
                {
                    decimal dCantidad = Convert.ToDecimal(row["Cantidad"].ToString()) + nudProdCantidad.Value;
                    row["Cantidad"] = dCantidad;
                    decimal dTotal = Convert.ToDecimal(row["Total"].ToString()) + Convert.ToDecimal(txtProdTotal.Text);
                    row["Total"] = dTotal.ToString();
                }
            }
        }

        private bool DetalleVentaEstaVacio() {
            if (txtProdCodigo.Text.Length > 0 && txtProdPrecio.Text.Length > 0 && txtProdTotal.Text.Length > 0) {
                return false;
            } else {
                return true;
            }
        }

        private void GuardarVenta() {
            try {
                Venta oVenta = new Venta();
                //oVenta.Cli_DNI = cmbClientes.SelectedValue.ToString();
                oVenta.Cli_DNI = txtClienteDNI.Text;
                oVenta.Ven_Fecha = dtpFechaVenta.Value;

                //Guardo la Venta realizada y obtengo el ID de la misma
                int ventaNro = TrabajarVenta.agregarVenta(oVenta);

                //Recorre el DataTable con los productos seleccionados y carga cada uno en la BD
                foreach (DataRow row in ProductosDetalles.Rows) {
                    VentaDetalle oVentaDetalle = new VentaDetalle();
                    oVentaDetalle.Ven_Nro = ventaNro;
                    oVentaDetalle.Prod_Codigo = row[0].ToString();
                    oVentaDetalle.Det_Precio = Convert.ToDecimal(row[1].ToString());
                    oVentaDetalle.Det_Cantidad = Convert.ToDecimal(row[2].ToString());
                    oVentaDetalle.Det_Total = Convert.ToDecimal(row[3].ToString());

                    TrabajarVenta.agregarDetalleVenta(oVentaDetalle);
                }

                MessageBox.Show("Venta guardada exitosamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception e) {
                MessageBox.Show("Exception: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ProductosSeleccionadosEstaVacio() {
            return ProductosDetalles.Rows.Count > 0;
        }

        #region Componentes

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
                txtProdCodigo.Text = dgvProductos.Rows[filaActual].Cells["Codigo"].Value.ToString();
                txtProdPrecio.Text = dgvProductos.Rows[filaActual].Cells["Precio"].Value.ToString();
                ActualizarPrecio();
            }
        }

        private void nudProdCantidad_ValueChanged(object sender, EventArgs e) {
            ActualizarPrecio();
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e) {
            AgregarProducto();
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e) {
            //Verifico que hayan productos cargados en el detalle
            if (ProductosSeleccionadosEstaVacio()) {
                if (txtClienteDNI.Text.Length > 0) {
                    var dialogResult = MessageBox.Show("¿Guardar venta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes) {
                        GuardarVenta();
                        setValuesDefault();
                    }
                } else {
                    MessageBox.Show("Debe seleccionar un cliente", "Seleccionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("No se seleccionó ningún producto.\nDebe agregar al menos uno.", "¡Atención! Sin Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarNuevoProducto_MouseHover(object sender, EventArgs e) {
            tltAgregarProducto.SetToolTip(btnAgregarNuevoProducto, "Añadir producto");
        }

        private void btnAgregarNuevoProducto_Click(object sender, EventArgs e) {
            tabCtlVenta.SelectedTab = tpgAgregarProducto;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            IniciarDetalleProductos();
        }

        #endregion

        private void btnAgregarDetalle_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#575B58");
        }

        private void btnAgregarDetalle_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = ColorTranslator.FromHtml("#1B998B");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                FrmBuscarCliente buscarCliente = new FrmBuscarCliente();
                AddOwnedForm(buscarCliente);
                buscarCliente.Show();
            }

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e) {
            if (txtBusquedaProducto.Text.Length > 0) {
                string text = Convert.ToString(txtBusquedaProducto.Text);
                dgvProductos.DataSource = TrabajarProducto.searchProductosCategoriaDescripcion(text);
            }
        }

        private void btnLimpiarFiltrosBuscar_Click(object sender, EventArgs e) {
            CargarProductos();
            txtBusquedaProducto.Text = "";
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e) {
            FrmListadoVentas frm = new FrmListadoVentas();
            frm.Show();
        }
    }
}
