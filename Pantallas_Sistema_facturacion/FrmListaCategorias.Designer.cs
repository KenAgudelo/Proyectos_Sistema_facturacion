namespace Pantallas_Sistema_facturacion
{
    partial class FrmListaCategorias
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
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnNuevo = new ReaLTaiizor.Controls.SpaceButton();
            txtBuscar = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnBuscar = new ReaLTaiizor.Controls.SpaceButton();
            dgCategorias = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            EDITAR = new DataGridViewButtonColumn();
            BORRAR = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(207, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(441, 34);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "ADMINISTRACIÓN CATEGORIAS";
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(695, 416);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(126, 48);
            btnSalir.TabIndex = 17;
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
            btnNuevo.Location = new Point(695, 98);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.NoRounding = false;
            btnNuevo.Size = new Size(126, 48);
            btnNuevo.TabIndex = 16;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlignment = HorizontalAlignment.Center;
            btnNuevo.Transparent = false;
            btnNuevo.Click += btnNuevo_Click;
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
            txtBuscar.Hint = "Buscar Categorias";
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(40, 98);
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
            txtBuscar.TabIndex = 14;
            txtBuscar.TabStop = false;
            txtBuscar.TextAlign = HorizontalAlignment.Left;
            txtBuscar.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtBuscar.TrailingIcon = null;
            txtBuscar.UseSystemPasswordChar = false;
            txtBuscar.ValidatingType = null;
            // 
            // btnBuscar
            // 
            btnBuscar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnBuscar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Image = null;
            btnBuscar.Location = new Point(347, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoRounding = false;
            btnBuscar.Size = new Size(126, 48);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlignment = HorizontalAlignment.Center;
            btnBuscar.Transparent = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgCategorias
            // 
            dgCategorias.AllowUserToAddRows = false;
            dgCategorias.AllowUserToDeleteRows = false;
            dgCategorias.BackgroundColor = Color.Silver;
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, EDITAR, BORRAR });
            dgCategorias.Location = new Point(40, 152);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.ReadOnly = true;
            dgCategorias.Size = new Size(781, 258);
            dgCategorias.TabIndex = 19;
            dgCategorias.CellContentClick += dgCategorias_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 150;
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
            // FrmListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 500);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaCategorias";
            Load += FrmListaCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnNuevo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtBuscar;
        private ReaLTaiizor.Controls.SpaceButton btnBuscar;
        private DataGridView dgCategorias;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn BORRAR;
    }
}