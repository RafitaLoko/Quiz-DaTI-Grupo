namespace Quiz_GrupoSenac.Forms
{
    partial class FrmQuizVF
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
            lblPontuacaoQuiz = new Label();
            lblPerguntaNumeroQuiz = new Label();
            lblPerguntaQuiz = new Label();
            btnProximaQuiz = new Button();
            lblValorQuiz = new Label();
            lblNivelQuiz = new Label();
            lblNickQuiz = new Label();
            rbVerdadeiroQuiz = new RadioButton();
            rbFalsoQuiz = new RadioButton();
            SuspendLayout();
            // 
            // lblPontuacaoQuiz
            // 
            lblPontuacaoQuiz.AutoSize = true;
            lblPontuacaoQuiz.BackColor = Color.Aquamarine;
            lblPontuacaoQuiz.Location = new Point(404, 417);
            lblPontuacaoQuiz.Name = "lblPontuacaoQuiz";
            lblPontuacaoQuiz.Size = new Size(99, 25);
            lblPontuacaoQuiz.TabIndex = 21;
            lblPontuacaoQuiz.Text = "Pontuação:";
            // 
            // lblPerguntaNumeroQuiz
            // 
            lblPerguntaNumeroQuiz.AutoSize = true;
            lblPerguntaNumeroQuiz.BackColor = Color.LightGoldenrodYellow;
            lblPerguntaNumeroQuiz.Location = new Point(373, 9);
            lblPerguntaNumeroQuiz.Name = "lblPerguntaNumeroQuiz";
            lblPerguntaNumeroQuiz.Size = new Size(155, 25);
            lblPerguntaNumeroQuiz.TabIndex = 20;
            lblPerguntaNumeroQuiz.Text = "Pergunta tal de tal";
            // 
            // lblPerguntaQuiz
            // 
            lblPerguntaQuiz.AutoSize = true;
            lblPerguntaQuiz.BackColor = Color.GreenYellow;
            lblPerguntaQuiz.Location = new Point(64, 67);
            lblPerguntaQuiz.Name = "lblPerguntaQuiz";
            lblPerguntaQuiz.Size = new Size(86, 25);
            lblPerguntaQuiz.TabIndex = 15;
            lblPerguntaQuiz.Text = "Pergunta:";
            // 
            // btnProximaQuiz
            // 
            btnProximaQuiz.BackColor = Color.Pink;
            btnProximaQuiz.FlatAppearance.BorderColor = Color.Yellow;
            btnProximaQuiz.FlatStyle = FlatStyle.Flat;
            btnProximaQuiz.Location = new Point(666, 398);
            btnProximaQuiz.Name = "btnProximaQuiz";
            btnProximaQuiz.Size = new Size(122, 41);
            btnProximaQuiz.TabIndex = 14;
            btnProximaQuiz.Text = "Proxima";
            btnProximaQuiz.UseVisualStyleBackColor = false;
            // 
            // lblValorQuiz
            // 
            lblValorQuiz.AutoSize = true;
            lblValorQuiz.BackColor = Color.Yellow;
            lblValorQuiz.Location = new Point(12, 417);
            lblValorQuiz.Name = "lblValorQuiz";
            lblValorQuiz.Size = new Size(56, 25);
            lblValorQuiz.TabIndex = 13;
            lblValorQuiz.Text = "Valor:";
            // 
            // lblNivelQuiz
            // 
            lblNivelQuiz.AutoSize = true;
            lblNivelQuiz.BackColor = Color.Yellow;
            lblNivelQuiz.Location = new Point(645, 10);
            lblNivelQuiz.Name = "lblNivelQuiz";
            lblNivelQuiz.Size = new Size(55, 25);
            lblNivelQuiz.TabIndex = 12;
            lblNivelQuiz.Text = "Nivel:";
            // 
            // lblNickQuiz
            // 
            lblNickQuiz.AutoSize = true;
            lblNickQuiz.BackColor = Color.Yellow;
            lblNickQuiz.Location = new Point(12, 10);
            lblNickQuiz.Name = "lblNickQuiz";
            lblNickQuiz.Size = new Size(0, 25);
            lblNickQuiz.TabIndex = 11;
            // 
            // rbVerdadeiroQuiz
            // 
            rbVerdadeiroQuiz.AutoSize = true;
            rbVerdadeiroQuiz.Location = new Point(191, 205);
            rbVerdadeiroQuiz.Name = "rbVerdadeiroQuiz";
            rbVerdadeiroQuiz.Size = new Size(123, 29);
            rbVerdadeiroQuiz.TabIndex = 22;
            rbVerdadeiroQuiz.TabStop = true;
            rbVerdadeiroQuiz.Text = "Verdadeiro";
            rbVerdadeiroQuiz.UseVisualStyleBackColor = true;
            // 
            // rbFalsoQuiz
            // 
            rbFalsoQuiz.AutoSize = true;
            rbFalsoQuiz.Location = new Point(448, 205);
            rbFalsoQuiz.Name = "rbFalsoQuiz";
            rbFalsoQuiz.Size = new Size(77, 29);
            rbFalsoQuiz.TabIndex = 23;
            rbFalsoQuiz.TabStop = true;
            rbFalsoQuiz.Text = "Falso";
            rbFalsoQuiz.UseVisualStyleBackColor = true;
            // 
            // FrmQuizVF
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(rbFalsoQuiz);
            Controls.Add(rbVerdadeiroQuiz);
            Controls.Add(lblPontuacaoQuiz);
            Controls.Add(lblPerguntaNumeroQuiz);
            Controls.Add(lblPerguntaQuiz);
            Controls.Add(btnProximaQuiz);
            Controls.Add(lblValorQuiz);
            Controls.Add(lblNivelQuiz);
            Controls.Add(lblNickQuiz);
            Name = "FrmQuizVF";
            Text = "FrmQuizVF";
            Load += FrmQuizVF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPontuacaoQuiz;
        private Label lblPerguntaNumeroQuiz;
        private Label lblPerguntaQuiz;
        private Button btnProximaQuiz;
        private Label lblValorQuiz;
        private Label lblNivelQuiz;
        private Label lblNickQuiz;
        private RadioButton rbVerdadeiroQuiz;
        private RadioButton rbFalsoQuiz;
    }
}