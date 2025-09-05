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
    public partial class FrmEditarProducto : Form
    {
        public FrmEditarProducto(int id, string nombre, string codigo, string precioCompra, string precioVenta, string idCategoria, string detalle, string foto, string stock)
        {
            InitializeComponent();

            IdProducto = id;
            txtID.Text = id.ToString();
            txtNombreProd.Text = nombre;
            txtReferencia.Text = codigo;
            txtPrecioCompra.Text = precioCompra;
            txtPrecioVenta.Text = precioVenta;
            txtCategoria.Text = idCategoria;
            txtDetalles.Text = detalle;
            txtImagen.Text = foto;
            txtStock.Text = stock;
        }

        public FrmEditarProducto(int id)
        {
            InitializeComponent();
            IdProducto = id;
        }

        public int IdProducto { get; set; }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            if (IdProducto == 0)
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
            CargarCategorias();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdProducto == 0)
            {
                using (SqlConnection conn = DB.Connection.GetConnection())
                {
                    string query = @"INSERT INTO TBLPRODUCTO 
                                        (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, IdCategoria, StrDetalle, strFoto, NumStock, DtmFechaModifica, StrUsuarioModifica)
                                        values (@nombre, @code, @PC, @PV, @idCat, @detalle, @foto, @stock, GETDATE(), SYSTEM_USER)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProd.Text);
                    cmd.Parameters.AddWithValue("@code", txtReferencia.Text);
                    cmd.Parameters.AddWithValue("@PC", txtPrecioCompra.Text);
                    cmd.Parameters.AddWithValue("@PV", txtPrecioVenta.Text);
                    cmd.Parameters.AddWithValue("@idCat", txtCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@detalle", txtDetalles.Text);
                    cmd.Parameters.AddWithValue("@foto", txtImagen.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);

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
                    string query = @"UPDATE TBLPRODUCTO 
                                    SET StrNombre = @nombre,
                                        StrCodigo = @code,
                                        NumPrecioCompra = @PC,
                                        NumPrecioVenta = @PV,
                                        IdCategoria = @idCat, 
                                        StrDetalle = @detalle, 
                                        strFoto = @foto, 
                                        NumStock = @stock 
                                    Where IdProducto = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProd.Text);
                    cmd.Parameters.AddWithValue("@code", txtReferencia.Text);
                    cmd.Parameters.AddWithValue("@PC", txtPrecioCompra.Text);
                    cmd.Parameters.AddWithValue("@PV", txtPrecioVenta.Text);
                    cmd.Parameters.AddWithValue("@idCat", txtCategoria.SelectedValue);
                    cmd.Parameters.AddWithValue("@detalle", txtDetalles.Text);
                    cmd.Parameters.AddWithValue("@foto", txtImagen.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
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

        private void CargarCategorias()
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                conn.Open();
                string query = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtCategoria.DataSource = dt;
                txtCategoria.DisplayMember = "StrDescripcion";
                txtCategoria.ValueMember = "IdCategoria";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
