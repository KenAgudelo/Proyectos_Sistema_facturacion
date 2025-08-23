namespace Pantallas_Sistema_facturacion
{
    partial class FrmEditarProducto
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
            txtNombreProd = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtReferencia = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPrecioCompra = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPrecioVenta = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtStock = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCategoria = new ReaLTaiizor.Controls.MaterialComboBox();
            btnActualizar = new ReaLTaiizor.Controls.SpaceButton();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            txtDetalles = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            txtImagen = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(306, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(415, 29);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Titulo";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ScrollBar;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(107, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 2;
            // 
            // txtNombreProd
            // 
            txtNombreProd.AllowPromptAsInput = true;
            txtNombreProd.AnimateReadOnly = false;
            txtNombreProd.AsciiOnly = false;
            txtNombreProd.BackgroundImageLayout = ImageLayout.None;
            txtNombreProd.BeepOnError = false;
            txtNombreProd.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreProd.Depth = 0;
            txtNombreProd.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreProd.HidePromptOnLeave = false;
            txtNombreProd.HideSelection = true;
            txtNombreProd.Hint = "Nombre Producto";
            txtNombreProd.InsertKeyMode = InsertKeyMode.Default;
            txtNombreProd.LeadingIcon = null;
            txtNombreProd.Location = new Point(107, 80);
            txtNombreProd.Mask = "";
            txtNombreProd.MaxLength = 32767;
            txtNombreProd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.PasswordChar = '\0';
            txtNombreProd.PrefixSuffixText = null;
            txtNombreProd.PromptChar = '_';
            txtNombreProd.ReadOnly = false;
            txtNombreProd.RejectInputOnFirstFailure = false;
            txtNombreProd.ResetOnPrompt = true;
            txtNombreProd.ResetOnSpace = true;
            txtNombreProd.RightToLeft = RightToLeft.No;
            txtNombreProd.SelectedText = "";
            txtNombreProd.SelectionLength = 0;
            txtNombreProd.SelectionStart = 0;
            txtNombreProd.ShortcutsEnabled = true;
            txtNombreProd.Size = new Size(392, 48);
            txtNombreProd.SkipLiterals = true;
            txtNombreProd.TabIndex = 3;
            txtNombreProd.TabStop = false;
            txtNombreProd.TextAlign = HorizontalAlignment.Left;
            txtNombreProd.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreProd.TrailingIcon = null;
            txtNombreProd.UseSystemPasswordChar = false;
            txtNombreProd.ValidatingType = null;
            // 
            // txtReferencia
            // 
            txtReferencia.AllowPromptAsInput = true;
            txtReferencia.AnimateReadOnly = false;
            txtReferencia.AsciiOnly = false;
            txtReferencia.BackgroundImageLayout = ImageLayout.None;
            txtReferencia.BeepOnError = false;
            txtReferencia.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtReferencia.Depth = 0;
            txtReferencia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReferencia.HidePromptOnLeave = false;
            txtReferencia.HideSelection = true;
            txtReferencia.Hint = "Codigo Referencia";
            txtReferencia.InsertKeyMode = InsertKeyMode.Default;
            txtReferencia.LeadingIcon = null;
            txtReferencia.Location = new Point(107, 160);
            txtReferencia.Mask = "";
            txtReferencia.MaxLength = 32767;
            txtReferencia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtReferencia.Name = "txtReferencia";
            txtReferencia.PasswordChar = '\0';
            txtReferencia.PrefixSuffixText = null;
            txtReferencia.PromptChar = '_';
            txtReferencia.ReadOnly = false;
            txtReferencia.RejectInputOnFirstFailure = false;
            txtReferencia.ResetOnPrompt = true;
            txtReferencia.ResetOnSpace = true;
            txtReferencia.RightToLeft = RightToLeft.No;
            txtReferencia.SelectedText = "";
            txtReferencia.SelectionLength = 0;
            txtReferencia.SelectionStart = 0;
            txtReferencia.ShortcutsEnabled = true;
            txtReferencia.Size = new Size(392, 48);
            txtReferencia.SkipLiterals = true;
            txtReferencia.TabIndex = 4;
            txtReferencia.TabStop = false;
            txtReferencia.TextAlign = HorizontalAlignment.Left;
            txtReferencia.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtReferencia.TrailingIcon = null;
            txtReferencia.UseSystemPasswordChar = false;
            txtReferencia.ValidatingType = null;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.AllowPromptAsInput = true;
            txtPrecioCompra.AnimateReadOnly = false;
            txtPrecioCompra.AsciiOnly = false;
            txtPrecioCompra.BackgroundImageLayout = ImageLayout.None;
            txtPrecioCompra.BeepOnError = false;
            txtPrecioCompra.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecioCompra.Depth = 0;
            txtPrecioCompra.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioCompra.HidePromptOnLeave = false;
            txtPrecioCompra.HideSelection = true;
            txtPrecioCompra.Hint = "Precio Compra";
            txtPrecioCompra.InsertKeyMode = InsertKeyMode.Default;
            txtPrecioCompra.LeadingIcon = null;
            txtPrecioCompra.Location = new Point(107, 240);
            txtPrecioCompra.Mask = "";
            txtPrecioCompra.MaxLength = 32767;
            txtPrecioCompra.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.PasswordChar = '\0';
            txtPrecioCompra.PrefixSuffixText = null;
            txtPrecioCompra.PromptChar = '_';
            txtPrecioCompra.ReadOnly = false;
            txtPrecioCompra.RejectInputOnFirstFailure = false;
            txtPrecioCompra.ResetOnPrompt = true;
            txtPrecioCompra.ResetOnSpace = true;
            txtPrecioCompra.RightToLeft = RightToLeft.No;
            txtPrecioCompra.SelectedText = "";
            txtPrecioCompra.SelectionLength = 0;
            txtPrecioCompra.SelectionStart = 0;
            txtPrecioCompra.ShortcutsEnabled = true;
            txtPrecioCompra.Size = new Size(392, 48);
            txtPrecioCompra.SkipLiterals = true;
            txtPrecioCompra.TabIndex = 5;
            txtPrecioCompra.TabStop = false;
            txtPrecioCompra.TextAlign = HorizontalAlignment.Left;
            txtPrecioCompra.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecioCompra.TrailingIcon = null;
            txtPrecioCompra.UseSystemPasswordChar = false;
            txtPrecioCompra.ValidatingType = null;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.AllowPromptAsInput = true;
            txtPrecioVenta.AnimateReadOnly = false;
            txtPrecioVenta.AsciiOnly = false;
            txtPrecioVenta.BackgroundImageLayout = ImageLayout.None;
            txtPrecioVenta.BeepOnError = false;
            txtPrecioVenta.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecioVenta.Depth = 0;
            txtPrecioVenta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecioVenta.HidePromptOnLeave = false;
            txtPrecioVenta.HideSelection = true;
            txtPrecioVenta.Hint = "Precio Venta";
            txtPrecioVenta.InsertKeyMode = InsertKeyMode.Default;
            txtPrecioVenta.LeadingIcon = null;
            txtPrecioVenta.Location = new Point(107, 320);
            txtPrecioVenta.Mask = "";
            txtPrecioVenta.MaxLength = 32767;
            txtPrecioVenta.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PasswordChar = '\0';
            txtPrecioVenta.PrefixSuffixText = null;
            txtPrecioVenta.PromptChar = '_';
            txtPrecioVenta.ReadOnly = false;
            txtPrecioVenta.RejectInputOnFirstFailure = false;
            txtPrecioVenta.ResetOnPrompt = true;
            txtPrecioVenta.ResetOnSpace = true;
            txtPrecioVenta.RightToLeft = RightToLeft.No;
            txtPrecioVenta.SelectedText = "";
            txtPrecioVenta.SelectionLength = 0;
            txtPrecioVenta.SelectionStart = 0;
            txtPrecioVenta.ShortcutsEnabled = true;
            txtPrecioVenta.Size = new Size(392, 48);
            txtPrecioVenta.SkipLiterals = true;
            txtPrecioVenta.TabIndex = 6;
            txtPrecioVenta.TabStop = false;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Left;
            txtPrecioVenta.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrecioVenta.TrailingIcon = null;
            txtPrecioVenta.UseSystemPasswordChar = false;
            txtPrecioVenta.ValidatingType = null;
            // 
            // txtStock
            // 
            txtStock.AllowPromptAsInput = true;
            txtStock.AnimateReadOnly = false;
            txtStock.AsciiOnly = false;
            txtStock.BackgroundImageLayout = ImageLayout.None;
            txtStock.BeepOnError = false;
            txtStock.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtStock.Depth = 0;
            txtStock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStock.HidePromptOnLeave = false;
            txtStock.HideSelection = true;
            txtStock.Hint = "Cantidad Stock";
            txtStock.InsertKeyMode = InsertKeyMode.Default;
            txtStock.LeadingIcon = null;
            txtStock.Location = new Point(107, 400);
            txtStock.Mask = "";
            txtStock.MaxLength = 32767;
            txtStock.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtStock.Name = "txtStock";
            txtStock.PasswordChar = '\0';
            txtStock.PrefixSuffixText = null;
            txtStock.PromptChar = '_';
            txtStock.ReadOnly = false;
            txtStock.RejectInputOnFirstFailure = false;
            txtStock.ResetOnPrompt = true;
            txtStock.ResetOnSpace = true;
            txtStock.RightToLeft = RightToLeft.No;
            txtStock.SelectedText = "";
            txtStock.SelectionLength = 0;
            txtStock.SelectionStart = 0;
            txtStock.ShortcutsEnabled = true;
            txtStock.Size = new Size(392, 48);
            txtStock.SkipLiterals = true;
            txtStock.TabIndex = 7;
            txtStock.TabStop = false;
            txtStock.TextAlign = HorizontalAlignment.Left;
            txtStock.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtStock.TrailingIcon = null;
            txtStock.UseSystemPasswordChar = false;
            txtStock.ValidatingType = null;
            // 
            // txtCategoria
            // 
            txtCategoria.AutoResize = false;
            txtCategoria.BackColor = Color.FromArgb(255, 255, 255);
            txtCategoria.Depth = 0;
            txtCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            txtCategoria.DropDownHeight = 174;
            txtCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategoria.DropDownWidth = 121;
            txtCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Hint = "Categoria";
            txtCategoria.IntegralHeight = false;
            txtCategoria.ItemHeight = 43;
            txtCategoria.Location = new Point(558, 79);
            txtCategoria.MaxDropDownItems = 4;
            txtCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(392, 49);
            txtCategoria.StartIndex = 0;
            txtCategoria.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnActualizar.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = null;
            btnActualizar.Location = new Point(107, 493);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.NoRounding = false;
            btnActualizar.Size = new Size(392, 48);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = HorizontalAlignment.Center;
            btnActualizar.Transparent = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(558, 493);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(392, 48);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.HideSelection = true;
            txtDetalles.Hint = "Detalles";
            txtDetalles.Location = new Point(558, 240);
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
            txtDetalles.Size = new Size(392, 208);
            txtDetalles.TabIndex = 10;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.UseSystemPasswordChar = false;
            // 
            // txtImagen
            // 
            txtImagen.AllowPromptAsInput = true;
            txtImagen.AnimateReadOnly = false;
            txtImagen.AsciiOnly = false;
            txtImagen.BackgroundImageLayout = ImageLayout.None;
            txtImagen.BeepOnError = false;
            txtImagen.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtImagen.Depth = 0;
            txtImagen.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImagen.HidePromptOnLeave = false;
            txtImagen.HideSelection = true;
            txtImagen.Hint = "Ruta Imagen";
            txtImagen.InsertKeyMode = InsertKeyMode.Default;
            txtImagen.LeadingIcon = null;
            txtImagen.Location = new Point(558, 160);
            txtImagen.Mask = "";
            txtImagen.MaxLength = 32767;
            txtImagen.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtImagen.Name = "txtImagen";
            txtImagen.PasswordChar = '\0';
            txtImagen.PrefixSuffixText = null;
            txtImagen.PromptChar = '_';
            txtImagen.ReadOnly = false;
            txtImagen.RejectInputOnFirstFailure = false;
            txtImagen.ResetOnPrompt = true;
            txtImagen.ResetOnSpace = true;
            txtImagen.RightToLeft = RightToLeft.No;
            txtImagen.SelectedText = "";
            txtImagen.SelectionLength = 0;
            txtImagen.SelectionStart = 0;
            txtImagen.ShortcutsEnabled = true;
            txtImagen.Size = new Size(392, 48);
            txtImagen.SkipLiterals = true;
            txtImagen.TabIndex = 9;
            txtImagen.TabStop = false;
            txtImagen.TextAlign = HorizontalAlignment.Left;
            txtImagen.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtImagen.TrailingIcon = null;
            txtImagen.UseSystemPasswordChar = false;
            txtImagen.ValidatingType = null;
            // 
            // FrmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1037, 580);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtDetalles);
            Controls.Add(txtImagen);
            Controls.Add(txtCategoria);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtReferencia);
            Controls.Add(txtNombreProd);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarProducto";
            Load += FrmEditarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private TextBox txtID;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNombreProd;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtReferencia;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrecioCompra;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrecioVenta;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtStock;
        private ReaLTaiizor.Controls.MaterialComboBox txtCategoria;
        private ReaLTaiizor.Controls.SpaceButton btnActualizar;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDetalles;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtImagen;
    }
}