using Microsoft.Data.SqlClient;
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
            CargarClientes();
            //llenar_grid();

   
        }

        //public void llenar_grid()
        //{
        //    for (int i = 1; i < 10; i++)
        //    {
        //        dgClientes.Rows.Add(i, $"Nombre{i} Apellido{i} Apellido{i}", $"{i * 12345}", $"{i + 12831 * 21}");
        //    }

        //}

        private void CargarClientes(string nombreCliente = null)
        {
            string query = @"SELECT IdCliente AS ID, StrNombre AS Cliente, NumDocumento AS Documento,
                     StrDireccion AS Dirección, StrTelefono AS Teléfono, StrEmail AS Email
                     FROM TBLCLIENTES";

            if (!string.IsNullOrEmpty(nombreCliente))
            {
                query += " WHERE StrNombre LIKE @nombre";
            }

            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrEmpty(nombreCliente))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreCliente + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgClientes.DataSource = dt;
            }

                if (!dgClientes.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "EDITAR";
                btnEditar.Text = "Editar";
                btnEditar.Name = "btnEditar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgClientes.Columns.Add(btnEditar);
            }

            if (!dgClientes.Columns.Contains("btnBorrar"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.HeaderText = "BORRAR";
                btnBorrar.Text = "Borrar";
                btnBorrar.Name = "btnBorrar";
                btnBorrar.UseColumnTextForButtonValue = true;
                dgClientes.Columns.Add(btnBorrar);
            }
        }

        private void EliminarCliente(int id)
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                string query = "DELETE FROM TBLCLIENTES WHERE IdCliente=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCliente form = new(0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarClientes();
            }
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int idCliente = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["ID"].Value);
                    string nombre = dgClientes.Rows[e.RowIndex].Cells["Cliente"].Value?.ToString() ?? string.Empty;
                    string documento = dgClientes.Rows[e.RowIndex].Cells["Documento"].Value?.ToString() ?? string.Empty;
                    string direccion = dgClientes.Rows[e.RowIndex].Cells["Dirección"].Value?.ToString() ?? string.Empty;
                    string telefono = dgClientes.Rows[e.RowIndex].Cells["Teléfono"].Value?.ToString() ?? string.Empty;
                    string email = dgClientes.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;

                    FrmEditarCliente frm = new FrmEditarCliente(idCliente, nombre, documento, direccion, telefono, email);

                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarClientes();
                    }
                }

                if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
                {
                    int idCliente = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas borrar este cliente?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        EliminarCliente(idCliente);
                        CargarClientes();
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            //if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar")
            //{
            //    int posActual = dgClientes.CurrentRow.Index;
            //    if (MessageBox.Show("¿Seguro de borrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        MessageBox.Show($"BORRANDO  índice: {e.RowIndex}  ID: {dgClientes[0, posActual].Value}");
            //        dgClientes.Rows.RemoveAt(posActual);
            //    }
            //}
            //if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            //{
            //    int posActual = dgClientes.CurrentRow.Index;
            //    FrmEditarCliente Cliente = new()
            //    {
            //        IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString())
            //    };
            //    Cliente.ShowDialog();
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text.Trim());
        }
    }
}
