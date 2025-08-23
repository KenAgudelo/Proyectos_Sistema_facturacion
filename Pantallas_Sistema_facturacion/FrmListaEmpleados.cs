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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 20; i++)
            {
                dgEmpleados.Rows.Add(
                    i,
                    $"Nombre{i}",
                    $"{i * 12345}",
                    $"{i + 12831 * 21}",
                    $"{i + 12831 * 1231}",
                    $"test{i}@gmail.com",
                    $"User",
                    DateTime.Today.AddDays(-7),
                    DateTime.Today,
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    );
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgEmpleados.Rows)
            {
                if (fila.Cells["NOMBRE"].Value != null)
                {
                    string nombreCliente = fila.Cells["NOMBRE"].Value.ToString().ToLower();

                    if (nombreCliente.Contains(textoBuscado))
                    {
                        fila.Selected = true;
                        dgEmpleados.FirstDisplayedScrollingRowIndex = fila.Index;
                        encontrado = true;
                        break;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Empleado no encontrado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado form = new()
            {
                IdEmpleado = 0
            };
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "BORRAR")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgEmpleados[0, posActual].Value}");
                    dgEmpleados.Rows.RemoveAt(posActual);
                }
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "EDITAR")
            {
                int posActual = dgEmpleados.CurrentRow.Index;
                FrmEditarEmpleado Empleado = new()
                {
                    IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString())
                };
                Empleado.ShowDialog();
            }
        }

    }
}
