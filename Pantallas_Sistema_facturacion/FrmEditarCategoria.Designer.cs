namespace Pantallas_Sistema_facturacion
{
    partial class FrmEditarCategoria
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
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnActualizar = new ReaLTaiizor.Controls.SpaceButton();
            txtNombreCategoria = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(42, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 43);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Titulo";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(42, 99);
            txtID.Name = "txtID";
            txtID.Size = new Size(43, 16);
            txtID.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(237, 214);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(171, 50);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnActualizar.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Image = null;
            btnActualizar.Location = new Point(42, 214);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.NoRounding = false;
            btnActualizar.Size = new Size(171, 50);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = HorizontalAlignment.Center;
            btnActualizar.Transparent = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.AllowPromptAsInput = true;
            txtNombreCategoria.AnimateReadOnly = false;
            txtNombreCategoria.AsciiOnly = false;
            txtNombreCategoria.BackgroundImageLayout = ImageLayout.None;
            txtNombreCategoria.BeepOnError = false;
            txtNombreCategoria.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreCategoria.Depth = 0;
            txtNombreCategoria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreCategoria.HidePromptOnLeave = false;
            txtNombreCategoria.HideSelection = true;
            txtNombreCategoria.Hint = "Nombre Categoria";
            txtNombreCategoria.InsertKeyMode = InsertKeyMode.Default;
            txtNombreCategoria.LeadingIcon = null;
            txtNombreCategoria.Location = new Point(42, 139);
            txtNombreCategoria.Mask = "";
            txtNombreCategoria.MaxLength = 32767;
            txtNombreCategoria.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.PasswordChar = '\0';
            txtNombreCategoria.PrefixSuffixText = null;
            txtNombreCategoria.PromptChar = '_';
            txtNombreCategoria.ReadOnly = false;
            txtNombreCategoria.RejectInputOnFirstFailure = false;
            txtNombreCategoria.ResetOnPrompt = true;
            txtNombreCategoria.ResetOnSpace = true;
            txtNombreCategoria.RightToLeft = RightToLeft.No;
            txtNombreCategoria.SelectedText = "";
            txtNombreCategoria.SelectionLength = 0;
            txtNombreCategoria.SelectionStart = 0;
            txtNombreCategoria.ShortcutsEnabled = true;
            txtNombreCategoria.Size = new Size(366, 48);
            txtNombreCategoria.SkipLiterals = true;
            txtNombreCategoria.TabIndex = 10;
            txtNombreCategoria.TabStop = false;
            txtNombreCategoria.TextAlign = HorizontalAlignment.Left;
            txtNombreCategoria.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNombreCategoria.TrailingIcon = null;
            txtNombreCategoria.UseSystemPasswordChar = false;
            txtNombreCategoria.ValidatingType = null;
            // 
            // FrmEditarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 320);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombreCategoria);
            Controls.Add(txtID);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEditarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditarCategoria";
            Load += FrmEditarCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private TextBox txtID;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnActualizar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtNombreCategoria;
    }
}