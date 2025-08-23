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
    public partial class FrmAdminSeguridad : Form
    {
        public FrmAdminSeguridad()
        {
            InitializeComponent();
        }

        List<string> empleados = new List<string> { "Juan", "Ana", "Pedro" };
        bool modoEdicion = false;
        int filaSeleccionada = -1;

        private void FrmAdminSeguridad_Load(object sender, EventArgs e)
        {
            txtEmpleado.DataSource = empleados;

            dgUsuarios.Rows.Add(
                   1,
                   $"Juan",
                   "Lorem ipsum"
                   );
            dgUsuarios.Rows.Add(
                    2,
                    $"Ana",
                    "Lorem"
                    );
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgUsuarios.Columns[e.ColumnIndex].HeaderText == "EDITAR")
            {
                filaSeleccionada = e.RowIndex;
                txtEmpleado.Text = dgUsuarios.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txtUser.Text = dgUsuarios.Rows[filaSeleccionada].Cells[2].Value.ToString();

                modoEdicion = true;
                btnAgregar.Text = "Guardar Cambios";
            }
            else if (dgUsuarios.Columns[e.ColumnIndex].HeaderText == "BORRAR")
            {
                if (MessageBox.Show("¿Seguro que deseas borrar este rol?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgUsuarios.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int contador = 3;
            if (txtEmpleado.Text != "" && txtUser.Text != "")
            {
                if (modoEdicion && filaSeleccionada >= 0)
                {
                    dgUsuarios.Rows[filaSeleccionada].Cells[1].Value = txtEmpleado.Text;
                    dgUsuarios.Rows[filaSeleccionada].Cells[2].Value = txtUser.Text;

                    modoEdicion = false;
                    filaSeleccionada = -1;
                    btnAgregar.Text = "Agregar";
                }
                else
                {
                    dgUsuarios.Rows.Add(contador.ToString(), txtEmpleado.Text, txtUser.Text);
                    contador++;
                }

                txtUser.Clear();
                txtEmpleado.Focus();
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
