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
    public partial class FrmEditarCategoria : Form
    {
        public FrmEditarCategoria()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }

        private void FrmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {
                lblTitulo.Text = "INGRESE UNA NUEVA CATEGORIA";
                btnActualizar.Text = "Agregar";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                txtID.Text = IdCategoria.ToString();
                btnActualizar.Text = "Actualizar";
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
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
