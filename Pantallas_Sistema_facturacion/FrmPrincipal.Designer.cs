namespace Pantallas_Sistema_facturacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPrincipal = new Panel();
            pnlContenedor = new Panel();
            panel1 = new Panel();
            tbpMenu = new ReaLTaiizor.Controls.MaterialTabControl();
            Principal = new TabPage();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            Tablas = new TabPage();
            btnCategorias = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            pictureBox2 = new PictureBox();
            Facturacion = new TabPage();
            btnInformes = new Button();
            btnFacturas = new Button();
            pictureBox3 = new PictureBox();
            Seguridad = new TabPage();
            btnSeguridad = new Button();
            btnRoles = new Button();
            btnEmpleados = new Button();
            pictureBox4 = new PictureBox();
            Acerca = new TabPage();
            btnAcerca = new Button();
            btnAyuda = new Button();
            pictureBox5 = new PictureBox();
            tabOpcionesMenu = new ReaLTaiizor.Controls.MaterialTabSelector();
            pnlPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            tbpMenu.SuspendLayout();
            Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pnlContenedor);
            pnlPrincipal.Controls.Add(panel1);
            pnlPrincipal.Location = new Point(-7, 61);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1210, 594);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(200, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1010, 594);
            pnlContenedor.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbpMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 594);
            panel1.TabIndex = 0;
            // 
            // tbpMenu
            // 
            tbpMenu.Controls.Add(Principal);
            tbpMenu.Controls.Add(Tablas);
            tbpMenu.Controls.Add(Facturacion);
            tbpMenu.Controls.Add(Seguridad);
            tbpMenu.Controls.Add(Acerca);
            tbpMenu.Depth = 0;
            tbpMenu.Dock = DockStyle.Fill;
            tbpMenu.Location = new Point(0, 0);
            tbpMenu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tbpMenu.Multiline = true;
            tbpMenu.Name = "tbpMenu";
            tbpMenu.SelectedIndex = 0;
            tbpMenu.Size = new Size(200, 594);
            tbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            Principal.BackColor = Color.FromArgb(63, 81, 181);
            Principal.Controls.Add(btnSalir);
            Principal.Controls.Add(pictureBox1);
            Principal.Location = new Point(4, 44);
            Principal.Name = "Principal";
            Principal.Padding = new Padding(3);
            Principal.Size = new Size(192, 546);
            Principal.TabIndex = 0;
            Principal.Text = "Principal";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.logout1;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(8, 195);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(189, 48);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unity_white;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Tablas
            // 
            Tablas.BackColor = Color.FromArgb(63, 81, 181);
            Tablas.Controls.Add(btnCategorias);
            Tablas.Controls.Add(btnClientes);
            Tablas.Controls.Add(btnProductos);
            Tablas.Controls.Add(pictureBox2);
            Tablas.Location = new Point(4, 44);
            Tablas.Name = "Tablas";
            Tablas.Padding = new Padding(3);
            Tablas.Size = new Size(192, 546);
            Tablas.TabIndex = 1;
            Tablas.Text = "Tablas";
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = Properties.Resources.categorization;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(8, 305);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(189, 48);
            btnCategorias.TabIndex = 4;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.customer;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(8, 195);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(189, 48);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = Properties.Resources.shopping_cart;
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(8, 250);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(189, 48);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.unity_white;
            pictureBox2.Location = new Point(20, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Facturacion
            // 
            Facturacion.BackColor = Color.FromArgb(63, 81, 181);
            Facturacion.Controls.Add(btnInformes);
            Facturacion.Controls.Add(btnFacturas);
            Facturacion.Controls.Add(pictureBox3);
            Facturacion.Location = new Point(4, 44);
            Facturacion.Name = "Facturacion";
            Facturacion.Size = new Size(192, 546);
            Facturacion.TabIndex = 2;
            Facturacion.Text = "Facturacion";
            // 
            // btnInformes
            // 
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInformes.ForeColor = Color.White;
            btnInformes.Image = Properties.Resources.report;
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(8, 250);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(189, 48);
            btnInformes.TabIndex = 6;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = Color.White;
            btnFacturas.Image = Properties.Resources.bill;
            btnFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturas.Location = new Point(8, 195);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(189, 48);
            btnFacturas.TabIndex = 5;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.unity_white;
            pictureBox3.Location = new Point(20, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(153, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // Seguridad
            // 
            Seguridad.BackColor = Color.FromArgb(63, 81, 181);
            Seguridad.Controls.Add(btnSeguridad);
            Seguridad.Controls.Add(btnRoles);
            Seguridad.Controls.Add(btnEmpleados);
            Seguridad.Controls.Add(pictureBox4);
            Seguridad.Location = new Point(4, 44);
            Seguridad.Name = "Seguridad";
            Seguridad.Size = new Size(192, 546);
            Seguridad.TabIndex = 3;
            Seguridad.Text = "Seguridad";
            // 
            // btnSeguridad
            // 
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeguridad.ForeColor = Color.White;
            btnSeguridad.Image = Properties.Resources.cyber_security;
            btnSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeguridad.Location = new Point(8, 305);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(189, 48);
            btnSeguridad.TabIndex = 8;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = true;
            btnSeguridad.Click += btnSeguridad_Click;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.White;
            btnRoles.Image = Properties.Resources.admin;
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(8, 250);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(189, 48);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Image = Properties.Resources.team;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(8, 195);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(189, 48);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.unity_white;
            pictureBox4.Location = new Point(20, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(153, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // Acerca
            // 
            Acerca.BackColor = Color.FromArgb(63, 81, 181);
            Acerca.Controls.Add(btnAcerca);
            Acerca.Controls.Add(btnAyuda);
            Acerca.Controls.Add(pictureBox5);
            Acerca.Location = new Point(4, 44);
            Acerca.Name = "Acerca";
            Acerca.Size = new Size(192, 546);
            Acerca.TabIndex = 4;
            Acerca.Text = "Acerca";
            // 
            // btnAcerca
            // 
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcerca.ForeColor = Color.White;
            btnAcerca.Image = Properties.Resources.info;
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(8, 250);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(189, 48);
            btnAcerca.TabIndex = 8;
            btnAcerca.Text = "Acerca de";
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 45);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = Color.White;
            btnAyuda.Image = Properties.Resources.information;
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(8, 195);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(189, 48);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.unity_white;
            pictureBox5.Location = new Point(20, 20);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(153, 88);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // tabOpcionesMenu
            // 
            tabOpcionesMenu.BaseTabControl = tbpMenu;
            tabOpcionesMenu.CharacterCasing = ReaLTaiizor.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            tabOpcionesMenu.Depth = 0;
            tabOpcionesMenu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabOpcionesMenu.HeadAlignment = ReaLTaiizor.Controls.MaterialTabSelector.Alignment.Left;
            tabOpcionesMenu.Location = new Point(302, 24);
            tabOpcionesMenu.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabOpcionesMenu.Name = "tabOpcionesMenu";
            tabOpcionesMenu.Size = new Size(843, 31);
            tabOpcionesMenu.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1200, 650);
            Controls.Add(tabOpcionesMenu);
            Controls.Add(pnlPrincipal);
            Name = "FrmPrincipal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE FACTURACION";
            Load += FrmPrincipal_Load;
            pnlPrincipal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tbpMenu.ResumeLayout(false);
            Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private ReaLTaiizor.Controls.MaterialTabControl tbpMenu;
        private TabPage Principal;
        private TabPage Tablas;
        private Panel panel1;
        private TabPage Facturacion;
        private TabPage Seguridad;
        private TabPage Acerca;
        private ReaLTaiizor.Controls.MaterialTabSelector tabOpcionesMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnSalir;
        private Button btnCategorias;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnInformes;
        private Button btnFacturas;
        private Button btnSeguridad;
        private Button btnRoles;
        private Button btnEmpleados;
        private Button btnAyuda;
        private Button btnAcerca;
        private Panel pnlContenedor;
    }
}