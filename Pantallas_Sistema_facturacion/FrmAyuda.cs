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
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://docs.microsoft.com/");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (webView21 != null)
            {
                webView21.Dispose(); 
            }

            this.Close();
        }
    }
}
