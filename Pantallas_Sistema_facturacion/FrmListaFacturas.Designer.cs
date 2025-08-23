namespace Pantallas_Sistema_facturacion
{
    partial class FrmListaFacturas
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
            dgFacturas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            N_FACTURA = new DataGridViewTextBoxColumn();
            CLIENTE = new DataGridViewTextBoxColumn();
            EMPLEADO = new DataGridViewTextBoxColumn();
            DESCUENTO = new DataGridViewTextBoxColumn();
            TOTAL_IVA = new DataGridViewTextBoxColumn();
            TOTAL_F = new DataGridViewTextBoxColumn();
            FECHA_R = new DataGridViewTextBoxColumn();
            ESTADO_F = new DataGridViewTextBoxColumn();
            EDITAR = new DataGridViewButtonColumn();
            BORRAR = new DataGridViewButtonColumn();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnNuevo = new ReaLTaiizor.Controls.SpaceButton();
            btnBuscar = new ReaLTaiizor.Controls.SpaceButton();
            txtBuscar = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgFacturas).BeginInit();
            SuspendLayout();
            // 
            // dgFacturas
            // 
            dgFacturas.AllowUserToAddRows = false;
            dgFacturas.AllowUserToDeleteRows = false;
            dgFacturas.BackgroundColor = Color.Silver;
            dgFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFacturas.Columns.AddRange(new DataGridViewColumn[] { ID, N_FACTURA, CLIENTE, EMPLEADO, DESCUENTO, TOTAL_IVA, TOTAL_F, FECHA_R, ESTADO_F, EDITAR, BORRAR });
            dgFacturas.Location = new Point(46, 152);
            dgFacturas.Name = "dgFacturas";
            dgFacturas.ReadOnly = true;
            dgFacturas.Size = new Size(806, 279);
            dgFacturas.TabIndex = 13;
            dgFacturas.CellContentClick += dgFacturas_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
            // 
            // N_FACTURA
            // 
            N_FACTURA.HeaderText = "N_FACTURA";
            N_FACTURA.Name = "N_FACTURA";
            N_FACTURA.ReadOnly = true;
            N_FACTURA.Width = 150;
            // 
            // CLIENTE
            // 
            CLIENTE.HeaderText = "CLIENTE";
            CLIENTE.Name = "CLIENTE";
            CLIENTE.ReadOnly = true;
            // 
            // EMPLEADO
            // 
            EMPLEADO.HeaderText = "EMPLEADO";
            EMPLEADO.Name = "EMPLEADO";
            EMPLEADO.ReadOnly = true;
            // 
            // DESCUENTO
            // 
            DESCUENTO.HeaderText = "DESCUENTO";
            DESCUENTO.Name = "DESCUENTO";
            DESCUENTO.ReadOnly = true;
            // 
            // TOTAL_IVA
            // 
            TOTAL_IVA.HeaderText = "TOTAL_IVA";
            TOTAL_IVA.Name = "TOTAL_IVA";
            TOTAL_IVA.ReadOnly = true;
            // 
            // TOTAL_F
            // 
            TOTAL_F.HeaderText = "TOTAL_F";
            TOTAL_F.Name = "TOTAL_F";
            TOTAL_F.ReadOnly = true;
            // 
            // FECHA_R
            // 
            FECHA_R.HeaderText = "FECHA_R";
            FECHA_R.Name = "FECHA_R";
            FECHA_R.ReadOnly = true;
            // 
            // ESTADO_F
            // 
            ESTADO_F.HeaderText = "ESTADO_F";
            ESTADO_F.Name = "ESTADO_F";
            ESTADO_F.ReadOnly = true;
            // 
            // EDITAR
            // 
            EDITAR.HeaderText = "EDITAR";
            EDITAR.Name = "EDITAR";
            EDITAR.ReadOnly = true;
            EDITAR.Resizable = DataGridViewTriState.True;
            EDITAR.SortMode = DataGridViewColumnSortMode.Automatic;
            EDITAR.Text = "EDITAR";
            EDITAR.UseColumnTextForButtonValue = true;
            // 
            // BORRAR
            // 
            BORRAR.HeaderText = "BORRAR";
            BORRAR.Name = "BORRAR";
            BORRAR.ReadOnly = true;
            BORRAR.Resizable = DataGridViewTriState.True;
            BORRAR.SortMode = DataGridViewColumnSortMode.Automatic;
            BORRAR.Text = "BORRAR";
            BORRAR.UseColumnTextForButtonValue = true;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(247, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(485, 34);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(726, 437);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(126, 48);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnNuevo.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Image = null;
            btnNuevo.Location = new Point(726, 98);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.NoRounding = false;
            btnNuevo.Size = new Size(126, 48);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlignment = HorizontalAlignment.Center;
            btnNuevo.Transparent = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnBuscar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Image = null;
            btnBuscar.Location = new Point(353, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoRounding = false;
            btnBuscar.Size = new Size(126, 48);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlignment = HorizontalAlignment.Center;
            btnBuscar.Transparent = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.AllowPromptAsInput = true;
            txtBuscar.AnimateReadOnly = false;
            txtBuscar.AsciiOnly = false;
            txtBuscar.BackgroundImageLayout = ImageLayout.None;
            txtBuscar.BeepOnError = false;
            txtBuscar.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.Depth = 0;
            txtBuscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuscar.HidePromptOnLeave = false;
            txtBuscar.HideSelection = true;
            txtBuscar.Hint = "Buscar Facturas";
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(46, 98);
            txtBuscar.Mask = "";
            txtBuscar.MaxLength = 32767;
            txtBuscar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PasswordChar = '\0';
            txtBuscar.PrefixSuffixText = null;
            txtBuscar.PromptChar = '_';
            txtBuscar.ReadOnly = false;
            txtBuscar.RejectInputOnFirstFailure = false;
            txtBuscar.ResetOnPrompt = true;
            txtBuscar.ResetOnSpace = true;
            txtBuscar.RightToLeft = RightToLeft.No;
            txtBuscar.SelectedText = "";
            txtBuscar.SelectionLength = 0;
            txtBuscar.SelectionStart = 0;
            txtBuscar.ShortcutsEnabled = true;
            txtBuscar.Size = new Size(301, 48);
            txtBuscar.SkipLiterals = true;
            txtBuscar.TabIndex = 8;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.ValidatingType = null;
            // 
            // FrmListaFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 538);
            Controls.Add(dgFacturas);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaFacturas";
            Load += FrmListaFacturas_Load;
            ((System.ComponentModel.ISupportInitialize)dgFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgFacturas;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn N_FACTURA;
        private DataGridViewTextBoxColumn CLIENTE;
        private DataGridViewTextBoxColumn EMPLEADO;
        private DataGridViewTextBoxColumn DESCUENTO;
        private DataGridViewTextBoxColumn TOTAL_IVA;
        private DataGridViewTextBoxColumn TOTAL_F;
        private DataGridViewTextBoxColumn FECHA_R;
        private DataGridViewTextBoxColumn ESTADO_F;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn BORRAR;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnNuevo;
        private ReaLTaiizor.Controls.SpaceButton btnBuscar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtBuscar;
    }
}