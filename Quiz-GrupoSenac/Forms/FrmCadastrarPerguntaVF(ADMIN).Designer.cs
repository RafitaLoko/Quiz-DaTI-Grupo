namespace Quiz_GrupoSenac.Forms
{
    partial class FrmCadastrarPerguntaVF_ADMIN_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarPerguntaVF_ADMIN_));
            btnCadastrarPergunta = new Button();
            btnLimpar = new Button();
            label2 = new Label();
            lblPontuaçãoPerguntas = new Label();
            lblTemaPergunta = new Label();
            lblNivelPergunta = new Label();
            lblTipoPergunta = new Label();
            txtEnuciado = new TextBox();
            lblEnunciadoDaPergunta = new Label();
            rbVerdadeiro = new RadioButton();
            rbFalso = new RadioButton();
            cbTipoPergunta = new ComboBox();
            cbNivelPergunta = new ComboBox();
            cbTemaPergunta = new ComboBox();
            cbPontuacaoPergunta = new ComboBox();
            SuspendLayout();
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.BackColor = Color.Lime;
            btnCadastrarPergunta.FlatAppearance.BorderColor = Color.Orange;
            btnCadastrarPergunta.FlatStyle = FlatStyle.Flat;
            btnCadastrarPergunta.Location = new Point(615, 431);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(112, 46);
            btnCadastrarPergunta.TabIndex = 47;
            btnCadastrarPergunta.Text = "Cadastrar";
            btnCadastrarPergunta.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.Highlight;
            btnLimpar.FlatAppearance.BorderColor = Color.Gold;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(424, 431);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 46);
            btnLimpar.TabIndex = 46;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 9);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 44;
            label2.Text = "Resposta correta";
            // 
            // lblPontuaçãoPerguntas
            // 
            lblPontuaçãoPerguntas.AutoSize = true;
            lblPontuaçãoPerguntas.Location = new Point(12, 418);
            lblPontuaçãoPerguntas.Name = "lblPontuaçãoPerguntas";
            lblPontuaçãoPerguntas.Size = new Size(95, 25);
            lblPontuaçãoPerguntas.TabIndex = 32;
            lblPontuaçãoPerguntas.Text = "Pontuação";
            // 
            // lblTemaPergunta
            // 
            lblTemaPergunta.AutoSize = true;
            lblTemaPergunta.Location = new Point(12, 347);
            lblTemaPergunta.Name = "lblTemaPergunta";
            lblTemaPergunta.Size = new Size(53, 25);
            lblTemaPergunta.TabIndex = 30;
            lblTemaPergunta.Text = "Tema";
            // 
            // lblNivelPergunta
            // 
            lblNivelPergunta.AutoSize = true;
            lblNivelPergunta.Location = new Point(12, 269);
            lblNivelPergunta.Name = "lblNivelPergunta";
            lblNivelPergunta.Size = new Size(153, 25);
            lblNivelPergunta.TabIndex = 28;
            lblNivelPergunta.Text = "Nivel da pergunta";
            // 
            // lblTipoPergunta
            // 
            lblTipoPergunta.AutoSize = true;
            lblTipoPergunta.Location = new Point(12, 189);
            lblTipoPergunta.Name = "lblTipoPergunta";
            lblTipoPergunta.Size = new Size(147, 25);
            lblTipoPergunta.TabIndex = 26;
            lblTipoPergunta.Text = "Tipo de Pergunta";
            // 
            // txtEnuciado
            // 
            txtEnuciado.Font = new Font("Segoe UI", 9F);
            txtEnuciado.Location = new Point(12, 30);
            txtEnuciado.Multiline = true;
            txtEnuciado.Name = "txtEnuciado";
            txtEnuciado.PlaceholderText = "Escreva a Pergunta";
            txtEnuciado.Size = new Size(311, 138);
            txtEnuciado.TabIndex = 25;
            // 
            // lblEnunciadoDaPergunta
            // 
            lblEnunciadoDaPergunta.AutoSize = true;
            lblEnunciadoDaPergunta.Location = new Point(12, 2);
            lblEnunciadoDaPergunta.Name = "lblEnunciadoDaPergunta";
            lblEnunciadoDaPergunta.Size = new Size(194, 25);
            lblEnunciadoDaPergunta.TabIndex = 24;
            lblEnunciadoDaPergunta.Text = "Enunciado da Pergunta";
            // 
            // rbVerdadeiro
            // 
            rbVerdadeiro.AutoSize = true;
            rbVerdadeiro.Location = new Point(483, 54);
            rbVerdadeiro.Name = "rbVerdadeiro";
            rbVerdadeiro.Size = new Size(123, 29);
            rbVerdadeiro.TabIndex = 48;
            rbVerdadeiro.TabStop = true;
            rbVerdadeiro.Text = "Verdadeiro";
            rbVerdadeiro.UseVisualStyleBackColor = true;
            // 
            // rbFalso
            // 
            rbFalso.AutoSize = true;
            rbFalso.Location = new Point(483, 89);
            rbFalso.Name = "rbFalso";
            rbFalso.Size = new Size(77, 29);
            rbFalso.TabIndex = 49;
            rbFalso.TabStop = true;
            rbFalso.Text = "Falso";
            rbFalso.UseVisualStyleBackColor = true;
            // 
            // cbTipoPergunta
            // 
            cbTipoPergunta.FormattingEnabled = true;
            cbTipoPergunta.Location = new Point(12, 217);
            cbTipoPergunta.Name = "cbTipoPergunta";
            cbTipoPergunta.Size = new Size(182, 33);
            cbTipoPergunta.TabIndex = 50;
            // 
            // cbNivelPergunta
            // 
            cbNivelPergunta.FormattingEnabled = true;
            cbNivelPergunta.Location = new Point(10, 297);
            cbNivelPergunta.Name = "cbNivelPergunta";
            cbNivelPergunta.Size = new Size(182, 33);
            cbNivelPergunta.TabIndex = 52;
            // 
            // cbTemaPergunta
            // 
            cbTemaPergunta.FormattingEnabled = true;
            cbTemaPergunta.Location = new Point(10, 375);
            cbTemaPergunta.Name = "cbTemaPergunta";
            cbTemaPergunta.Size = new Size(182, 33);
            cbTemaPergunta.TabIndex = 53;
            // 
            // cbPontuacaoPergunta
            // 
            cbPontuacaoPergunta.FormattingEnabled = true;
            cbPontuacaoPergunta.Location = new Point(10, 446);
            cbPontuacaoPergunta.Name = "cbPontuacaoPergunta";
            cbPontuacaoPergunta.Size = new Size(182, 33);
            cbPontuacaoPergunta.TabIndex = 54;
            // 
            // FrmCadastrarPerguntaVF_ADMIN_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 500);
            Controls.Add(cbPontuacaoPergunta);
            Controls.Add(cbTemaPergunta);
            Controls.Add(cbNivelPergunta);
            Controls.Add(cbTipoPergunta);
            Controls.Add(rbFalso);
            Controls.Add(rbVerdadeiro);
            Controls.Add(btnCadastrarPergunta);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(lblPontuaçãoPerguntas);
            Controls.Add(lblTemaPergunta);
            Controls.Add(lblNivelPergunta);
            Controls.Add(lblTipoPergunta);
            Controls.Add(txtEnuciado);
            Controls.Add(lblEnunciadoDaPergunta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastrarPerguntaVF_ADMIN_";
            Text = "FrmCadastrarPerguntaVF_ADMIN_";
            Load += FrmCadastrarPerguntaVF_ADMIN__Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarPergunta;
        private Button btnLimpar;
        private Label label2;
        private Label lblPontuaçãoPerguntas;
        private Label lblTemaPergunta;
        private Label lblNivelPergunta;
        private Label lblTipoPergunta;
        private TextBox txtEnuciado;
        private Label lblEnunciadoDaPergunta;
        private RadioButton rbVerdadeiro;
        private RadioButton rbFalso;
        private ComboBox cbTipoPergunta;
        private ComboBox cbNivelPergunta;
        private ComboBox cbTemaPergunta;
        private ComboBox cbPontuacaoPergunta;
    }
}