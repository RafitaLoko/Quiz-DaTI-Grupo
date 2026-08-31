namespace Quiz_GrupoSenac
{
    partial class FrmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz));
            lblNickQuiz = new Label();
            lblNivelQuiz = new Label();
            lblValorQuiz = new Label();
            btnProximaQuiz = new Button();
            lblPerguntaQuiz = new Label();
            rbResposta1 = new RadioButton();
            rbResposta2 = new RadioButton();
            rbResposta3 = new RadioButton();
            rbResposta4 = new RadioButton();
            lblPerguntaNumeroQuiz = new Label();
            lblPontuacaoQuiz = new Label();
            lblTemaQuiz = new Label();
            SuspendLayout();
            // 
            // lblNickQuiz
            // 
            lblNickQuiz.AutoSize = true;
            lblNickQuiz.BackColor = Color.Yellow;
            lblNickQuiz.Location = new Point(12, 9);
            lblNickQuiz.Name = "lblNickQuiz";
            lblNickQuiz.Size = new Size(0, 25);
            lblNickQuiz.TabIndex = 0;

            // 
            // lblNivelQuiz
            // 
            lblNivelQuiz.AutoSize = true;
            lblNivelQuiz.BackColor = Color.Yellow;
            lblNivelQuiz.Location = new Point(625, 8);
            lblNivelQuiz.Name = "lblNivelQuiz";
            lblNivelQuiz.Size = new Size(0, 25);
            lblNivelQuiz.TabIndex = 1;
            // 
            // lblValorQuiz
            // 
            lblValorQuiz.AutoSize = true;
            lblValorQuiz.BackColor = Color.Yellow;
            lblValorQuiz.Location = new Point(12, 440);
            lblValorQuiz.Name = "lblValorQuiz";
            lblValorQuiz.Size = new Size(0, 25);
            lblValorQuiz.TabIndex = 2;
            // 
            // btnProximaQuiz
            // 
            btnProximaQuiz.BackColor = Color.Pink;
            btnProximaQuiz.FlatAppearance.BorderColor = Color.Yellow;
            btnProximaQuiz.FlatStyle = FlatStyle.Flat;
            btnProximaQuiz.Location = new Point(706, 440);
            btnProximaQuiz.Name = "btnProximaQuiz";
            btnProximaQuiz.Size = new Size(122, 32);
            btnProximaQuiz.TabIndex = 3;
            btnProximaQuiz.UseVisualStyleBackColor = false;
            btnProximaQuiz.Click += btnProximaQuiz_Click;
            // 
            // lblPerguntaQuiz
            // 
            lblPerguntaQuiz.AutoSize = true;
            lblPerguntaQuiz.BackColor = Color.GreenYellow;
            lblPerguntaQuiz.Location = new Point(64, 66);
            lblPerguntaQuiz.Name = "lblPerguntaQuiz";
            lblPerguntaQuiz.Size = new Size(86, 25);
            lblPerguntaQuiz.TabIndex = 4;
            lblPerguntaQuiz.Text = "Pergunta:";
            // 
            // rbResposta1
            // 
            rbResposta1.BackColor = Color.MintCream;
            rbResposta1.Location = new Point(41, 218);
            rbResposta1.Name = "rbResposta1";
            rbResposta1.Size = new Size(363, 98);
            rbResposta1.TabIndex = 5;
            rbResposta1.TabStop = true;
            rbResposta1.Text = "Resposta 1";
            rbResposta1.UseVisualStyleBackColor = false;
            // 
            // rbResposta2
            // 
            rbResposta2.BackColor = Color.MintCream;
            rbResposta2.Location = new Point(41, 322);
            rbResposta2.Name = "rbResposta2";
            rbResposta2.Size = new Size(363, 103);
            rbResposta2.TabIndex = 6;
            rbResposta2.TabStop = true;
            rbResposta2.Text = "resposta 2";
            rbResposta2.UseVisualStyleBackColor = false;
            // 
            // rbResposta3
            // 
            rbResposta3.BackColor = Color.MintCream;
            rbResposta3.Location = new Point(429, 218);
            rbResposta3.Name = "rbResposta3";
            rbResposta3.Size = new Size(375, 98);
            rbResposta3.TabIndex = 7;
            rbResposta3.TabStop = true;
            rbResposta3.Text = "resposta 3";
            rbResposta3.UseVisualStyleBackColor = false;
            // 
            // rbResposta4
            // 
            rbResposta4.BackColor = Color.MintCream;
            rbResposta4.Location = new Point(425, 322);
            rbResposta4.Name = "rbResposta4";
            rbResposta4.Size = new Size(379, 103);
            rbResposta4.TabIndex = 8;
            rbResposta4.TabStop = true;
            rbResposta4.Text = "Resposta 4";
            rbResposta4.UseVisualStyleBackColor = false;
            // 
            // lblPerguntaNumeroQuiz
            // 
            lblPerguntaNumeroQuiz.AutoSize = true;
            lblPerguntaNumeroQuiz.BackColor = Color.LightGoldenrodYellow;
            lblPerguntaNumeroQuiz.Location = new Point(373, 8);
            lblPerguntaNumeroQuiz.Name = "lblPerguntaNumeroQuiz";
            lblPerguntaNumeroQuiz.Size = new Size(0, 25);
            lblPerguntaNumeroQuiz.TabIndex = 9;
            // 
            // lblPontuacaoQuiz
            // 
            lblPontuacaoQuiz.AutoSize = true;
            lblPontuacaoQuiz.BackColor = Color.Aquamarine;
            lblPontuacaoQuiz.Location = new Point(497, 447);
            lblPontuacaoQuiz.Name = "lblPontuacaoQuiz";
            lblPontuacaoQuiz.Size = new Size(0, 25);
            lblPontuacaoQuiz.TabIndex = 10;
            // 
            // lblTemaQuiz
            // 
            lblTemaQuiz.AutoSize = true;
            lblTemaQuiz.BackColor = Color.Turquoise;
            lblTemaQuiz.Location = new Point(150, 447);
            lblTemaQuiz.Name = "lblTemaQuiz";
            lblTemaQuiz.Size = new Size(0, 25);
            lblTemaQuiz.TabIndex = 11;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(830, 474);
            Controls.Add(lblTemaQuiz);
            Controls.Add(lblPontuacaoQuiz);
            Controls.Add(lblPerguntaNumeroQuiz);
            Controls.Add(rbResposta4);
            Controls.Add(rbResposta3);
            Controls.Add(rbResposta2);
            Controls.Add(rbResposta1);
            Controls.Add(lblPerguntaQuiz);
            Controls.Add(btnProximaQuiz);
            Controls.Add(lblValorQuiz);
            Controls.Add(lblNivelQuiz);
            Controls.Add(lblNickQuiz);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmQuiz";
            Text = "FrmQuiz";
            Load += FrmQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNickQuiz;
        private Label lblNivelQuiz;
        private Label lblValorQuiz;
        private Button btnProximaQuiz;
        private Label lblPerguntaQuiz;
        private RadioButton rbResposta1;
        private RadioButton rbResposta2;
        private RadioButton rbResposta3;
        private RadioButton rbResposta4;
        private Label lblPerguntaNumeroQuiz;
        private Label lblPontuacaoQuiz;
        private Label lblTemaQuiz;
    }
}