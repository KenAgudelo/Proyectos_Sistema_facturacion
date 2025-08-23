namespace Pantallas_Sistema_facturacion
{
    partial class FrmRolEmpleados
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
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnAgregar = new ReaLTaiizor.Controls.SpaceButton();
            txtNombreRol = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtID = new TextBox();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            txtDetalles = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            dgRolEmpleados = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DETALLES = new DataGridViewTextBoxColumn();
            EDITAR = new DataGridViewButtonColumn();
            BORRAR = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgRolEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(477, 319);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(375, 50);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnAgregar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Image = null;
            btnAgregar.Location = new Point(71, 319);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoRounding = false;
            btnAgregar.Size = new Size(375, 50);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlignment = HorizontalAlignment.Center;
            btnAgregar.Transparent = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreRol
            // 
            txtNombreRol.AllowPromptAsInput = true;
            txtNombreRol.AnimateReadOnly = false;
            txtNombreRol.AsciiOnly = false;
            txtNombreRol.BackgroundImageLayout = ImageLayout.None;
            txtNombreRol.BeepOnError = false;
            txtNombreRol.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreRol.Depth = 0;
            txtNombreRol.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreRol.HidePromptOnLeave = false;
            txtNombreRol.HideSelection = true;
            txtNombreRol.Hint = "Nombre Rol";
            txtNombreRol.InsertKeyMode = InsertKeyMode.Default;
            txtNombreRol.LeadingIcon = null;
            txtNombreRol.Location = new Point(71, 112);
            txtNombreRol.Mask = "";
            txtNombreRol.MaxLength = 32767;
            txtNombreRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.PasswordChar = '\0';
            txtNombreRol.PrefixSuffixText = null;
            txtNombreRol.PromptChar = '_';
            txtNombreRol.ReadOnly = false;
            txtNombreRol.RejectInputOnFirstFailure = false;
            txtNombreRol.ResetOnPrompt = true;
            txtNombreRol.ResetOnSpace = true;
            txtNombreRol.RightToLeft = RightToLeft.No;
            txtNombreRol.SelectedText = "";
            txtNombreRol.SelectionLength = 0;
            txtNombreRol.SelectionStart = 0;
            txtNombreRol.ShortcutsEnabled = true;
            txtNombreRol.Size = new Size(781, 48);
            txtNombreRol.SkipLiterals = true;
            txtNombreRol.TabIndex = 18;
            txtNombreRol.TabStop = false;
            txtNombreRol.TextAlign = HorizontalAlignment.Left;
            txtNombreRol.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreRol.TrailingIcon = null;
            txtNombreRol.UseSystemPasswordChar = false;
            txtNombreRol.ValidatingType = null;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(71, 90);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 17;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(333, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 30);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "ROL DE EMPLEADOS";
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.HideSelection = true;
            txtDetalles.Hint = "Detalles";
            txtDetalles.Location = new Point(71, 166);
            txtDetalles.MaxLength = 32767;
            txtDetalles.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.PasswordChar = '\0';
            txtDetalles.ReadOnly = false;
            txtDetalles.ScrollBars = ScrollBars.None;
            txtDetalles.SelectedText = "";
            txtDetalles.SelectionLength = 0;
            txtDetalles.SelectionStart = 0;
            txtDetalles.ShortcutsEnabled = true;
            txtDetalles.Size = new Size(781, 147);
            txtDetalles.TabIndex = 21;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.UseSystemPasswordChar = false;
            // 
            // dgRolEmpleados
            // 
            dgRolEmpleados.AllowUserToAddRows = false;
            dgRolEmpleados.AllowUserToDeleteRows = false;
            dgRolEmpleados.BackgroundColor = Color.Silver;
            dgRolEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRolEmpleados.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, DETALLES, EDITAR, BORRAR });
            dgRolEmpleados.Location = new Point(71, 375);
            dgRolEmpleados.Name = "dgRolEmpleados";
            dgRolEmpleados.ReadOnly = true;
            dgRolEmpleados.Size = new Size(781, 146);
            dgRolEmpleados.TabIndex = 22;
            dgRolEmpleados.CellContentClick += dgRolEmpleados_CellContentClick_1;
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
            // DETALLES
            // 
            DETALLES.HeaderText = "DETALLES";
            DETALLES.Name = "DETALLES";
            DETALLES.ReadOnly = true;
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
            // FrmRolEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 601);
            Controls.Add(dgRolEmpleados);
            Controls.Add(txtDetalles);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreRol);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRolEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRolEmpleados";
            Load += FrmRolEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgRolEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnAgregar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNombreRol;
        private TextBox txtID;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDetalles;
        private DataGridView dgRolEmpleados;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DETALLES;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn BORRAR;
    }
}