namespace Pantallas_Sistema_facturacion
{
    partial class FrmListaEmpleados
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
            dgEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(192, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(441, 34);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "ADMINISTRACIÓN EMPLEADOS";
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(680, 403);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(126, 48);
            btnSalir.TabIndex = 23;
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
            btnNuevo.Location = new Point(680, 85);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.NoRounding = false;
            btnNuevo.Size = new Size(126, 48);
            btnNuevo.TabIndex = 22;
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
            txtBuscar.Hint = "Buscar Empleados";
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(25, 85);
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
            txtBuscar.TabIndex = 20;
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
            btnBuscar.Location = new Point(332, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoRounding = false;
            btnBuscar.Size = new Size(126, 48);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlignment = HorizontalAlignment.Center;
            btnBuscar.Transparent = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgEmpleados
            // 
            dgEmpleados.AllowUserToAddRows = false;
            dgEmpleados.AllowUserToDeleteRows = false;
            dgEmpleados.BackgroundColor = Color.Silver;
            dgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleados.Location = new Point(25, 139);
            dgEmpleados.Name = "dgEmpleados";
            dgEmpleados.ReadOnly = true;
            dgEmpleados.Size = new Size(781, 258);
            dgEmpleados.TabIndex = 25;
            dgEmpleados.CellContentClick += dgEmpleados_CellContentClick;
            // 
            // FrmListaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(830, 474);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dgEmpleados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmListaEmpleados";
            Load += FrmListaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnNuevo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtBuscar;
        private ReaLTaiizor.Controls.SpaceButton btnBuscar;
        private DataGridView dgEmpleados;
    }
}