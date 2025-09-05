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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
        {
            InitializeComponent();
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            //llenar_grid();
            CargarProductos();
        }

        //public void llenar_grid()
        //{
        //    for (int i = 1; i < 20; i++)
        //    {
        //        dgProductos.Rows.Add(
        //            i,
        //            $"Nombre{i}",
        //            $"{i * 12345}",
        //            $"{i + 12831 * 21}",
        //            $"{i + 12831 * 1231}",
        //            $"{i + 12 * 3}", $"Categoria{1}",
        //            "image_url",
        //            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
        //            );
        //    }
        //}

        private void CargarProductos(string nombre = null)
        {
            string query = @"SELECT IdProducto AS ID, StrNombre AS Producto, StrCodigo AS Codigo,
                     NumPrecioCompra AS Precio_Compra, NumPrecioVenta AS Precio_Venta,
                     IdCategoria AS Id_Categoria, StrDetalle AS Detalle, StrFoto AS Foto, NumStock AS Stock
                     FROM TBLPRODUCTO";

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

                dgProductos.DataSource = dt;
            }

            if (!dgProductos.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "EDITAR";
                btnEditar.Text = "Editar";
                btnEditar.Name = "btnEditar";
                btnEditar.UseColumnTextForButtonValue = true;
                dgProductos.Columns.Add(btnEditar);
            }

            if (!dgProductos.Columns.Contains("btnBorrar"))
            {
                DataGridViewButtonColumn btnBorrar = new DataGridViewButtonColumn();
                btnBorrar.HeaderText = "BORRAR";
                btnBorrar.Text = "Borrar";
                btnBorrar.Name = "btnBorrar";
                btnBorrar.UseColumnTextForButtonValue = true;
                dgProductos.Columns.Add(btnBorrar);
            }
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int id = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["ID"].Value);
                    string nombre = dgProductos.Rows[e.RowIndex].Cells["Producto"].Value?.ToString() ?? string.Empty;
                    string codigo = dgProductos.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString() ?? string.Empty;
                    string precioCompra = dgProductos.Rows[e.RowIndex].Cells["Precio_Compra"].Value?.ToString() ?? string.Empty;
                    string precioVenta = dgProductos.Rows[e.RowIndex].Cells["Precio_Venta"].Value?.ToString() ?? string.Empty;
                    string idCategoria = dgProductos.Rows[e.RowIndex].Cells["Id_Categoria"].Value?.ToString() ?? string.Empty;
                    string detalle = dgProductos.Rows[e.RowIndex].Cells["Detalle"].Value?.ToString() ?? string.Empty;
                    string foto = dgProductos.Rows[e.RowIndex].Cells["Foto"].Value?.ToString() ?? string.Empty;
                    string stock = dgProductos.Rows[e.RowIndex].Cells["Stock"].Value?.ToString() ?? string.Empty;

                   FrmEditarProducto frm = new FrmEditarProducto(id, nombre, codigo, precioCompra, precioVenta, idCategoria, detalle, foto, stock);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        CargarProductos();
                    }
                }

                if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
                {
                    int id = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells["ID"].Value);

                    DialogResult result = MessageBox.Show("¿Seguro que deseas borrar este registro?",
                                                 "Confirmar eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        EliminarProducto(id);
                        CargarProductos();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscar.Text.Trim());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarProducto form = new(0);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarProductos();
            }
        }

        private void EliminarProducto(int id)
        {
            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                string query = "DELETE FROM TBLPRODUCTO WHERE IdProducto=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
