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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPerguntas_ADMIN_));
            lblEnunciadoDaPergunta = new Label();
            txtEnuciado = new TextBox();
            lblAlternativas = new Label();
            label1 = new Label();
            lblAlternativa1 = new Label();
            lblAlternativa2 = new Label();
            lblAlternativa3 = new Label();
            lblAlternativa4 = new Label();
            txtAlternativa1 = new TextBox();
            txtAlternativa2 = new TextBox();
            txtAlternativa3 = new TextBox();
            txtAlternativa4 = new TextBox();
            label2 = new Label();
            btnLimpar = new Button();
            btnCadastrarPergunta = new Button();
            cbPontuacaoPergunta = new ComboBox();
            cbTemaPergunta = new ComboBox();
            cbNivelPergunta = new ComboBox();
            cbTipoPergunta = new ComboBox();
            lblPontuaçãoPerguntas = new Label();
            lblTemaPergunta = new Label();
            lblNivelPergunta = new Label();
            lblTipoPergunta = new Label();
            cbRespostaCorreta = new ComboBox();
            SuspendLayout();
            // 
            // lblEnunciadoDaPergunta
            // 
            lblEnunciadoDaPergunta.AutoSize = true;
            lblEnunciadoDaPergunta.Location = new Point(12, 3);
            lblEnunciadoDaPergunta.Name = "lblEnunciadoDaPergunta";
            lblEnunciadoDaPergunta.Size = new Size(194, 25);
            lblEnunciadoDaPergunta.TabIndex = 0;
            lblEnunciadoDaPergunta.Text = "Enunciado da Pergunta";
            // 
            // txtEnuciado
            // 
            txtEnuciado.Font = new Font("Segoe UI", 9F);
            txtEnuciado.Location = new Point(12, 31);
            txtEnuciado.Multiline = true;
            txtEnuciado.Name = "txtEnuciado";
            txtEnuciado.PlaceholderText = "Escreva a Pergunta";
            txtEnuciado.Size = new Size(311, 138);
            txtEnuciado.TabIndex = 1;
            // 
            // lblAlternativas
            // 
            lblAlternativas.AutoSize = true;
            lblAlternativas.Location = new Point(507, 2);
            lblAlternativas.Name = "lblAlternativas";
            lblAlternativas.Size = new Size(104, 25);
            lblAlternativas.TabIndex = 10;
            lblAlternativas.Text = "Alternativas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 11;
            // 
            // lblAlternativa1
            // 
            lblAlternativa1.AutoSize = true;
            lblAlternativa1.BackColor = SystemColors.ActiveCaption;
            lblAlternativa1.Location = new Point(414, 45);
            lblAlternativa1.Name = "lblAlternativa1";
            lblAlternativa1.Size = new Size(22, 25);
            lblAlternativa1.TabIndex = 12;
            lblAlternativa1.Text = "1";
            // 
            // lblAlternativa2
            // 
            lblAlternativa2.AutoSize = true;
            lblAlternativa2.BackColor = SystemColors.ActiveCaption;
            lblAlternativa2.Location = new Point(414, 100);
            lblAlternativa2.Name = "lblAlternativa2";
            lblAlternativa2.Size = new Size(22, 25);
            lblAlternativa2.TabIndex = 13;
            lblAlternativa2.Text = "2";
            // 
            // lblAlternativa3
            // 
            lblAlternativa3.AutoSize = true;
            lblAlternativa3.BackColor = SystemColors.ActiveCaption;
            lblAlternativa3.Location = new Point(414, 154);
            lblAlternativa3.Name = "lblAlternativa3";
            lblAlternativa3.Size = new Size(22, 25);
            lblAlternativa3.TabIndex = 14;
            lblAlternativa3.Text = "3";
            // 
            // lblAlternativa4
            // 
            lblAlternativa4.AutoSize = true;
            lblAlternativa4.BackColor = SystemColors.ActiveCaption;
            lblAlternativa4.Location = new Point(414, 204);
            lblAlternativa4.Name = "lblAlternativa4";
            lblAlternativa4.Size = new Size(22, 25);
            lblAlternativa4.TabIndex = 15;
            lblAlternativa4.Text = "4";
            // 
            // txtAlternativa1
            // 
            txtAlternativa1.Location = new Point(442, 42);
            txtAlternativa1.Name = "txtAlternativa1";
            txtAlternativa1.PlaceholderText = "Digite a alternativa 1";
            txtAlternativa1.Size = new Size(256, 31);
            txtAlternativa1.TabIndex = 16;
            // 
            // txtAlternativa2
            // 
            txtAlternativa2.Location = new Point(442, 97);
            txtAlternativa2.Name = "txtAlternativa2";
            txtAlternativa2.PlaceholderText = "Digite a alternativa 2";
            txtAlternativa2.Size = new Size(256, 31);
            txtAlternativa2.TabIndex = 17;
            // 
            // txtAlternativa3
            // 
            txtAlternativa3.Location = new Point(442, 151);
            txtAlternativa3.Name = "txtAlternativa3";
            txtAlternativa3.PlaceholderText = "Digite a alternativa 3";
            txtAlternativa3.Size = new Size(256, 31);
            txtAlternativa3.TabIndex = 18;
            // 
            // txtAlternativa4
            // 
            txtAlternativa4.Location = new Point(442, 201);
            txtAlternativa4.Name = "txtAlternativa4";
            txtAlternativa4.PlaceholderText = "Digite a alternativa 4";
            txtAlternativa4.Size = new Size(256, 31);
            txtAlternativa4.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 304);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 20;
            label2.Text = "Resposta correta";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Highlight;
            btnLimpar.FlatAppearance.BorderColor = Color.Gold;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(414, 431);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 46);
            btnLimpar.TabIndex = 22;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.BackColor = Color.Lime;
            btnCadastrarPergunta.FlatAppearance.BorderColor = Color.Orange;
            btnCadastrarPergunta.FlatStyle = FlatStyle.Flat;
            btnCadastrarPergunta.Location = new Point(605, 431);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(112, 46);
            btnCadastrarPergunta.TabIndex = 23;
            btnCadastrarPergunta.Text = "Cadastrar";
            btnCadastrarPergunta.UseVisualStyleBackColor = false;
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
            // 
            // cbPontuacaoPergunta
            // 
            cbPontuacaoPergunta.FormattingEnabled = true;
            cbPontuacaoPergunta.Location = new Point(12, 451);
            cbPontuacaoPergunta.Name = "cbPontuacaoPergunta";
            cbPontuacaoPergunta.Size = new Size(182, 33);
            cbPontuacaoPergunta.TabIndex = 62;
            // 
            // cbTemaPergunta
            // 
            cbTemaPergunta.FormattingEnabled = true;
            cbTemaPergunta.Location = new Point(12, 380);
            cbTemaPergunta.Name = "cbTemaPergunta";
            cbTemaPergunta.Size = new Size(182, 33);
            cbTemaPergunta.TabIndex = 61;
            // 
            // cbNivelPergunta
            // 
            cbNivelPergunta.FormattingEnabled = true;
            cbNivelPergunta.Location = new Point(12, 302);
            cbNivelPergunta.Name = "cbNivelPergunta";
            cbNivelPergunta.Size = new Size(182, 33);
            cbNivelPergunta.TabIndex = 60;
            // 
            // cbTipoPergunta
            // 
            cbTipoPergunta.FormattingEnabled = true;
            cbTipoPergunta.Location = new Point(14, 222);
            cbTipoPergunta.Name = "cbTipoPergunta";
            cbTipoPergunta.Size = new Size(182, 33);
            cbTipoPergunta.TabIndex = 59;
            // 
            // lblPontuaçãoPerguntas
            // 
            lblPontuaçãoPerguntas.AutoSize = true;
            lblPontuaçãoPerguntas.Location = new Point(14, 423);
            lblPontuaçãoPerguntas.Name = "lblPontuaçãoPerguntas";
            lblPontuaçãoPerguntas.Size = new Size(95, 25);
            lblPontuaçãoPerguntas.TabIndex = 58;
            lblPontuaçãoPerguntas.Text = "Pontuação";
            // 
            // lblTemaPergunta
            // 
            lblTemaPergunta.AutoSize = true;
            lblTemaPergunta.Location = new Point(14, 352);
            lblTemaPergunta.Name = "lblTemaPergunta";
            lblTemaPergunta.Size = new Size(53, 25);
            lblTemaPergunta.TabIndex = 57;
            lblTemaPergunta.Text = "Tema";
            // 
            // lblNivelPergunta
            // 
            lblNivelPergunta.AutoSize = true;
            lblNivelPergunta.Location = new Point(14, 274);
            lblNivelPergunta.Name = "lblNivelPergunta";
            lblNivelPergunta.Size = new Size(153, 25);
            lblNivelPergunta.TabIndex = 56;
            lblNivelPergunta.Text = "Nivel da pergunta";
            // 
            // lblTipoPergunta
            // 
            lblTipoPergunta.AutoSize = true;
            lblTipoPergunta.Location = new Point(14, 194);
            lblTipoPergunta.Name = "lblTipoPergunta";
            lblTipoPergunta.Size = new Size(147, 25);
            lblTipoPergunta.TabIndex = 55;
            lblTipoPergunta.Text = "Tipo de Pergunta";
            // 
            // cbRespostaCorreta
            // 
            cbRespostaCorreta.FormattingEnabled = true;
            cbRespostaCorreta.Location = new Point(468, 332);
            cbRespostaCorreta.Name = "cbRespostaCorreta";
            cbRespostaCorreta.Size = new Size(182, 33);
            cbRespostaCorreta.TabIndex = 63;
            // 
            // CadastrarPerguntas_ADMIN_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 515);
            Controls.Add(cbRespostaCorreta);
            Controls.Add(cbPontuacaoPergunta);
            Controls.Add(cbTemaPergunta);
            Controls.Add(cbNivelPergunta);
            Controls.Add(cbTipoPergunta);
            Controls.Add(lblPontuaçãoPerguntas);
            Controls.Add(lblTemaPergunta);
            Controls.Add(lblNivelPergunta);
            Controls.Add(lblTipoPergunta);
            Controls.Add(btnCadastrarPergunta);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(txtAlternativa4);
            Controls.Add(txtAlternativa3);
            Controls.Add(txtAlternativa2);
            Controls.Add(txtAlternativa1);
            Controls.Add(lblAlternativa4);
            Controls.Add(lblAlternativa3);
            Controls.Add(lblAlternativa2);
            Controls.Add(lblAlternativa1);
            Controls.Add(label1);
            Controls.Add(lblAlternativas);
            Controls.Add(txtEnuciado);
            Controls.Add(lblEnunciadoDaPergunta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastrarPerguntas_ADMIN_";
            Text = "CadastrarPerguntas_ADMIN_";
            Load += CadastrarPerguntas_ADMIN__Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnunciadoDaPergunta;
        private TextBox txtEnuciado;
        private Label lblAlternativas;
        private Label label1;
        private Label lblAlternativa1;
        private Label lblAlternativa2;
        private Label lblAlternativa3;
        private Label lblAlternativa4;
        private TextBox txtAlternativa1;
        private TextBox txtAlternativa2;
        private TextBox txtAlternativa3;
        private TextBox txtAlternativa4;
        private Label label2;
        private Button btnLimpar;
        private Button btnCadastrarPergunta;
        private ComboBox cbPontuacaoPergunta;
        private ComboBox cbTemaPergunta;
        private ComboBox cbNivelPergunta;
        private ComboBox cbTipoPergunta;
        private Label lblPontuaçãoPerguntas;
        private Label lblTemaPergunta;
        private Label lblNivelPergunta;
        private Label lblTipoPergunta;
        private ComboBox cbRespostaCorreta;
    }
}