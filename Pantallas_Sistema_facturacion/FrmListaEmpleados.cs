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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            Cargar_Empleados();
           // llenar_grid();
        }

        //public void llenar_grid()
        //{
        //    for (int i = 1; i < 20; i++)
        //    {
        //        dgEmpleados.Rows.Add(
        //            i,
        //            $"Nombre{i}",
        //            $"{i * 12345}",
        //            $"{i + 12831 * 21}",
        //            $"{i + 12831 * 1231}",
        //            $"test{i}@gmail.com",
        //            $"User",
        //            DateTime.Today.AddDays(-7),
        //            DateTime.Today,
        //            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        //            );
        //    }
        //}


        private void Cargar_Empleados(string nombre = null)
        {
            string query = @"SELECT IdEmpleado AS ID, StrNombre AS Empleado, NumDocumento AS Documento,
                     StrDireccion AS Dirección, StrTelefono AS Teléfono, StrEmail AS Email,
                     IdRolEmpleado AS ID_Rol, DtmIngreso AS Fecha_Ingreso, DtmRetiro AS Fecha_Retiro, strDatosAdicionales as Datos
                     FROM TBLEMPLEADO";

            if (!string.IsNullOrEmpty(nombre))
            {
                query += " WHERE StrNombre LIKE @nombre";
            }

            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrEmpty(nombre))
                {
                    da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgEmpleados.DataSource = dt;
            }

            if (!dgEmpleados.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "EDITAR";
                btnEditar.Text = "Editar";
                btnEditar.Name = "btnEditar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgEmpleados.Columns.Add(btnEditar);
            }

            if (!dgEmpleados.Columns.Contains("btnBorrar"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.HeaderText = "BORRAR";
                btnBorrar.Text = "Borrar";
                btnBorrar.Name = "btnBorrar";
                btnBorrar.UseColumnTextForButtonValue = true;
                dgEmpleados.Columns.Add(btnBorrar);
            }


        }

        private void EliminarCliente(int id)
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                string query = "DELETE FROM TBLEMPLEADO WHERE IdEmpleado=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("No se puede eliminar este empleado porque tiene registros asociados en la tabla de seguridad. Debe eliminar primero los registros relacionados.", "Error de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Ocurrió un error de base de datos: {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar_Empleados(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleado form = new(0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Cargar_Empleados();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int id = Convert.ToInt32(dgEmpleados.Rows[e.RowIndex].Cells["ID"].Value);
                    string nombre = dgEmpleados.Rows[e.RowIndex].Cells["Empleado"].Value?.ToString() ?? string.Empty;
                    string documento = dgEmpleados.Rows[e.RowIndex].Cells["Documento"].Value?.ToString() ?? string.Empty;
                    string direccion = dgEmpleados.Rows[e.RowIndex].Cells["Dirección"].Value?.ToString() ?? string.Empty;
                    string telefono = dgEmpleados.Rows[e.RowIndex].Cells["Teléfono"].Value?.ToString() ?? string.Empty;
                    string email = dgEmpleados.Rows[e.RowIndex].Cells["Email"].Value?.ToString() ?? string.Empty;
                    string id_rol = dgEmpleados.Rows[e.RowIndex].Cells["Id_Rol"].Value?.ToString() ?? string.Empty;
                    DateTime fecha_ingreso = Convert.ToDateTime(dgEmpleados.Rows[e.RowIndex].Cells["Fecha_Ingreso"].Value);
                    DateTime fecha_retiro = Convert.ToDateTime(dgEmpleados.Rows[e.RowIndex].Cells["Fecha_Retiro"].Value);
                    string datos = dgEmpleados.Rows[e.RowIndex].Cells["Datos"].Value?.ToString() ?? string.Empty;

                    FrmEditarEmpleado frm = new FrmEditarEmpleado(id, nombre, documento, direccion, telefono, email, id_rol,fecha_ingreso, fecha_retiro, datos);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Cargar_Empleados();
                    }
                }

                if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar")
                {
                    int id = Convert.ToInt32(dgEmpleados.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas borrar este registro?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        EliminarCliente(id);
                        Cargar_Empleados();
                    }
                }
            }
        }

    }
}
