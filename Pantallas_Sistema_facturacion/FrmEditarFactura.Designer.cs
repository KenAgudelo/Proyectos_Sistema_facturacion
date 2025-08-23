namespace Pantallas_Sistema_facturacion
{
    partial class FrmEditarFactura
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
            btnActualizar = new ReaLTaiizor.Controls.SpaceButton();
            txtCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            txtTotalFactura = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTotalIVA = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescuento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtN_Factura = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtID = new TextBox();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            txtEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtEmpleado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtFecha = new ReaLTaiizor.Controls.PoisonDateTime();
            dgDetalles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(521, 586);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(392, 48);
            btnSalir.TabIndex = 24;
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
            btnActualizar.Location = new Point(70, 586);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.NoRounding = false;
            btnActualizar.Size = new Size(392, 48);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = HorizontalAlignment.Center;
            btnActualizar.Transparent = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtCliente
            // 
            txtCliente.AutoResize = false;
            txtCliente.BackColor = Color.FromArgb(255, 255, 255);
            txtCliente.Depth = 0;
            txtCliente.DrawMode = DrawMode.OwnerDrawVariable;
            txtCliente.DropDownHeight = 174;
            txtCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCliente.DropDownWidth = 121;
            txtCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCliente.FormattingEnabled = true;
            txtCliente.Hint = "Cliente";
            txtCliente.IntegralHeight = false;
            txtCliente.ItemHeight = 43;
            txtCliente.Location = new Point(521, 104);
            txtCliente.MaxDropDownItems = 4;
            txtCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(392, 49);
            txtCliente.StartIndex = 0;
            txtCliente.TabIndex = 20;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.AllowPromptAsInput = true;
            txtTotalFactura.AnimateReadOnly = false;
            txtTotalFactura.AsciiOnly = false;
            txtTotalFactura.BackgroundImageLayout = ImageLayout.None;
            txtTotalFactura.BeepOnError = false;
            txtTotalFactura.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalFactura.Depth = 0;
            txtTotalFactura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalFactura.HidePromptOnLeave = false;
            txtTotalFactura.HideSelection = true;
            txtTotalFactura.Hint = "Total Factura";
            txtTotalFactura.InsertKeyMode = InsertKeyMode.Default;
            txtTotalFactura.LeadingIcon = null;
            txtTotalFactura.Location = new Point(70, 345);
            txtTotalFactura.Mask = "";
            txtTotalFactura.MaxLength = 32767;
            txtTotalFactura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.PasswordChar = '\0';
            txtTotalFactura.PrefixSuffixText = null;
            txtTotalFactura.PromptChar = '_';
            txtTotalFactura.ReadOnly = false;
            txtTotalFactura.RejectInputOnFirstFailure = false;
            txtTotalFactura.ResetOnPrompt = true;
            txtTotalFactura.ResetOnSpace = true;
            txtTotalFactura.RightToLeft = RightToLeft.No;
            txtTotalFactura.SelectedText = "";
            txtTotalFactura.SelectionLength = 0;
            txtTotalFactura.SelectionStart = 0;
            txtTotalFactura.ShortcutsEnabled = true;
            txtTotalFactura.Size = new Size(392, 48);
            txtTotalFactura.SkipLiterals = true;
            txtTotalFactura.TabIndex = 18;
            txtTotalFactura.TabStop = false;
            txtTotalFactura.TextAlign = HorizontalAlignment.Left;
            txtTotalFactura.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalFactura.TrailingIcon = null;
            txtTotalFactura.UseSystemPasswordChar = false;
            txtTotalFactura.ValidatingType = null;
            // 
            // txtTotalIVA
            // 
            txtTotalIVA.AllowPromptAsInput = true;
            txtTotalIVA.AnimateReadOnly = false;
            txtTotalIVA.AsciiOnly = false;
            txtTotalIVA.BackgroundImageLayout = ImageLayout.None;
            txtTotalIVA.BeepOnError = false;
            txtTotalIVA.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalIVA.Depth = 0;
            txtTotalIVA.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalIVA.HidePromptOnLeave = false;
            txtTotalIVA.HideSelection = true;
            txtTotalIVA.Hint = "Total IVA";
            txtTotalIVA.InsertKeyMode = InsertKeyMode.Default;
            txtTotalIVA.LeadingIcon = null;
            txtTotalIVA.Location = new Point(70, 265);
            txtTotalIVA.Mask = "";
            txtTotalIVA.MaxLength = 32767;
            txtTotalIVA.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalIVA.Name = "txtTotalIVA";
            txtTotalIVA.PasswordChar = '\0';
            txtTotalIVA.PrefixSuffixText = null;
            txtTotalIVA.PromptChar = '_';
            txtTotalIVA.ReadOnly = false;
            txtTotalIVA.RejectInputOnFirstFailure = false;
            txtTotalIVA.ResetOnPrompt = true;
            txtTotalIVA.ResetOnSpace = true;
            txtTotalIVA.RightToLeft = RightToLeft.No;
            txtTotalIVA.SelectedText = "";
            txtTotalIVA.SelectionLength = 0;
            txtTotalIVA.SelectionStart = 0;
            txtTotalIVA.ShortcutsEnabled = true;
            txtTotalIVA.Size = new Size(392, 48);
            txtTotalIVA.SkipLiterals = true;
            txtTotalIVA.TabIndex = 17;
            txtTotalIVA.TabStop = false;
            txtTotalIVA.TextAlign = HorizontalAlignment.Left;
            txtTotalIVA.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalIVA.TrailingIcon = null;
            txtTotalIVA.UseSystemPasswordChar = false;
            txtTotalIVA.ValidatingType = null;
            // 
            // txtDescuento
            // 
            txtDescuento.AllowPromptAsInput = true;
            txtDescuento.AnimateReadOnly = false;
            txtDescuento.AsciiOnly = false;
            txtDescuento.BackgroundImageLayout = ImageLayout.None;
            txtDescuento.BeepOnError = false;
            txtDescuento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDescuento.Depth = 0;
            txtDescuento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescuento.HidePromptOnLeave = false;
            txtDescuento.HideSelection = true;
            txtDescuento.Hint = "Descuento";
            txtDescuento.InsertKeyMode = InsertKeyMode.Default;
            txtDescuento.LeadingIcon = null;
            txtDescuento.Location = new Point(70, 185);
            txtDescuento.Mask = "";
            txtDescuento.MaxLength = 32767;
            txtDescuento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescuento.Name = "txtDescuento";
            txtDescuento.PasswordChar = '\0';
            txtDescuento.PrefixSuffixText = null;
            txtDescuento.PromptChar = '_';
            txtDescuento.ReadOnly = false;
            txtDescuento.RejectInputOnFirstFailure = false;
            txtDescuento.ResetOnPrompt = true;
            txtDescuento.ResetOnSpace = true;
            txtDescuento.RightToLeft = RightToLeft.No;
            txtDescuento.SelectedText = "";
            txtDescuento.SelectionLength = 0;
            txtDescuento.SelectionStart = 0;
            txtDescuento.ShortcutsEnabled = true;
            txtDescuento.Size = new Size(392, 48);
            txtDescuento.SkipLiterals = true;
            txtDescuento.TabIndex = 16;
            txtDescuento.TabStop = false;
            txtDescuento.TextAlign = HorizontalAlignment.Left;
            txtDescuento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDescuento.TrailingIcon = null;
            txtDescuento.UseSystemPasswordChar = false;
            txtDescuento.ValidatingType = null;
            // 
            // txtN_Factura
            // 
            txtN_Factura.AllowPromptAsInput = true;
            txtN_Factura.AnimateReadOnly = false;
            txtN_Factura.AsciiOnly = false;
            txtN_Factura.BackgroundImageLayout = ImageLayout.None;
            txtN_Factura.BeepOnError = false;
            txtN_Factura.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtN_Factura.Depth = 0;
            txtN_Factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtN_Factura.HidePromptOnLeave = false;
            txtN_Factura.HideSelection = true;
            txtN_Factura.Hint = "Nro. Factura";
            txtN_Factura.InsertKeyMode = InsertKeyMode.Default;
            txtN_Factura.LeadingIcon = null;
            txtN_Factura.Location = new Point(70, 105);
            txtN_Factura.Mask = "";
            txtN_Factura.MaxLength = 32767;
            txtN_Factura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtN_Factura.Name = "txtN_Factura";
            txtN_Factura.PasswordChar = '\0';
            txtN_Factura.PrefixSuffixText = null;
            txtN_Factura.PromptChar = '_';
            txtN_Factura.ReadOnly = false;
            txtN_Factura.RejectInputOnFirstFailure = false;
            txtN_Factura.ResetOnPrompt = true;
            txtN_Factura.ResetOnSpace = true;
            txtN_Factura.RightToLeft = RightToLeft.No;
            txtN_Factura.SelectedText = "";
            txtN_Factura.SelectionLength = 0;
            txtN_Factura.SelectionStart = 0;
            txtN_Factura.ShortcutsEnabled = true;
            txtN_Factura.Size = new Size(392, 48);
            txtN_Factura.SkipLiterals = true;
            txtN_Factura.TabIndex = 15;
            txtN_Factura.TabStop = false;
            txtN_Factura.TextAlign = HorizontalAlignment.Left;
            txtN_Factura.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtN_Factura.TrailingIcon = null;
            txtN_Factura.UseSystemPasswordChar = false;
            txtN_Factura.ValidatingType = null;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ScrollBar;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(70, 74);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 14;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(269, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(415, 29);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Titulo";
            // 
            // txtEstado
            // 
            txtEstado.AutoResize = false;
            txtEstado.BackColor = Color.FromArgb(255, 255, 255);
            txtEstado.Depth = 0;
            txtEstado.DrawMode = DrawMode.OwnerDrawVariable;
            txtEstado.DropDownHeight = 174;
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.DropDownWidth = 121;
            txtEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEstado.FormattingEnabled = true;
            txtEstado.Hint = "Estado Factura";
            txtEstado.IntegralHeight = false;
            txtEstado.ItemHeight = 43;
            txtEstado.Location = new Point(521, 265);
            txtEstado.MaxDropDownItems = 4;
            txtEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(392, 49);
            txtEstado.StartIndex = 0;
            txtEstado.TabIndex = 25;
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
            txtEmpleado.Location = new Point(521, 175);
            txtEmpleado.MaxDropDownItems = 4;
            txtEmpleado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(392, 49);
            txtEmpleado.StartIndex = 0;
            txtEmpleado.TabIndex = 26;
            // 
            // txtFecha
            // 
            txtFecha.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            txtFecha.Location = new Point(521, 345);
            txtFecha.MinimumSize = new Size(0, 29);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(392, 29);
            txtFecha.TabIndex = 27;
            // 
            // dgDetalles
            // 
            dgDetalles.AllowUserToAddRows = false;
            dgDetalles.AllowUserToDeleteRows = false;
            dgDetalles.BackgroundColor = Color.Silver;
            dgDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetalles.Location = new Point(70, 399);
            dgDetalles.Name = "dgDetalles";
            dgDetalles.ReadOnly = true;
            dgDetalles.Size = new Size(843, 181);
            dgDetalles.TabIndex = 28;
            // 
            // FrmEditarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 674);
            Controls.Add(dgDetalles);
            Controls.Add(txtFecha);
            Controls.Add(txtEmpleado);
            Controls.Add(txtEstado);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtCliente);
            Controls.Add(txtTotalFactura);
            Controls.Add(txtTotalIVA);
            Controls.Add(txtDescuento);
            Controls.Add(txtN_Factura);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarFactura";
            Load += FrmEditarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnActualizar;
        private ReaLTaiizor.Controls.MaterialComboBox txtCliente;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTotalFactura;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTotalIVA;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDescuento;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtN_Factura;
        private TextBox txtID;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.MaterialComboBox txtEstado;
        private ReaLTaiizor.Controls.MaterialComboBox txtEmpleado;
        private ReaLTaiizor.Controls.PoisonDateTime txtFecha;
        private DataGridView dgDetalles;
    }
}