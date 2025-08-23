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
    public partial class FrmEditarFactura : Form
    {
        public FrmEditarFactura()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }
        private void FrmEditarFactura_Load(object sender, EventArgs e)
        {
            txtCliente.Items.AddRange(new string[] { "Cliente 1", "Cliente 2" });
            txtEmpleado.Items.AddRange(new string[] { "Empleado 1", "Empleado 2" });
            txtEstado.Items.AddRange(new string[] { "Pendiente", "Pagada", "Anulada" });
            dgDetalles.Columns.Add("Producto", "Producto");
            dgDetalles.Columns.Add("Cantidad", "Cantidad");
            dgDetalles.Columns.Add("Precio", "Precio Unitario");
            dgDetalles.Columns.Add("Subtotal", "Subtotal");

            if (IdFactura == 0)
            {
                lblTitulo.Text = "INGRESE UNA NUEVA FACTURA";
                btnActualizar.Text = "Agregar";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR FACTURA";
                txtID.Text = IdFactura.ToString();
                txtN_Factura.Text = "12351";
                txtDescuento.Text = "20%";
                txtTotalIVA.Text = "4000";
                txtTotalFactura.Text = "12000";
                txtCliente.Text = "Cliente 1";
                txtEmpleado.Text = "Empleado 1";
                txtEstado.Text = "Pendiente";
                txtFecha.Value = DateTime.Today;
                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdFactura == 0)
            {
                MessageBox.Show("Datos Agregado");
            }
            else
            {
                MessageBox.Show("Datos Actualizados");
            }
        }
    }
}
