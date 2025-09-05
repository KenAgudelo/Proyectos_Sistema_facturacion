namespace Pantallas_Sistema_facturacion
{
    partial class FrmListaClientes
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
            txtBuscar = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnBuscar = new ReaLTaiizor.Controls.SpaceButton();
            btnNuevo = new ReaLTaiizor.Controls.SpaceButton();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            dgClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
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
            txtBuscar.Hint = "Buscar Cliente";
            txtBuscar.InsertKeyMode = InsertKeyMode.Default;
            txtBuscar.LeadingIcon = null;
            txtBuscar.Location = new Point(54, 110);
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
            txtBuscar.TabIndex = 1;
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
            btnBuscar.Location = new Point(361, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.NoRounding = false;
            btnBuscar.Size = new Size(126, 48);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlignment = HorizontalAlignment.Center;
            btnBuscar.Transparent = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnNuevo.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.Image = null;
            btnNuevo.Location = new Point(863, 110);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.NoRounding = false;
            btnNuevo.Size = new Size(126, 48);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlignment = HorizontalAlignment.Center;
            btnNuevo.Transparent = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(863, 482);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(126, 48);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = SystemColors.ControlText;
            foxLabel1.Location = new Point(200, 50);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(403, 34);
            foxLabel1.TabIndex = 6;
            foxLabel1.Text = "ADMINISTRACIÓN CLIENTES";
            // 
            // dgClientes
            // 
            dgClientes.AllowUserToAddRows = false;
            dgClientes.AllowUserToDeleteRows = false;
            dgClientes.BackgroundColor = Color.Silver;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(54, 164);
            dgClientes.Name = "dgClientes";
            dgClientes.ReadOnly = true;
            dgClientes.Size = new Size(935, 312);
            dgClientes.TabIndex = 7;
            dgClientes.CellContentClick += dgClientes_CellContentClick;
            // 
            // FrmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1011, 558);
            Controls.Add(dgClientes);
            Controls.Add(foxLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListaClientes";
            Load += FrmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtBuscar;
        private ReaLTaiizor.Controls.SpaceButton btnBuscar;
        private ReaLTaiizor.Controls.SpaceButton btnNuevo;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private DataGridView dgClientes;
    }
}