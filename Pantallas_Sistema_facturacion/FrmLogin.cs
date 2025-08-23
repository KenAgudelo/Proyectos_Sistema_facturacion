namespace Pantallas_Sistema_facturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            string Respuesta = "";
            if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
            {
                if (txtUser.Text == "admin" && txtPass.Text == "1234")
                    Respuesta = "Ken Agudelo";

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido " + Respuesta);
                    FrmPrincipal principal = new();
                    this.Hide();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                    txtUser.Text = "";
                    txtUser.Focus();
                    txtPass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresar un usuario y contraseña.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
