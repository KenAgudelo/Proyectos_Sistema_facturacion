namespace Pantallas_Sistema_facturacion
{
    partial class FrmAcercaDe
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
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            txtDetalles = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            SuspendLayout();
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foxLabel1.ForeColor = SystemColors.ControlText;
            foxLabel1.Location = new Point(29, 12);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(625, 39);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "ACERCA DEL SISTEMA DE FACTURACION";
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetalles.HideSelection = true;
            txtDetalles.Location = new Point(29, 57);
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
            txtDetalles.Size = new Size(952, 457);
            txtDetalles.TabIndex = 1;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.UseSystemPasswordChar = false;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(861, 520);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(120, 40);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 594);
            Controls.Add(btnSalir);
            Controls.Add(txtDetalles);
            Controls.Add(foxLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAcercaDe";
            Load += FrmAcercaDe_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtDetalles;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
    }
}