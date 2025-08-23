namespace Pantallas_Sistema_facturacion
{
    partial class FrmInformes
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
            dgPantalla = new DataGridView();
            txtFechaFinal = new ReaLTaiizor.Controls.PoisonDateTime();
            txtOrdenar = new ReaLTaiizor.Controls.MaterialComboBox();
            btnSalir = new ReaLTaiizor.Controls.SpaceButton();
            btnGenerarInforme = new ReaLTaiizor.Controls.SpaceButton();
            txtInforme = new ReaLTaiizor.Controls.MaterialComboBox();
            lblTitulo = new ReaLTaiizor.Controls.FoxLabel();
            txtFechaInicio = new ReaLTaiizor.Controls.PoisonDateTime();
            rdPantalla = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdPDF = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdExcel = new ReaLTaiizor.Controls.MaterialRadioButton();
            lblFechaInicio = new ReaLTaiizor.Controls.MaterialLabel();
            lblFechaFinal = new ReaLTaiizor.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dgPantalla).BeginInit();
            SuspendLayout();
            // 
            // dgPantalla
            // 
            dgPantalla.AllowUserToAddRows = false;
            dgPantalla.AllowUserToDeleteRows = false;
            dgPantalla.BackgroundColor = Color.Silver;
            dgPantalla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPantalla.Location = new Point(73, 293);
            dgPantalla.Name = "dgPantalla";
            dgPantalla.ReadOnly = true;
            dgPantalla.Size = new Size(843, 181);
            dgPantalla.TabIndex = 41;
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            txtFechaFinal.Location = new Point(524, 195);
            txtFechaFinal.MinimumSize = new Size(0, 29);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(392, 29);
            txtFechaFinal.TabIndex = 40;
            // 
            // txtOrdenar
            // 
            txtOrdenar.AutoResize = false;
            txtOrdenar.BackColor = Color.FromArgb(255, 255, 255);
            txtOrdenar.Depth = 0;
            txtOrdenar.DrawMode = DrawMode.OwnerDrawVariable;
            txtOrdenar.DropDownHeight = 174;
            txtOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            txtOrdenar.DropDownWidth = 121;
            txtOrdenar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtOrdenar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtOrdenar.FormattingEnabled = true;
            txtOrdenar.Hint = "Ordenar Por";
            txtOrdenar.IntegralHeight = false;
            txtOrdenar.ItemHeight = 43;
            txtOrdenar.Location = new Point(524, 109);
            txtOrdenar.MaxDropDownItems = 4;
            txtOrdenar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtOrdenar.Name = "txtOrdenar";
            txtOrdenar.Size = new Size(392, 49);
            txtOrdenar.StartIndex = 0;
            txtOrdenar.TabIndex = 39;
            // 
            // btnSalir
            // 
            btnSalir.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnSalir.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = null;
            btnSalir.Location = new Point(524, 503);
            btnSalir.Name = "btnSalir";
            btnSalir.NoRounding = false;
            btnSalir.Size = new Size(392, 48);
            btnSalir.TabIndex = 37;
            btnSalir.Text = "Salir";
            btnSalir.TextAlignment = HorizontalAlignment.Center;
            btnSalir.Transparent = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnGenerarInforme.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarInforme.Image = null;
            btnGenerarInforme.Location = new Point(73, 503);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.NoRounding = false;
            btnGenerarInforme.Size = new Size(392, 48);
            btnGenerarInforme.TabIndex = 36;
            btnGenerarInforme.Text = "Generar Informe";
            btnGenerarInforme.TextAlignment = HorizontalAlignment.Center;
            btnGenerarInforme.Transparent = false;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
            // 
            // txtInforme
            // 
            txtInforme.AutoResize = false;
            txtInforme.BackColor = Color.FromArgb(255, 255, 255);
            txtInforme.Depth = 0;
            txtInforme.DrawMode = DrawMode.OwnerDrawVariable;
            txtInforme.DropDownHeight = 174;
            txtInforme.DropDownStyle = ComboBoxStyle.DropDownList;
            txtInforme.DropDownWidth = 121;
            txtInforme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtInforme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtInforme.FormattingEnabled = true;
            txtInforme.Hint = "Seleccione informe";
            txtInforme.IntegralHeight = false;
            txtInforme.ItemHeight = 43;
            txtInforme.Location = new Point(73, 109);
            txtInforme.MaxDropDownItems = 4;
            txtInforme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtInforme.Name = "txtInforme";
            txtInforme.Size = new Size(392, 49);
            txtInforme.StartIndex = 0;
            txtInforme.TabIndex = 35;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(272, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(455, 29);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "GENERADOR DE INFORMES DE FACTURACION";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            txtFechaInicio.Location = new Point(73, 195);
            txtFechaInicio.MinimumSize = new Size(0, 29);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(392, 29);
            txtFechaInicio.TabIndex = 42;
            // 
            // rdPantalla
            // 
            rdPantalla.AutoSize = true;
            rdPantalla.Depth = 0;
            rdPantalla.Location = new Point(150, 238);
            rdPantalla.Margin = new Padding(0);
            rdPantalla.MouseLocation = new Point(-1, -1);
            rdPantalla.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdPantalla.Name = "rdPantalla";
            rdPantalla.Ripple = true;
            rdPantalla.Size = new Size(115, 37);
            rdPantalla.TabIndex = 43;
            rdPantalla.TabStop = true;
            rdPantalla.Text = "En pantalla";
            rdPantalla.UseAccentColor = false;
            rdPantalla.UseVisualStyleBackColor = true;
            // 
            // rdPDF
            // 
            rdPDF.AutoSize = true;
            rdPDF.Depth = 0;
            rdPDF.Location = new Point(470, 238);
            rdPDF.Margin = new Padding(0);
            rdPDF.MouseLocation = new Point(-1, -1);
            rdPDF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdPDF.Name = "rdPDF";
            rdPDF.Ripple = true;
            rdPDF.Size = new Size(65, 37);
            rdPDF.TabIndex = 44;
            rdPDF.TabStop = true;
            rdPDF.Text = "PDF";
            rdPDF.UseAccentColor = false;
            rdPDF.UseVisualStyleBackColor = true;
            // 
            // rdExcel
            // 
            rdExcel.AutoSize = true;
            rdExcel.Depth = 0;
            rdExcel.Location = new Point(790, 238);
            rdExcel.Margin = new Padding(0);
            rdExcel.MouseLocation = new Point(-1, -1);
            rdExcel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdExcel.Name = "rdExcel";
            rdExcel.Ripple = true;
            rdExcel.Size = new Size(72, 37);
            rdExcel.TabIndex = 45;
            rdExcel.TabStop = true;
            rdExcel.Text = "Excel";
            rdExcel.UseAccentColor = false;
            rdExcel.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Depth = 0;
            lblFechaInicio.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFechaInicio.ForeColor = SystemColors.ScrollBar;
            lblFechaInicio.Location = new Point(73, 173);
            lblFechaInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 19);
            lblFechaInicio.TabIndex = 46;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Depth = 0;
            lblFechaFinal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFechaFinal.ForeColor = SystemColors.ScrollBar;
            lblFechaFinal.Location = new Point(524, 173);
            lblFechaFinal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(83, 19);
            lblFechaFinal.TabIndex = 47;
            lblFechaFinal.Text = "Fecha Final";
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(989, 592);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblFechaInicio);
            Controls.Add(rdExcel);
            Controls.Add(rdPDF);
            Controls.Add(rdPantalla);
            Controls.Add(txtFechaInicio);
            Controls.Add(dgPantalla);
            Controls.Add(txtFechaFinal);
            Controls.Add(txtOrdenar);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerarInforme);
            Controls.Add(txtInforme);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInformes";
            Load += FrmInformes_Load;
            ((System.ComponentModel.ISupportInitialize)dgPantalla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPantalla;
        private ReaLTaiizor.Controls.PoisonDateTime txtFechaFinal;
        private ReaLTaiizor.Controls.MaterialComboBox txtOrdenar;
        private ReaLTaiizor.Controls.SpaceButton btnSalir;
        private ReaLTaiizor.Controls.SpaceButton btnGenerarInforme;
        private ReaLTaiizor.Controls.MaterialComboBox txtInforme;
        private ReaLTaiizor.Controls.FoxLabel lblTitulo;
        private ReaLTaiizor.Controls.PoisonDateTime txtFechaInicio;
        private ReaLTaiizor.Controls.MaterialRadioButton rdPantalla;
        private ReaLTaiizor.Controls.MaterialRadioButton rdPDF;
        private ReaLTaiizor.Controls.MaterialRadioButton rdExcel;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaInicio;
        private ReaLTaiizor.Controls.MaterialLabel lblFechaFinal;
    }
}