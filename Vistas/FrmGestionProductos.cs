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
    public partial class FrmGestionProductos : Form
    {
        public FrmGestionProductos()
        {
            InitializeComponent();
        }

        private void FrmAltaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            HabilitarAcciones(false);
        }

        private void CargarProductos()
        {
            DataTable dt = TrabajarProducto.list_productos();
            dgvProductos.DataSource = dt;
            contarRegistrosDevueltos(dt);
        }

        private void HabilitarAcciones(bool b)
        {
            btnAgregar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = b;
            CambiarColor(btnAgregar);
            CambiarColor(btnGuardar);
            CambiarColor(btnEliminar);
        }

        private void CambiarColor(Button btn)
        {
            if (!btn.Enabled)
            {
                btn.BackColor = ColorTranslator.FromHtml("#575B58");
            }
            else
            {
                if (!(btn.Name == "btnEliminar"))
                {
                    btn.BackColor = ColorTranslator.FromHtml("#1B998B");
                }
                else
                {
                    btn.BackColor = Color.Crimson;
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar este elemento?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Producto oProducto = new Producto();
                    oProducto.Prod_Categoria = txtCategoria.Text;
                    oProducto.Prod_Descripcion = txtDescripcion.Text;
                    oProducto.Prod_Precio = Convert.ToDecimal(txtPrecio.Text);

                    TrabajarProducto.insert_producto(oProducto);

                    ClearTextBoxs();
                    CargarProductos();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearTextBoxs();
            HideErrorLabels();
            HabilitarAcciones(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HideErrorLabels();
            bool bErrorFound = false;
            ValidateTextBoxs(ref bErrorFound);

            if (!bErrorFound)
            {
                DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?",
                        "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogoResult == DialogResult.Yes)
                {
                    Producto oProducto = new Producto();
                    oProducto.Prod_Codigo = txtCodigo.Text;
                    oProducto.Prod_Categoria = txtCategoria.Text;
                    oProducto.Prod_Descripcion = txtDescripcion.Text;
                    oProducto.Prod_Precio = Convert.ToDecimal(txtPrecio.Text);

                    TrabajarProducto.update_producto(oProducto);

                    ClearTextBoxs();
                    HabilitarAcciones(false);
                    CargarProductos();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogoResult = MessageBox.Show("¿Está seguro de que desea eliminar este elemento?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogoResult == DialogResult.Yes)
            {
                TrabajarProducto.delete_producto(Convert.ToInt32(dgvProductos.CurrentRow.Cells["Codigo"].Value));
                ClearTextBoxs();
                HabilitarAcciones(false);
                CargarProductos();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                txtCodigo.Text = dgvProductos.CurrentRow.Cells["Codigo"].Value.ToString();
                txtCategoria.Text = dgvProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarAcciones(true);
            }
        }

        public void HideErrorLabels()
        {
            lblValidCategoria.Hide();
            lblValidDescripcion.Hide();
            lblValidPrecio.Hide();
        }

        private void ClearTextBoxs()
        {
            txtCodigo.Clear();
            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void ValidateTextBoxs(ref bool bErrorFound)
        {
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                lblValidCategoria.Show();
                bErrorFound = true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                lblValidDescripcion.Show();
                bErrorFound = true;
            }
            if (!txtPrecio.Text.All(char.IsDigit) || string.IsNullOrEmpty(txtPrecio.Text))            
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrecio.Text, "^[0-9]+(\\,[0-9]{1,2})?$")) {
                    lblValidPrecio.Show();
                    bErrorFound = true;
                } 
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e) {
            FrmConsultaProductos frm = new FrmConsultaProductos();
            frm.Show();
        }

        private void optDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = TrabajarProducto.list_productos_por('0'); // 0 para listar por descripcion
            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
            contarRegistrosDevueltos(ds.Tables[0]);
        }

        private void optCategoria_CheckedChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = TrabajarProducto.list_productos_por('1'); //1 para listar por categoria
            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
            contarRegistrosDevueltos(ds.Tables[0]);
        }

        private void optNinguno_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
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
                int resp = Util.PDFWriter((DataTable)dgvProductos.DataSource, savefiledialoge.FileName, "PRODUCTOS");
                if (resp == 0)
                    MessageBox.Show("¡Archivo creado correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al crear el archivo");
            }
        }
        
    }
}
