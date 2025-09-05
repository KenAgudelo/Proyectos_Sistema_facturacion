using Microsoft.Data.SqlClient;

namespace Pantallas_Sistema_facturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            //string Respuesta = "";
            //if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
            //{
            //    if (txtUser.Text == "admin" && txtPass.Text == "1234")
            //        Respuesta = "Ken Agudelo";

            //    if (Respuesta != "")
            //    {
            //        MessageBox.Show("Bienvenido " + Respuesta);
            //        FrmPrincipal principal = new();
            //        this.Hide();
            //        principal.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
            //        txtUser.Text = "";
            //        txtUser.Focus();
            //        txtPass.Text = "";
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Porfavor ingresar un usuario y contraseña.");
            //}

            string usuario = txtUser.Text.TrimStart();
            string clave = txtPass.Text.Trim();

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            if(usuario == "admin" && clave == "1234")
            {
                MessageBox.Show("Bienvenido " + usuario);

                FrmPrincipal principal = new FrmPrincipal();
                this.Hide();
                principal.Show();
                return;
            }

            using (SqlConnection conn = DB.Connection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM TBLSEGURIDAD WHERE StrUsuario=@user AND StrClave=@pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", usuario);
                        cmd.Parameters.AddWithValue("@pass", clave);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Bienvenido " + usuario);

                            FrmPrincipal principal = new FrmPrincipal();
                            this.Hide();
                            principal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o clave incorrectos");
                            txtUser.Text = "";
                            txtPass.Text = "";
                            txtUser.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
