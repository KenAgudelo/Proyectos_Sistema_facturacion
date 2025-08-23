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
        public FrmEditarEmpleado()
        {
            InitializeComponent();
        }
        public int IdEmpleado { get; set; }

        private void FrmEditarEmpleado_Load(object sender, EventArgs e)
        {
            txtRol.Items.AddRange(new string[] { "user", "admin" });
            if (IdEmpleado == 0)
            {
                lblTitulo.Text = "INGRESE UN NUEVO PRODUCTO";
                btnActualizar.Text = "Agregar";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR PRODUCTO";
                txtID.Text = IdEmpleado.ToString();
                txtNombre.Text = "Nombre1";
                txtDocumento.Text = "0431F";
                txtDireccion.Text = "Calle donde vive el empleado";
                txtTelefono.Text = "3245670987";
                txtEmail.Text = "test@gmail.com";
                txtRol.Text = "user";
                txtFechaIngreso.Value = DateTime.Today.AddDays(-7);
                txtFechaRetiro.Value = DateTime.Today;
                txtDetalles.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
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
