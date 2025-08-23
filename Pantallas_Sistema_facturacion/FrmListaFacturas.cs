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
    public partial class FrmListaFacturas : Form
    {
        public FrmListaFacturas()
        {
            InitializeComponent();
        }

        private void FrmListaFacturas_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 30; i++)
            {
                dgFacturas.Rows.Add(
                    i,
                    $"{i * 4213}",
                    $"NOMBRE{i}",
                    $"EMPLEADO{i}",
                    $"{i * 2.4F}",
                    $"{i * 2.9 * 203}",
                    $"10000$",
                    $"{i}/{i}0/2009",
                    $"ESTADO{i}"
                    );
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarFactura form = new()
            {
                IdFactura = 0
            };
            form.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgFacturas.Rows)
            {
                if (fila.Cells["N_FACTURA"].Value != null)
                {
                    string nombre = fila.Cells["N_FACTURA"].Value.ToString().ToLower();

                    if (nombre.Contains(textoBuscado))
                    {
                        fila.Selected = true;
                        dgFacturas.FirstDisplayedScrollingRowIndex = fila.Index;
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Factura no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "BORRAR")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgFacturas[0, posActual].Value}");
                    dgFacturas.Rows.RemoveAt(posActual);
                }
            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                int posActual = dgFacturas.CurrentRow.Index;
                FrmEditarFactura Factura = new()
                {
                    IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString())
                };
                Factura.ShowDialog();
            }
        }
    }
}
