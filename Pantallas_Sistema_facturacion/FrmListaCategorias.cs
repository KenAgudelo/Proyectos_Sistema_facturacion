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
    public partial class FrmListaCategorias : Form
    {
        public FrmListaCategorias()
        {
            InitializeComponent();
        }

        private void FrmListaCategorias_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 20; i++)
            {
                dgCategorias.Rows.Add(
                    i,
                    $"Nombre{i}"
                    );
            }
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategorias.Columns[e.ColumnIndex].Name == "BORRAR")
            {
                int posActual = dgCategorias.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgCategorias[0, posActual].Value}");
                    dgCategorias.Rows.RemoveAt(posActual);
                }
            }
            if (dgCategorias.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                int posActual = dgCategorias.CurrentRow.Index;
                FrmEditarCategoria Categoria = new()
                {
                    IdCategoria = int.Parse(dgCategorias[0, posActual].Value.ToString())
                };
                Categoria.ShowDialog();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgCategorias.Rows)
            {
                if (fila.Cells["NOMBRE"].Value != null)
                {
                    string nombreCliente = fila.Cells["NOMBRE"].Value.ToString().ToLower();

                    if (nombreCliente.Contains(textoBuscado))
                    {
                        fila.Selected = true;
                        dgCategorias.FirstDisplayedScrollingRowIndex = fila.Index;
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Categoria no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCategoria Categoria = new()
            {
                IdCategoria = 0
            };
            Categoria.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
