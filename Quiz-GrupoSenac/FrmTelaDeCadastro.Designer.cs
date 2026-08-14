namespace Quiz_GrupoSenac
{
    partial class FrmTelaDeCadastro
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
            lblNomeCompletoTelaCadastro = new Label();
            txtNomeCompletoTelaCadastro = new TextBox();
            lblNicknameTelaCadastro = new Label();
            txtNickTelaCadastro = new TextBox();
            lblDataNascimento = new Label();
            txtDataNascimentoTelaCadastro = new TextBox();
            SuspendLayout();
            // 
            // lblNomeCompletoTelaCadastro
            // 
            lblNomeCompletoTelaCadastro.AutoSize = true;
            lblNomeCompletoTelaCadastro.Location = new Point(13, 10);
            lblNomeCompletoTelaCadastro.Name = "lblNomeCompletoTelaCadastro";
            lblNomeCompletoTelaCadastro.Size = new Size(142, 25);
            lblNomeCompletoTelaCadastro.TabIndex = 0;
            lblNomeCompletoTelaCadastro.Text = "Nome completo";
            // 
            // txtNomeCompletoTelaCadastro
            // 
            txtNomeCompletoTelaCadastro.Location = new Point(13, 38);
            txtNomeCompletoTelaCadastro.Name = "txtNomeCompletoTelaCadastro";
            txtNomeCompletoTelaCadastro.Size = new Size(246, 31);
            txtNomeCompletoTelaCadastro.TabIndex = 1;
            // 
            // lblNicknameTelaCadastro
            // 
            lblNicknameTelaCadastro.AutoSize = true;
            lblNicknameTelaCadastro.Location = new Point(13, 93);
            lblNicknameTelaCadastro.Name = "lblNicknameTelaCadastro";
            lblNicknameTelaCadastro.Size = new Size(90, 25);
            lblNicknameTelaCadastro.TabIndex = 2;
            lblNicknameTelaCadastro.Text = "Nickname";
            // 
            // txtNickTelaCadastro
            // 
            txtNickTelaCadastro.Location = new Point(13, 121);
            txtNickTelaCadastro.Name = "txtNickTelaCadastro";
            txtNickTelaCadastro.Size = new Size(246, 31);
            txtNickTelaCadastro.TabIndex = 3;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(13, 178);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(170, 25);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // txtDataNascimentoTelaCadastro
            // 
            txtDataNascimentoTelaCadastro.Location = new Point(13, 206);
            txtDataNascimentoTelaCadastro.Name = "txtDataNascimentoTelaCadastro";
            txtDataNascimentoTelaCadastro.Size = new Size(204, 31);
            txtDataNascimentoTelaCadastro.TabIndex = 5;
            // 
            // FrmTelaDeCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDataNascimentoTelaCadastro);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtNickTelaCadastro);
            Controls.Add(lblNicknameTelaCadastro);
            Controls.Add(txtNomeCompletoTelaCadastro);
            Controls.Add(lblNomeCompletoTelaCadastro);
            Name = "FrmTelaDeCadastro";
            Text = "FrmTelaDeCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompletoTelaCadastro;
        private TextBox txtNomeCompletoTelaCadastro;
        private Label lblNicknameTelaCadastro;
        private TextBox txtNickTelaCadastro;
        private Label lblDataNascimento;
        private TextBox txtDataNascimentoTelaCadastro;
    }
}