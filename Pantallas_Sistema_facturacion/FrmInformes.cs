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
    public partial class FrmInformes : Form
    {
        public FrmInformes()
        {
            InitializeComponent();
        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {
            txtInforme.Items.AddRange(new string[] { "Ventas", "Facturación", "Productos", "Clientes" });

            txtOrdenar.Items.AddRange(new string[] { "Fecha", "Total", "Cliente", "Empleado" });

            txtFechaInicio.Value = DateTime.Today.AddDays(-7);
            txtFechaFinal.Value = DateTime.Today;

            rdPantalla.Checked = true;

            dgPantalla.ColumnCount = 3;
            dgPantalla.Columns[0].Name = "Fecha";
            dgPantalla.Columns[1].Name = "Cliente";
            dgPantalla.Columns[2].Name = "Total";

            dgPantalla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            string informe = txtInforme.Text;
            string ordenarPor = txtOrdenar.Text;
            DateTime desde = txtFechaInicio.Value;
            DateTime hasta = txtFechaFinal.Value;

            if (rdPantalla.Checked)
            {
                dgPantalla.Rows.Clear();

                dgPantalla.Rows.Add("20/08/2025", "Cliente A", "$150.000");
                dgPantalla.Rows.Add("21/08/2025", "Cliente B", "$250.000");
                dgPantalla.Rows.Add("22/08/2025", "Cliente C", "$350.000");
            }
            else if (rdPDF.Checked)
            {
                // Exportar a PDF
            }
            else if (rdExcel.Checked)
            {
                // Exportar a Excel
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
