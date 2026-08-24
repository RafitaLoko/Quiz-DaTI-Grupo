namespace Quiz_GrupoSenac.Forms
{
    partial class CadastrarPerguntas_ADMIN_
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
            lblEnunciadoDaPergunta = new Label();
            txtEnuciado = new TextBox();
            lblTipoPergunta = new Label();
            dudTipoPergunta = new DomainUpDown();
            lblNivelPergunta = new Label();
            dudNivelPergunta = new DomainUpDown();
            lblTemaPergunta = new Label();
            dudTemaPergunta = new DomainUpDown();
            lblPontuaçãoPerguntas = new Label();
            dudPontuacaoPergunta = new DomainUpDown();
            SuspendLayout();
            // 
            // lblEnunciadoDaPergunta
            // 
            lblEnunciadoDaPergunta.AutoSize = true;
            lblEnunciadoDaPergunta.Location = new Point(2, 2);
            lblEnunciadoDaPergunta.Name = "lblEnunciadoDaPergunta";
            lblEnunciadoDaPergunta.Size = new Size(194, 25);
            lblEnunciadoDaPergunta.TabIndex = 0;
            lblEnunciadoDaPergunta.Text = "Enunciado da Pergunta";
            // 
            // txtEnuciado
            // 
            txtEnuciado.Font = new Font("Segoe UI", 9F);
            txtEnuciado.Location = new Point(2, 30);
            txtEnuciado.Multiline = true;
            txtEnuciado.Name = "txtEnuciado";
            txtEnuciado.PlaceholderText = "Escreva a Pergunta";
            txtEnuciado.Size = new Size(311, 138);
            txtEnuciado.TabIndex = 1;
            // 
            // lblTipoPergunta
            // 
            lblTipoPergunta.AutoSize = true;
            lblTipoPergunta.Location = new Point(2, 189);
            lblTipoPergunta.Name = "lblTipoPergunta";
            lblTipoPergunta.Size = new Size(147, 25);
            lblTipoPergunta.TabIndex = 2;
            lblTipoPergunta.Text = "Tipo de Pergunta";
            // 
            // dudTipoPergunta
            // 
            dudTipoPergunta.Location = new Point(2, 217);
            dudTipoPergunta.Name = "dudTipoPergunta";
            dudTipoPergunta.Size = new Size(180, 31);
            dudTipoPergunta.TabIndex = 3;
            // 
            // lblNivelPergunta
            // 
            lblNivelPergunta.AutoSize = true;
            lblNivelPergunta.Location = new Point(2, 269);
            lblNivelPergunta.Name = "lblNivelPergunta";
            lblNivelPergunta.Size = new Size(153, 25);
            lblNivelPergunta.TabIndex = 4;
            lblNivelPergunta.Text = "Nivel da pergunta";
            // 
            // dudNivelPergunta
            // 
            dudNivelPergunta.Location = new Point(2, 297);
            dudNivelPergunta.Name = "dudNivelPergunta";
            dudNivelPergunta.Size = new Size(180, 31);
            dudNivelPergunta.TabIndex = 5;
            // 
            // lblTemaPergunta
            // 
            lblTemaPergunta.AutoSize = true;
            lblTemaPergunta.Location = new Point(2, 347);
            lblTemaPergunta.Name = "lblTemaPergunta";
            lblTemaPergunta.Size = new Size(53, 25);
            lblTemaPergunta.TabIndex = 6;
            lblTemaPergunta.Text = "Tema";
            // 
            // dudTemaPergunta
            // 
            dudTemaPergunta.Location = new Point(2, 375);
            dudTemaPergunta.Name = "dudTemaPergunta";
            dudTemaPergunta.Size = new Size(180, 31);
            dudTemaPergunta.TabIndex = 7;
            // 
            // lblPontuaçãoPerguntas
            // 
            lblPontuaçãoPerguntas.AutoSize = true;
            lblPontuaçãoPerguntas.Location = new Point(2, 418);
            lblPontuaçãoPerguntas.Name = "lblPontuaçãoPerguntas";
            lblPontuaçãoPerguntas.Size = new Size(95, 25);
            lblPontuaçãoPerguntas.TabIndex = 8;
            lblPontuaçãoPerguntas.Text = "Pontuação";
            // 
            // dudPontuacaoPergunta
            // 
            dudPontuacaoPergunta.Location = new Point(2, 446);
            dudPontuacaoPergunta.Name = "dudPontuacaoPergunta";
            dudPontuacaoPergunta.Size = new Size(180, 31);
            dudPontuacaoPergunta.TabIndex = 9;
            // 
            // CadastrarPerguntas_ADMIN_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 515);
            Controls.Add(dudPontuacaoPergunta);
            Controls.Add(lblPontuaçãoPerguntas);
            Controls.Add(dudTemaPergunta);
            Controls.Add(lblTemaPergunta);
            Controls.Add(dudNivelPergunta);
            Controls.Add(lblNivelPergunta);
            Controls.Add(dudTipoPergunta);
            Controls.Add(lblTipoPergunta);
            Controls.Add(txtEnuciado);
            Controls.Add(lblEnunciadoDaPergunta);
            Name = "CadastrarPerguntas_ADMIN_";
            Text = "CadastrarPerguntas_ADMIN_";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnunciadoDaPergunta;
        private TextBox txtEnuciado;
        private Label lblTipoPergunta;
        private DomainUpDown dudTipoPergunta;
        private Label lblNivelPergunta;
        private DomainUpDown dudNivelPergunta;
        private Label lblTemaPergunta;
        private DomainUpDown dudTemaPergunta;
        private Label lblPontuaçãoPerguntas;
        private DomainUpDown dudPontuacaoPergunta;
    }
}