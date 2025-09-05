namespace Pantallas_Sistema_facturacion
{
    partial class FrmEditarCliente
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
            txtID = new TextBox();
            txtNombreCliente = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDocumento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDireccion = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTelefono = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnActualizar = new ReaLTaiizor.Controls.SpaceButton();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(72, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(72, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.AllowPromptAsInput = true;
            txtNombreCliente.AnimateReadOnly = false;
            txtNombreCliente.AsciiOnly = false;
            txtNombreCliente.BackgroundImageLayout = ImageLayout.None;
            txtNombreCliente.BeepOnError = false;
            txtNombreCliente.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreCliente.Depth = 0;
            txtNombreCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreCliente.HidePromptOnLeave = false;
            txtNombreCliente.HideSelection = true;
            txtNombreCliente.Hint = "Nombre Cliente";
            txtNombreCliente.InsertKeyMode = InsertKeyMode.Default;
            txtNombreCliente.LeadingIcon = null;
            txtNombreCliente.Location = new Point(72, 115);
            txtNombreCliente.Mask = "";
            txtNombreCliente.MaxLength = 32767;
            txtNombreCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PasswordChar = '\0';
            txtNombreCliente.PrefixSuffixText = null;
            txtNombreCliente.PromptChar = '_';
            txtNombreCliente.ReadOnly = false;
            txtNombreCliente.RejectInputOnFirstFailure = false;
            txtNombreCliente.ResetOnPrompt = true;
            txtNombreCliente.ResetOnSpace = true;
            txtNombreCliente.RightToLeft = RightToLeft.No;
            txtNombreCliente.SelectedText = "";
            txtNombreCliente.SelectionLength = 0;
            txtNombreCliente.SelectionStart = 0;
            txtNombreCliente.ShortcutsEnabled = true;
            txtNombreCliente.Size = new Size(366, 48);
            txtNombreCliente.SkipLiterals = true;
            txtNombreCliente.TabIndex = 2;
            txtNombreCliente.TabStop = false;
            txtNombreCliente.TextAlign = HorizontalAlignment.Left;
            txtNombreCliente.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreCliente.TrailingIcon = null;
            txtNombreCliente.UseSystemPasswordChar = false;
            txtNombreCliente.ValidatingType = null;
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
            txtDocumento.Location = new Point(72, 195);
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
            txtDocumento.Size = new Size(366, 48);
            txtDocumento.SkipLiterals = true;
            txtDocumento.TabIndex = 3;
            txtDocumento.TabStop = false;
            txtDocumento.TextAlign = HorizontalAlignment.Left;
            txtDocumento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDocumento.TrailingIcon = null;
            txtDocumento.UseSystemPasswordChar = false;
            txtDocumento.ValidatingType = null;
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
            txtDireccion.Location = new Point(72, 275);
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
            txtDireccion.Size = new Size(366, 48);
            txtDireccion.SkipLiterals = true;
            txtDireccion.TabIndex = 4;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            txtDireccion.ValidatingType = null;
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
            txtTelefono.Location = new Point(72, 355);
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
            txtTelefono.Size = new Size(366, 48);
            txtTelefono.SkipLiterals = true;
            txtTelefono.TabIndex = 5;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            txtTelefono.ValidatingType = null;
            // 
            // btnActualizar
            // 
            btnActualizar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnActualizar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = null;
            btnActualizar.Location = new Point(72, 520);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.NoRounding = false;
            btnActualizar.Size = new Size(128, 50);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = HorizontalAlignment.Center;
            btnActualizar.Transparent = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(310, 520);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(128, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
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
            txtEmail.Location = new Point(72, 435);
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
            txtEmail.Size = new Size(366, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 8;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            // 
            // FrmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(500, 610);
            Controls.Add(txtEmail);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACTUALIZAR CLIENTE";
            Load += FrmEditarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private TextBox txtID;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNombreCliente;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDocumento;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDireccion;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefono;
        private ReaLTaiizor.Controls.SpaceButton btnActualizar;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
    }
}