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
    public partial class FrmEditarEmpleado : Form
    {
        public FrmEditarEmpleado(int id, string nombre, string documento, string direccion, string telefono, string email, string idRol, DateTime fecha_ingreso, DateTime fecha_retiro, string datos)
        {
            InitializeComponent();

            IdEmpleado = id;
            txtID.Text = id.ToString();
            txtNombre.Text = nombre;
            txtDocumento.Text = documento;
            txtDireccion.Text = direccion;
            txtTelefono.Text = telefono;
            txtEmail.Text = email;
            txtRol.SelectedValue = Convert.ToInt32(idRol);
            txtFechaIngreso.Value = fecha_ingreso;
            txtFechaRetiro.Value = fecha_retiro;
            txtDetalles.Text = datos;
        }

        public FrmEditarEmpleado(int id)
        {
            InitializeComponent();
            IdEmpleado = id;
        }

        public int IdEmpleado { get; }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESE UN NUEVO PRODUCTO";
                btnActualizar.Text = "Agregar";
                txtID.Hide();
            }
            else
            {
                txtID.Show();
                lblTitulo.Text = "MODIFICAR PRODUCTO";
                txtID.ReadOnly = true;
                btnActualizar.Text = "Actualizar";
            }
            Obtener_Roles();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
            {
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    string query = @"INSERT INTO TBLEMPLEADO
                                        (
                                            StrNombre,
                                            NumDocumento,
                                            StrDireccion,
                                            StrTelefono,
                                            StrEmail,
                                            IdRolEmpleado,
                                            DtmIngreso,
                                            DtmRetiro,
                                            strDatosAdicionales,
                                            DtmFechaModifica,
                                            StrUsuarioModifico
                                        ) values (
                                                    @nombre,
                                                    @doc,
                                                    @dir,
                                                    @tel,
                                                    @email,
                                                    @rol,
                                                    @dtmIngreso,
                                                    @dtmRetiro,
                                                    @datos,
                                                    GETDATE(),
                                                    SYSTEM_USER
                                                )";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@rol", txtRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@dtmIngreso", txtFechaIngreso.Value);
                    cmd.Parameters.AddWithValue("@dtmRetiro", txtFechaRetiro.Value);
                    cmd.Parameters.AddWithValue("@datos", txtDetalles.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registrado correctamente.", "Éxito",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    string query = @"UPDATE TBLEMPLEADO
                                       SET
                                            StrNombre = @nombre,
                                            NumDocumento = @doc,
                                            StrDireccion = @dir,
                                            StrTelefono = @tel,
                                            StrEmail = @email,
                                            IdRolEmpleado = @rol,
                                            DtmIngreso = @dtmIngreso,
                                            DtmRetiro = @dtmRetiro,
                                            strDatosAdicionales = @datos
                                       WHERE IdEmpleado = @id";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@rol", txtRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@dtmIngreso", txtFechaIngreso.Value);
                    cmd.Parameters.AddWithValue("@dtmRetiro", txtFechaRetiro.Value);
                    cmd.Parameters.AddWithValue("@datos", txtDetalles.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro actualizado correctamente.", "Éxito",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Obtener_Roles()
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                string query = "SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtRol.DataSource = dt;
                txtRol.DisplayMember = "StrDescripcion";
                txtRol.ValueMember = "IdRolEmpleado";
            }
        }
    }
}
