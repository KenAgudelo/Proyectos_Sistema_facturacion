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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 20; i++)
            {
                dgProductos.Rows.Add(
                    i,
                    $"Nombre{i}",
                    $"{i * 12345}",
                    $"{i + 12831 * 21}",
                    $"{i + 12831 * 1231}",
                    $"{i + 12 * 3}", $"Categoria{1}",
                    "image_url",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    );
            }
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "BORRAR")
            {
                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgProductos[0, posActual].Value}");
                    dgProductos.Rows.RemoveAt(posActual);
                }
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                int posActual = dgProductos.CurrentRow.Index;
                FrmEditarProducto Producto = new()
                {
                    IdProducto = int.Parse(dgProductos[0, posActual].Value.ToString())
                };
                Producto.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgProductos.Rows)
            {
                if (fila.Cells["NOMBRE"].Value != null)
                {
                    string nombreCliente = fila.Cells["NOMBRE"].Value.ToString().ToLower();

                    if (nombreCliente.Contains(textoBuscado))
                    {
                        fila.Selected = true;
                        dgProductos.FirstDisplayedScrollingRowIndex = fila.Index;
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Producto no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarProducto form = new()
            {
                IdProducto = 0
            };
            form.ShowDialog();
        }
    }
}
