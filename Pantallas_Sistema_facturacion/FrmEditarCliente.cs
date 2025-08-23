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
        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                lblTitulo.Text = "INGRESE UN NUEVO CLIENTE";
                btnActualizar.Text = "Agregar";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtID.Text = IdCliente.ToString();
                txtNombreCliente.Text = "Nombre1 Apellido1 Apellido2";
                txtDocumento.Text = "345346532";
                txtDireccion.Text = "calle donde vive cliente";
                txtTelefono.Text = "3145670921";
                btnActualizar.Text = "Actualizar";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(IdCliente == 0)
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
