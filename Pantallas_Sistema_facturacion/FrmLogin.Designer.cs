namespace Pantallas_Sistema_facturacion
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new ReaLTaiizor.Controls.HeaderLabel();
            txtUser = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPass = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnValid = new ReaLTaiizor.Controls.SpaceButton();
            btnCancel = new ReaLTaiizor.Controls.SpaceButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 250);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(22, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(15, 15, 15);
            lblTitle.Location = new Point(290, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Validar Usuario";
            // 
            // txtUser
            // 
            txtUser.AllowPromptAsInput = true;
            txtUser.AnimateReadOnly = false;
            txtUser.AsciiOnly = false;
            txtUser.BackgroundImageLayout = ImageLayout.None;
            txtUser.BeepOnError = false;
            txtUser.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.Depth = 0;
            txtUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.HidePromptOnLeave = false;
            txtUser.HideSelection = true;
            txtUser.Hint = "Usuario";
            txtUser.InsertKeyMode = InsertKeyMode.Default;
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(254, 57);
            txtUser.Mask = "";
            txtUser.MaxLength = 32767;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.PasswordChar = '\0';
            txtUser.PrefixSuffixText = null;
            txtUser.PromptChar = '_';
            txtUser.ReadOnly = false;
            txtUser.RejectInputOnFirstFailure = false;
            txtUser.ResetOnPrompt = true;
            txtUser.ResetOnSpace = true;
            txtUser.RightToLeft = RightToLeft.No;
            txtUser.SelectedText = "";
            txtUser.SelectionLength = 0;
            txtUser.SelectionStart = 0;
            txtUser.ShortcutsEnabled = true;
            txtUser.Size = new Size(250, 48);
            txtUser.SkipLiterals = true;
            txtUser.TabIndex = 2;
            txtUser.TabStop = false;
            txtUser.TextAlign = HorizontalAlignment.Left;
            txtUser.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUser.TrailingIcon = null;
            txtUser.UseSystemPasswordChar = false;
            txtUser.ValidatingType = null;
            // 
            // txtPass
            // 
            txtPass.AllowPromptAsInput = true;
            txtPass.AnimateReadOnly = false;
            txtPass.AsciiOnly = false;
            txtPass.BackgroundImageLayout = ImageLayout.None;
            txtPass.BeepOnError = false;
            txtPass.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPass.Depth = 0;
            txtPass.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPass.HidePromptOnLeave = false;
            txtPass.HideSelection = true;
            txtPass.Hint = "Contraseña";
            txtPass.InsertKeyMode = InsertKeyMode.Default;
            txtPass.LeadingIcon = null;
            txtPass.Location = new Point(254, 120);
            txtPass.Mask = "";
            txtPass.MaxLength = 32767;
            txtPass.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PrefixSuffixText = null;
            txtPass.PromptChar = '_';
            txtPass.ReadOnly = false;
            txtPass.RejectInputOnFirstFailure = false;
            txtPass.ResetOnPrompt = true;
            txtPass.ResetOnSpace = true;
            txtPass.RightToLeft = RightToLeft.No;
            txtPass.SelectedText = "";
            txtPass.SelectionLength = 0;
            txtPass.SelectionStart = 0;
            txtPass.ShortcutsEnabled = true;
            txtPass.Size = new Size(250, 48);
            txtPass.SkipLiterals = true;
            txtPass.TabIndex = 3;
            txtPass.TabStop = false;
            txtPass.TextAlign = HorizontalAlignment.Left;
            txtPass.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPass.TrailingIcon = null;
            txtPass.UseSystemPasswordChar = false;
            txtPass.ValidatingType = null;
            // 
            // btnValid
            // 
            btnValid.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnValid.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValid.Image = null;
            btnValid.Location = new Point(254, 189);
            btnValid.Name = "btnValid";
            btnValid.NoRounding = false;
            btnValid.Size = new Size(120, 40);
            btnValid.TabIndex = 4;
            btnValid.Text = "Validar";
            btnValid.TextAlignment = HorizontalAlignment.Center;
            btnValid.Transparent = false;
            btnValid.Click += btnValid_Click;
            // 
            // btnCancel
            // 
            btnCancel.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = null;
            btnCancel.Location = new Point(384, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.NoRounding = false;
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.TextAlignment = HorizontalAlignment.Center;
            btnCancel.Transparent = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(550, 250);
            Controls.Add(btnCancel);
            Controls.Add(btnValid);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HeaderLabel lblTitle;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtUser;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPass;
        private ReaLTaiizor.Controls.SpaceButton btnValid;
        private ReaLTaiizor.Controls.SpaceButton btnCancel;
    }
}
