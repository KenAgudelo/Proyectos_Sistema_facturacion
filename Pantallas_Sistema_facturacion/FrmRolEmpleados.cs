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
    public partial class FrmRolEmpleados : Form
    {
        public FrmRolEmpleados()
        {
            InitializeComponent();
        }

        bool modoEdicion = false;
        int filaSeleccionada = -1;

        private void FrmRolEmpleados_Load(object sender, EventArgs e)
        {
            dgRolEmpleados.Rows.Add(
                    1,
                    $"user",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    );
            dgRolEmpleados.Rows.Add(
                    2,
                    $"admin",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    );
        }

        private void dgRolEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgRolEmpleados.Columns[e.ColumnIndex].HeaderText == "EDITAR")
            {
                filaSeleccionada = e.RowIndex;
                txtDetalles.Text = dgRolEmpleados.Rows[filaSeleccionada].Cells[2].Value.ToString();

                modoEdicion = true;
                btnAgregar.Text = "Guardar Cambios";
            }
            else if (dgRolEmpleados.Columns[e.ColumnIndex].HeaderText == "BORRAR")
            {
                if (MessageBox.Show("¿Seguro que deseas borrar este rol?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgRolEmpleados.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int contador = 3;
            if (txtDetalles.Text != "")
            {
                if (modoEdicion && filaSeleccionada >= 0)
                {
                    dgRolEmpleados.Rows[filaSeleccionada].Cells[2].Value = txtDetalles.Text;

                    modoEdicion = false;
                    filaSeleccionada = -1;
                    btnAgregar.Text = "Agregar";
                }
                else
                {
                    dgRolEmpleados.Rows.Add(contador.ToString(), txtDetalles.Text);
                    contador++;
                }


                txtDetalles.Clear();
                txtDetalles.Focus();
            }
            else
            {
                MessageBox.Show("Por favor completa todos los campos.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
