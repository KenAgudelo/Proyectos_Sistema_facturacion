using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturacion
{
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgClientes.Rows.Add(i, $"Nombre{i} Apellido{i} Apellido{i}", $"{i * 12345}", $"{i + 12831 * 21}");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCliente form = new()
            {
                IdCliente = 0
            };
            form.ShowDialog();

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name == "BORRAR")
            {
                int posActual = dgClientes.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgClientes[0, posActual].Value}");
                    dgClientes.Rows.RemoveAt(posActual);
                }
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                int posActual = dgClientes.CurrentRow.Index;
                FrmEditarCliente Cliente = new()
                {
                    IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString())
                };
                Cliente.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgClientes.Rows)
            {
                if (fila.Cells["CLIENTE"].Value != null)
                {
                    string nombreCliente = fila.Cells["CLIENTE"].Value.ToString().ToLower();

                    if (nombreCliente.Contains(textoBuscado))
                    {
                        fila.Selected = true;
                        dgClientes.FirstDisplayedScrollingRowIndex = fila.Index; 
                        encontrado = true;
                        break; 
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Cliente no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
