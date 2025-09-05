using Microsoft.Data.SqlClient;
using ReaLTaiizor.Forms;
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
    public partial class FrmEditarCliente : Form
    {
        public FrmEditarCliente(int id, string nombre, string documento, string direccion, string telefono, string email)
        {
            InitializeComponent();

            IdCliente = id;
            txtID.Text = id.ToString();
            txtNombreCliente.Text = nombre;
            txtDocumento.Text = documento;
            txtDireccion.Text = direccion;
            txtTelefono.Text = telefono;
            txtEmail.Text = email;
        }

        public FrmEditarCliente(int id)
        {
            InitializeComponent();
            IdCliente = id;
        }

        public int IdCliente { get; set; }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESE UN NUEVO CLIENTE";
                btnActualizar.Text = "Agregar";
                txtID.Hide();
            }
            else
            {
                txtID.Show();
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtID.ReadOnly = true;
                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(IdCliente == 0)
            {
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    string query = @"INSERT INTO TBLCLIENTES 
                                        (StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail, DtmFechaModifica, StrUsuarioModifica)
                                        values (@nombre, @doc, @dir, @tel, @email, GETDATE(), SYSTEM_USER)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente registrado correctamente.", "Éxito",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    string query = @"UPDATE TBLCLIENTES 
                                    SET StrNombre = @nombre,
                                        NumDocumento = @doc,
                                        StrDireccion = @dir,
                                        StrTelefono = @tel,
                                        StrEmail = @email 
                                    Where IdCliente = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@doc", txtDocumento.Text);
                    cmd.Parameters.AddWithValue("@dir", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito",
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
    }
}
