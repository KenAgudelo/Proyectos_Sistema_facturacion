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
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            txtDetalles.Text =
                @"Microsoft Visual Studio Community 2022
                Versión 15.0.26430.12 D15RTWSVC
                .NET Framework Version: 8.0

                Información adicional:
                - Windows Forms Application
                - C# .NET
                - Autor: Juan Pérez
                - Proyecto: Sistema de Facturación";
            txtDetalles.ReadOnly = true;
            txtDetalles.ScrollBars = ScrollBars.Both;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
