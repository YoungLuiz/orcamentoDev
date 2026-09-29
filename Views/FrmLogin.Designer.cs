namespace OrcamentoDev.Views
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
            lblUsuario = new Label();
            Senha = new Label();
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(272, 113);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += label1_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Senha.Location = new Point(272, 166);
            Senha.Name = "Senha";
            Senha.Size = new Size(54, 21);
            Senha.TabIndex = 1;
            Senha.Text = "Senha";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Coral;
            lblTitulo.Location = new Point(255, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Acesso ao sistema";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(371, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(371, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Coral;
            btnLogin.Location = new Point(333, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(Senha);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "Login - Sistema de orcamento";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label Senha;
        private Label lblTitulo;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
    }
}