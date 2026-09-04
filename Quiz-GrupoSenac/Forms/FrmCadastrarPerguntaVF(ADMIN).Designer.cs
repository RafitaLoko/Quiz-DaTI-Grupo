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
            txtAlternativa4 = new TextBox();
            txtAlternativa3 = new TextBox();
            txtAlternativa2 = new TextBox();
            txtAlternativa1 = new TextBox();
            lblAlternativa4 = new Label();
            lblAlternativa3 = new Label();
            lblAlternativa2 = new Label();
            lblAlternativa1 = new Label();
            label1 = new Label();
            lblAlternativas = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            btnVoltar = new Button();
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
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
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
            label2.Location = new Point(349, 12);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 44;
            label2.Text = "Resposta correta";
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
            rbVerdadeiro.Location = new Point(329, 52);
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
            rbFalso.Location = new Point(329, 87);
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
            cbTipoPergunta.Items.AddRange(new object[] { "Alternativas", "Verdadeiro ou Falso" });
            cbTipoPergunta.Location = new Point(12, 217);
            cbTipoPergunta.Name = "cbTipoPergunta";
            cbTipoPergunta.Size = new Size(182, 33);
            cbTipoPergunta.TabIndex = 50;
            // 
            // cbNivelPergunta
            // 
            cbNivelPergunta.FormattingEnabled = true;
            cbNivelPergunta.Items.AddRange(new object[] { "Iniciante", "Fácil", "Intermediário", "Avançado" });
            cbNivelPergunta.Location = new Point(10, 297);
            cbNivelPergunta.Name = "cbNivelPergunta";
            cbNivelPergunta.Size = new Size(182, 33);
            cbNivelPergunta.TabIndex = 52;
            // 
            // cbTemaPergunta
            // 
            cbTemaPergunta.FormattingEnabled = true;
            cbTemaPergunta.Items.AddRange(new object[] { "Hardware", "Programação", "Redes", "Segurança Digital", "Sistemas Operacionais", "Ferramentas de produtividade" });
            cbTemaPergunta.Location = new Point(10, 375);
            cbTemaPergunta.Name = "cbTemaPergunta";
            cbTemaPergunta.Size = new Size(182, 33);
            cbTemaPergunta.TabIndex = 53;
            // 
            // txtAlternativa4
            // 
            txtAlternativa4.Location = new Point(543, 211);
            txtAlternativa4.Name = "txtAlternativa4";
            txtAlternativa4.PlaceholderText = "Digite a alternativa 4";
            txtAlternativa4.Size = new Size(256, 31);
            txtAlternativa4.TabIndex = 63;
            // 
            // txtAlternativa3
            // 
            txtAlternativa3.Location = new Point(543, 161);
            txtAlternativa3.Name = "txtAlternativa3";
            txtAlternativa3.PlaceholderText = "Digite a alternativa 3";
            txtAlternativa3.Size = new Size(256, 31);
            txtAlternativa3.TabIndex = 62;
            // 
            // txtAlternativa2
            // 
            txtAlternativa2.Location = new Point(543, 107);
            txtAlternativa2.Name = "txtAlternativa2";
            txtAlternativa2.PlaceholderText = "Digite a alternativa 2";
            txtAlternativa2.Size = new Size(256, 31);
            txtAlternativa2.TabIndex = 61;
            // 
            // txtAlternativa1
            // 
            txtAlternativa1.Location = new Point(543, 52);
            txtAlternativa1.Name = "txtAlternativa1";
            txtAlternativa1.PlaceholderText = "Digite a alternativa 1";
            txtAlternativa1.Size = new Size(256, 31);
            txtAlternativa1.TabIndex = 60;
            // 
            // lblAlternativa4
            // 
            lblAlternativa4.AutoSize = true;
            lblAlternativa4.BackColor = SystemColors.ActiveCaption;
            lblAlternativa4.Location = new Point(515, 214);
            lblAlternativa4.Name = "lblAlternativa4";
            lblAlternativa4.Size = new Size(22, 25);
            lblAlternativa4.TabIndex = 59;
            lblAlternativa4.Text = "4";
            // 
            // lblAlternativa3
            // 
            lblAlternativa3.AutoSize = true;
            lblAlternativa3.BackColor = SystemColors.ActiveCaption;
            lblAlternativa3.Location = new Point(515, 164);
            lblAlternativa3.Name = "lblAlternativa3";
            lblAlternativa3.Size = new Size(22, 25);
            lblAlternativa3.TabIndex = 58;
            lblAlternativa3.Text = "3";
            // 
            // lblAlternativa2
            // 
            lblAlternativa2.AutoSize = true;
            lblAlternativa2.BackColor = SystemColors.ActiveCaption;
            lblAlternativa2.Location = new Point(515, 110);
            lblAlternativa2.Name = "lblAlternativa2";
            lblAlternativa2.Size = new Size(22, 25);
            lblAlternativa2.TabIndex = 57;
            lblAlternativa2.Text = "2";
            // 
            // lblAlternativa1
            // 
            lblAlternativa1.AutoSize = true;
            lblAlternativa1.BackColor = SystemColors.ActiveCaption;
            lblAlternativa1.Location = new Point(515, 55);
            lblAlternativa1.Name = "lblAlternativa1";
            lblAlternativa1.Size = new Size(22, 25);
            lblAlternativa1.TabIndex = 56;
            lblAlternativa1.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 55;
            // 
            // lblAlternativas
            // 
            lblAlternativas.AutoSize = true;
            lblAlternativas.Location = new Point(608, 12);
            lblAlternativas.Name = "lblAlternativas";
            lblAlternativas.Size = new Size(104, 25);
            lblAlternativas.TabIndex = 54;
            lblAlternativas.Text = "Alternativas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(424, 306);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 64;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(608, 306);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 65;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(425, 373);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 66;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(608, 373);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 67;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 269);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 68;
            label3.Text = "Alternativa correta";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Orange;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(10, 454);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 69;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmCadastrarPerguntaVF_ADMIN_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 500);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(cbTemaPergunta);
            Controls.Add(cbNivelPergunta);
            Controls.Add(cbTipoPergunta);
            Controls.Add(rbFalso);
            Controls.Add(rbVerdadeiro);
            Controls.Add(btnCadastrarPergunta);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
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
        private TextBox txtAlternativa4;
        private TextBox txtAlternativa3;
        private TextBox txtAlternativa2;
        private TextBox txtAlternativa1;
        private Label lblAlternativa4;
        private Label lblAlternativa3;
        private Label lblAlternativa2;
        private Label lblAlternativa1;
        private Label label1;
        private Label lblAlternativas;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Button btnVoltar;
    }
}