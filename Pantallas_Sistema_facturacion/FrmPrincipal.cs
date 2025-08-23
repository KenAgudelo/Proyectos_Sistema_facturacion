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
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void Abrir_Form(Form form)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(form);
            form.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes listaClientes = new();
            Abrir_Form(listaClientes);

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos listaProductos = new();
            Abrir_Form(listaProductos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmListaCategorias listaCategorias = new();
            Abrir_Form(listaCategorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmListaFacturas listaFacturas = new();
            Abrir_Form(listaFacturas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes informes = new();
            Abrir_Form(informes);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new();
            Abrir_Form(ayuda);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            FrmAcercaDe acercaDe = new();
            Abrir_Form(acercaDe);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados empleados = new();
            Abrir_Form(empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRolEmpleados rolEmpleados = new();
            Abrir_Form(rolEmpleados);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            FrmAdminSeguridad form = new();
            Abrir_Form(form);
        }
    }
}
