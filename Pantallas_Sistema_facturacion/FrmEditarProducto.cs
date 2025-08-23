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
        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            if (IdProducto == 0)
            {
                lblTitulo.Text = "INGRESE UN NUEVO PRODUCTO";
                btnActualizar.Text = "Agregar";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR PRODUCTO";
                txtID.Text = IdProducto.ToString();
                txtNombreProd.Text = "Nombre1";
                txtReferencia.Text = "0431F";
                txtPrecioCompra.Text = "10000";
                txtPrecioVenta.Text = "12000";
                txtStock.Text = "12345";
                txtCategoria.Text = "Categoria1";
                txtImagen.Text = "imagen_url";
                txtDetalles.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdProducto == 0)
            {
                MessageBox.Show("Datos Agregado");
            }
            else
            {
                MessageBox.Show("Datos Actualizados");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
