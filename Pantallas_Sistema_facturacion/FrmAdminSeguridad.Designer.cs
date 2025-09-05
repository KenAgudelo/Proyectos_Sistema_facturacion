namespace Pantallas_Sistema_facturacion
{
    partial class FrmAdminSeguridad
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
            txtID = new TextBox();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            txtEmpleado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtClave = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtUser = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            dgUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            EMPLEADO = new DataGridViewTextBoxColumn();
            USUARIO = new DataGridViewTextBoxColumn();
            EDITAR = new DataGridViewButtonColumn();
            BORRAR = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(463, 260);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(375, 50);
            btnSalir.TabIndex = 27;
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
            btnAgregar.Location = new Point(57, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoRounding = false;
            btnAgregar.Size = new Size(375, 50);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlignment = HorizontalAlignment.Center;
            btnAgregar.Transparent = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ScrollBar;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(57, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(227, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(470, 30);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // txtEmpleado
            // 
            txtEmpleado.AutoResize = false;
            txtEmpleado.BackColor = Color.FromArgb(255, 255, 255);
            txtEmpleado.Depth = 0;
            txtEmpleado.DrawMode = DrawMode.OwnerDrawVariable;
            txtEmpleado.DropDownHeight = 174;
            txtEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEmpleado.DropDownWidth = 121;
            txtEmpleado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtEmpleado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEmpleado.FormattingEnabled = true;
            txtEmpleado.Hint = "Empleado";
            txtEmpleado.IntegralHeight = false;
            txtEmpleado.ItemHeight = 43;
            txtEmpleado.Location = new Point(57, 97);
            txtEmpleado.MaxDropDownItems = 4;
            txtEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(781, 49);
            txtEmpleado.StartIndex = 0;
            txtEmpleado.TabIndex = 30;
            // 
            // txtClave
            // 
            txtClave.AllowPromptAsInput = true;
            txtClave.AnimateReadOnly = false;
            txtClave.AsciiOnly = false;
            txtClave.BackgroundImageLayout = ImageLayout.None;
            txtClave.BeepOnError = false;
            txtClave.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtClave.Depth = 0;
            txtClave.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClave.HidePromptOnLeave = false;
            txtClave.HideSelection = true;
            txtClave.Hint = "Clave";
            txtClave.InsertKeyMode = InsertKeyMode.Default;
            txtClave.LeadingIcon = null;
            txtClave.Location = new Point(57, 206);
            txtClave.Mask = "";
            txtClave.MaxLength = 32767;
            txtClave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PrefixSuffixText = null;
            txtClave.PromptChar = '_';
            txtClave.ReadOnly = false;
            txtClave.RejectInputOnFirstFailure = false;
            txtClave.ResetOnPrompt = true;
            txtClave.ResetOnSpace = true;
            txtClave.RightToLeft = RightToLeft.No;
            txtClave.SelectedText = "";
            txtClave.SelectionLength = 0;
            txtClave.SelectionStart = 0;
            txtClave.ShortcutsEnabled = true;
            txtClave.Size = new Size(781, 48);
            txtClave.SkipLiterals = true;
            txtClave.TabIndex = 31;
            txtClave.TabStop = false;
            txtClave.TextAlign = HorizontalAlignment.Left;
            txtClave.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtClave.TrailingIcon = null;
            txtClave.UseSystemPasswordChar = false;
            txtClave.ValidatingType = null;
            // 
            // txtUser
            // 
            txtUser.AllowPromptAsInput = true;
            txtUser.AnimateReadOnly = false;
            txtUser.AsciiOnly = false;
            txtUser.BackgroundImageLayout = ImageLayout.None;
            txtUser.BeepOnError = false;
            txtUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.Depth = 0;
            txtUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.HidePromptOnLeave = false;
            txtUser.HideSelection = true;
            txtUser.Hint = "Usuario";
            txtUser.InsertKeyMode = InsertKeyMode.Default;
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(57, 152);
            txtUser.Mask = "";
            txtUser.MaxLength = 32767;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PrefixSuffixText = null;
            txtUser.PromptChar = '_';
            txtUser.ReadOnly = false;
            txtUser.RejectInputOnFirstFailure = false;
            txtUser.ResetOnPrompt = true;
            txtUser.ResetOnSpace = true;
            txtUser.RightToLeft = RightToLeft.No;
            txtUser.SelectedText = "";
            txtUser.SelectionLength = 0;
            txtUser.SelectionStart = 0;
            txtUser.ShortcutsEnabled = true;
            txtUser.Size = new Size(781, 48);
            txtUser.SkipLiterals = true;
            txtUser.TabIndex = 32;
            txtUser.TabStop = false;
            txtUser.TextAlign = HorizontalAlignment.Left;
            txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.TrailingIcon = null;
            txtUser.UseSystemPasswordChar = false;
            txtUser.ValidatingType = null;
            // 
            // dgUsuarios
            // 
            dgUsuarios.AllowUserToAddRows = false;
            dgUsuarios.AllowUserToDeleteRows = false;
            dgUsuarios.BackgroundColor = Color.Silver;
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, EMPLEADO, USUARIO, EDITAR, BORRAR });
            dgUsuarios.Location = new Point(57, 316);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.ReadOnly = true;
            dgUsuarios.Size = new Size(781, 190);
            dgUsuarios.TabIndex = 33;
            dgUsuarios.CellContentClick += dgUsuarios_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // EMPLEADO
            // 
            EMPLEADO.HeaderText = "EMPLEADO";
            EMPLEADO.Name = "EMPLEADO";
            EMPLEADO.ReadOnly = true;
            // 
            // USUARIO
            // 
            USUARIO.HeaderText = "USUARIO";
            USUARIO.Name = "USUARIO";
            USUARIO.ReadOnly = true;
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
            // FrmAdminSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(894, 530);
            Controls.Add(dgUsuarios);
            Controls.Add(txtUser);
            Controls.Add(txtClave);
            Controls.Add(txtEmpleado);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdminSeguridad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminSeguridad";
            Load += FrmAdminSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnAgregar;
        private TextBox txtID;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.MaterialComboBox txtEmpleado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtClave;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtUser;
        private DataGridView dgUsuarios;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn EMPLEADO;
        private DataGridViewTextBoxColumn USUARIO;
        private DataGridViewButtonColumn EDITAR;
        private DataGridViewButtonColumn BORRAR;
    }
}