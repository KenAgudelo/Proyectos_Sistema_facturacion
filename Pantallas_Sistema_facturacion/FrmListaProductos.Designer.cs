namespace Pantallas_Sistema_facturacion
{
    partial class FrmListaProductos
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
            dgProductos = new DataGridView();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnNuevo = new ReaLTaiizor.Controls.SpaceButton();
            btnBuscar = new ReaLTaiizor.Controls.SpaceButton();
            txtBuscar = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.AllowUserToDeleteRows = false;
            dgProductos.BackgroundColor = Color.Silver;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(46, 152);
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.Size = new Size(781, 258);
            dgProductos.TabIndex = 13;
            dgProductos.CellContentClick += dgProductos_CellContentClick;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = SystemColors.ControlText;
            foxLabel1.Location = new Point(213, 36);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(441, 34);
            foxLabel1.TabIndex = 12;
            foxLabel1.Text = "ADMINISTRACIÓN PRODUCTOS";
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(701, 416);
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
            btnNuevo.Location = new Point(701, 98);
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
            txtBuscar.Hint = "Buscar Productos";
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
            // FrmListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(862, 497);
            Controls.Add(dgProductos);
            Controls.Add(foxLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaProductos";
            Text = "frmListaProductos";
            Load += FrmListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProductos;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnNuevo;
        private ReaLTaiizor.Controls.SpaceButton btnBuscar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtBuscar;
    }
}