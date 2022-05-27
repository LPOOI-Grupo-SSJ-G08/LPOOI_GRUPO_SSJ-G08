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

        private void btnBuscarPorFechas_Click(object sender, EventArgs e) {
            DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicial.Text);
            DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.Text);
            DataSet ds = TrabajarProducto.list_productos_vendidos_rango_fechas(fechaInicial, fechaFinal);

            dgvProductos.DataSource = ds.Tables[0];
            dgvProductos.Refresh();
        }
    }
}
