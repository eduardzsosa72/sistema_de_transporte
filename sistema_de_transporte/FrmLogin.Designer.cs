namespace sistema_de_transporte
{
    partial class FrmLogin
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
            label1 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtPassword = new TextBox();
            btnIniciar = new Button();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 133);
            label1.Name = "label1";
            label1.Size = new Size(109, 41);
            label1.TabIndex = 0;
            label1.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 253);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(348, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(521, 47);
            txtCorreo.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 247);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(355, 47);
            txtPassword.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(177, 482);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(194, 77);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(690, 482);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(188, 82);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1112, 636);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIniciar);
            Controls.Add(txtPassword);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmLogin";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCorreo;
        private TextBox txtPassword;
        private Button btnIniciar;
        private Button btnRegistrar;
    }
}