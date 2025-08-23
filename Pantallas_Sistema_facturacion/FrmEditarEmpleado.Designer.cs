namespace Pantallas_Sistema_facturacion
{
    partial class FrmEditarEmpleado
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
            txtFechaRetiro = new ReaLTaiizor.Controls.PoisonDateTime();
            txtFechaIngreso = new ReaLTaiizor.Controls.PoisonDateTime();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnActualizar = new ReaLTaiizor.Controls.SpaceButton();
            txtDetalles = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            txtRol = new ReaLTaiizor.Controls.MaterialComboBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTelefono = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDireccion = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDocumento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNombre = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtID = new TextBox();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            lblFechaInicio = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // txtFechaRetiro
            // 
            txtFechaRetiro.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            txtFechaRetiro.Location = new Point(532, 275);
            txtFechaRetiro.MinimumSize = new Size(0, 29);
            txtFechaRetiro.Name = "txtFechaRetiro";
            txtFechaRetiro.Size = new Size(392, 29);
            txtFechaRetiro.TabIndex = 42;
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            txtFechaIngreso.Location = new Point(532, 195);
            txtFechaIngreso.MinimumSize = new Size(0, 29);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(392, 29);
            txtFechaIngreso.TabIndex = 41;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(532, 509);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(392, 48);
            btnSalir.TabIndex = 40;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnActualizar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = null;
            btnActualizar.Location = new Point(81, 509);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.NoRounding = false;
            btnActualizar.Size = new Size(392, 48);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = HorizontalAlignment.Center;
            btnActualizar.Transparent = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.HideSelection = true;
            txtDetalles.Hint = "Detalles";
            txtDetalles.Location = new Point(532, 336);
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
            txtDetalles.Size = new Size(392, 128);
            txtDetalles.TabIndex = 38;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.UseSystemPasswordChar = false;
            // 
            // txtRol
            // 
            txtRol.AutoResize = false;
            txtRol.BackColor = Color.FromArgb(255, 255, 255);
            txtRol.Depth = 0;
            txtRol.DrawMode = DrawMode.OwnerDrawVariable;
            txtRol.DropDownHeight = 174;
            txtRol.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRol.DropDownWidth = 121;
            txtRol.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtRol.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtRol.FormattingEnabled = true;
            txtRol.Hint = "RolEmpleado";
            txtRol.IntegralHeight = false;
            txtRol.ItemHeight = 43;
            txtRol.Location = new Point(532, 95);
            txtRol.MaxDropDownItems = 4;
            txtRol.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(392, 49);
            txtRol.StartIndex = 0;
            txtRol.TabIndex = 37;
            // 
            // txtEmail
            // 
            txtEmail.AllowPromptAsInput = true;
            txtEmail.AnimateReadOnly = false;
            txtEmail.AsciiOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.BeepOnError = false;
            txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HidePromptOnLeave = false;
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.InsertKeyMode = InsertKeyMode.Default;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(81, 416);
            txtEmail.Mask = "";
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.PromptChar = '_';
            txtEmail.ReadOnly = false;
            txtEmail.RejectInputOnFirstFailure = false;
            txtEmail.ResetOnPrompt = true;
            txtEmail.ResetOnSpace = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(392, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 36;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            // 
            // txtTelefono
            // 
            txtTelefono.AllowPromptAsInput = true;
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.AsciiOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.BeepOnError = false;
            txtTelefono.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HidePromptOnLeave = false;
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "Telefono";
            txtTelefono.InsertKeyMode = InsertKeyMode.Default;
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(81, 336);
            txtTelefono.Mask = "";
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.PromptChar = '_';
            txtTelefono.ReadOnly = false;
            txtTelefono.RejectInputOnFirstFailure = false;
            txtTelefono.ResetOnPrompt = true;
            txtTelefono.ResetOnSpace = true;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(392, 48);
            txtTelefono.SkipLiterals = true;
            txtTelefono.TabIndex = 35;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.ValidatingType = null;
            // 
            // txtDireccion
            // 
            txtDireccion.AllowPromptAsInput = true;
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.AsciiOnly = false;
            txtDireccion.BackgroundImageLayout = ImageLayout.None;
            txtDireccion.BeepOnError = false;
            txtDireccion.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.HidePromptOnLeave = false;
            txtDireccion.HideSelection = true;
            txtDireccion.Hint = "Direccion";
            txtDireccion.InsertKeyMode = InsertKeyMode.Default;
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(81, 256);
            txtDireccion.Mask = "";
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.PrefixSuffixText = null;
            txtDireccion.PromptChar = '_';
            txtDireccion.ReadOnly = false;
            txtDireccion.RejectInputOnFirstFailure = false;
            txtDireccion.ResetOnPrompt = true;
            txtDireccion.ResetOnSpace = true;
            txtDireccion.RightToLeft = RightToLeft.No;
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.ShortcutsEnabled = true;
            txtDireccion.Size = new Size(392, 48);
            txtDireccion.SkipLiterals = true;
            txtDireccion.TabIndex = 34;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            txtDireccion.ValidatingType = null;
            // 
            // txtDocumento
            // 
            txtDocumento.AllowPromptAsInput = true;
            txtDocumento.AnimateReadOnly = false;
            txtDocumento.AsciiOnly = false;
            txtDocumento.BackgroundImageLayout = ImageLayout.None;
            txtDocumento.BeepOnError = false;
            txtDocumento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDocumento.Depth = 0;
            txtDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocumento.HidePromptOnLeave = false;
            txtDocumento.HideSelection = true;
            txtDocumento.Hint = "Documento";
            txtDocumento.InsertKeyMode = InsertKeyMode.Default;
            txtDocumento.LeadingIcon = null;
            txtDocumento.Location = new Point(81, 176);
            txtDocumento.Mask = "";
            txtDocumento.MaxLength = 32767;
            txtDocumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.PasswordChar = '\0';
            txtDocumento.PrefixSuffixText = null;
            txtDocumento.PromptChar = '_';
            txtDocumento.ReadOnly = false;
            txtDocumento.RejectInputOnFirstFailure = false;
            txtDocumento.ResetOnPrompt = true;
            txtDocumento.ResetOnSpace = true;
            txtDocumento.RightToLeft = RightToLeft.No;
            txtDocumento.SelectedText = "";
            txtDocumento.SelectionLength = 0;
            txtDocumento.SelectionStart = 0;
            txtDocumento.ShortcutsEnabled = true;
            txtDocumento.Size = new Size(392, 48);
            txtDocumento.SkipLiterals = true;
            txtDocumento.TabIndex = 33;
            txtDocumento.TabStop = false;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDocumento.TrailingIcon = null;
            txtDocumento.UseSystemPasswordChar = false;
            txtDocumento.ValidatingType = null;
            // 
            // txtNombre
            // 
            txtNombre.AllowPromptAsInput = true;
            txtNombre.AnimateReadOnly = false;
            txtNombre.AsciiOnly = false;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.BeepOnError = false;
            txtNombre.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HidePromptOnLeave = false;
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Nombre Empleado";
            txtNombre.InsertKeyMode = InsertKeyMode.Default;
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(81, 96);
            txtNombre.Mask = "";
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.PromptChar = '_';
            txtNombre.ReadOnly = false;
            txtNombre.RejectInputOnFirstFailure = false;
            txtNombre.ResetOnPrompt = true;
            txtNombre.ResetOnSpace = true;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(392, 48);
            txtNombre.SkipLiterals = true;
            txtNombre.TabIndex = 32;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            txtNombre.ValidatingType = null;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ScrollBar;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(81, 65);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 31;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(280, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(415, 29);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Titulo";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Depth = 0;
            lblFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFechaInicio.ForeColor = SystemColors.ScrollBar;
            lblFechaInicio.Location = new Point(532, 176);
            lblFechaInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 19);
            lblFechaInicio.TabIndex = 47;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.ScrollBar;
            materialLabel1.Location = new Point(532, 256);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(89, 19);
            materialLabel1.TabIndex = 48;
            materialLabel1.Text = "Fecha Retiro";
            // 
            // FrmEditarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 585);
            Controls.Add(materialLabel1);
            Controls.Add(lblFechaInicio);
            Controls.Add(txtFechaRetiro);
            Controls.Add(txtFechaIngreso);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDetalles);
            Controls.Add(txtRol);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarEmpleado";
            Load += FrmEditarEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDateTime txtFechaRetiro;
        private ReaLTaiizor.Controls.PoisonDateTime txtFechaIngreso;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnActualizar;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDetalles;
        private ReaLTaiizor.Controls.MaterialComboBox txtRol;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefono;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDireccion;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDocumento;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNombre;
        private TextBox txtID;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaInicio;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}