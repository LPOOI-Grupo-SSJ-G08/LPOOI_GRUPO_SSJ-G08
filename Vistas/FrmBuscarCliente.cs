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
            if (txtBusqueda.Text != "")
            {
                dgvClientes.DataSource = TrabajarCliente.search_clientes(txtBusqueda.Text);
            }
            else
            {
                loadClientes();
            }
        }
        
        private void optDES_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.Sort(dgvClientes.Columns["Apellido"], ListSortDirection.Descending);
        }

        private void optASC_CheckedChanged(object sender, EventArgs e)
        {
            dgvClientes.Sort(dgvClientes.Columns["Apellido"], ListSortDirection.Ascending);
        }

        private void optNinguno_CheckedChanged(object sender, EventArgs e)
        {
            realizarBusqueda();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            loadClientes();
        }

    }
}
