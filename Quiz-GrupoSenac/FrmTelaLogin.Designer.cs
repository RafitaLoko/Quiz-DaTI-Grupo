namespace Quiz_GrupoSenac
{
    partial class FrmTelaLogin
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
            txtNick = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // txtNick
            // 
            txtNick.Location = new Point(284, 112);
            txtNick.Name = "txtNick";
            txtNick.PlaceholderText = "Nick";
            txtNick.Size = new Size(248, 31);
            txtNick.TabIndex = 0;
            txtNick.TextChanged += txtNick_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(330, 209);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(150, 31);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.GreenYellow;
            btnEntrar.FlatAppearance.BorderColor = Color.Yellow;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(347, 321);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 58);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // FrmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtNick);
            Name = "FrmTelaLogin";
            Text = "Tela de Login";
            Load += FrmTelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNick;
        private TextBox txtSenha;
        private Button btnEntrar;
    }
}
