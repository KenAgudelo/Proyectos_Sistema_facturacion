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
    public partial class FrmAdminSeguridad : Form
    {
        public FrmAdminSeguridad()
        {
            InitializeComponent();
        }

        bool modoEdicion = false;
        int filaSeleccionada = -1;

        private void FrmAdminSeguridad_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarUsuarios();
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgUsuarios.Columns[e.ColumnIndex].HeaderText == "EDITAR")
            {
                filaSeleccionada = e.RowIndex;

                txtEmpleado.Text = dgUsuarios.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txtUser.Text = dgUsuarios.Rows[filaSeleccionada].Cells[2].Value.ToString();

                string idSeguridad = dgUsuarios.Rows[filaSeleccionada].Cells[0].Value.ToString();
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT StrClave FROM TBLSEGURIDAD WHERE IdSeguridad=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", idSeguridad);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtClave.Text = result.ToString();
                    }
                }

                modoEdicion = true;
                btnAgregar.Text = "Guardar Cambios";
            }
            else if (dgUsuarios.Columns[e.ColumnIndex].HeaderText == "BORRAR")
            {
                if (MessageBox.Show("¿Seguro que deseas borrar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string idSeguridad = dgUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();

                    using (SqlConnection conn = DB.Connection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM TBLSEGURIDAD WHERE IdSeguridad=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", idSeguridad);
                        cmd.ExecuteNonQuery();
                    }

                    CargarUsuarios();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.SelectedValue == null || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                conn.Open();

                if (modoEdicion && filaSeleccionada >= 0)
                {
                    string idSeguridad = dgUsuarios.Rows[filaSeleccionada].Cells[0].Value.ToString();
                    string queryUpdate = "UPDATE TBLSEGURIDAD SET IdEmpleado=@IdEmpleado, StrUsuario=@Usuario, StrClave=@Clave WHERE IdSeguridad=@Id";
                    SqlCommand cmd = new SqlCommand(queryUpdate, conn);
                    cmd.Parameters.AddWithValue("@IdEmpleado", txtEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@Usuario", txtUser.Text);
                    cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                    cmd.Parameters.AddWithValue("@Id", idSeguridad);
                    cmd.ExecuteNonQuery();

                    modoEdicion = false;
                    btnAgregar.Text = "Agregar";
                }
                else
                {
                    string queryInsert = "INSERT INTO TBLSEGURIDAD (IdEmpleado, StrUsuario, StrClave) VALUES (@IdEmpleado, @Usuario, @Clave)";
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@IdEmpleado", txtEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@Usuario", txtUser.Text);
                    cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            txtUser.Clear();
            txtClave.Clear();
            CargarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarEmpleados()
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                conn.Open();
                string query = "SELECT IdEmpleado, StrNombre FROM TBLEMPLEADO";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtEmpleado.DataSource = dt;
                txtEmpleado.DisplayMember = "StrNombre";
                txtEmpleado.ValueMember = "IdEmpleado";
            }
        }

        private void CargarUsuarios()
        {
            dgUsuarios.Rows.Clear();

            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                conn.Open();
                string query = @"SELECT S.IdSeguridad, E.StrNombre, S.StrUsuario
                         FROM TBLSEGURIDAD S
                         INNER JOIN TBLEMPLEADO E ON S.IdEmpleado = E.IdEmpleado";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgUsuarios.Rows.Add(
                        dr["IdSeguridad"].ToString(),
                        dr["StrNombre"].ToString(),
                        dr["StrUsuario"].ToString()
                    );
                }
            }
        }
    }
}
