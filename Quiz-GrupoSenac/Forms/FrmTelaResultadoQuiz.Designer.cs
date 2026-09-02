namespace Quiz_GrupoSenac.Forms
{
    partial class FrmTelaResultadoQuiz
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
            lblResultadosDoQuiz = new Label();
            lblPontuacao = new Label();
            lblAcertos = new Label();
            lblErros = new Label();
            lblSequencia = new Label();
            lstResultados = new ListBox();
            btnVoltarMenu = new Button();
            SuspendLayout();
            // 
            // lblResultadosDoQuiz
            // 
            lblResultadosDoQuiz.AutoSize = true;
            lblResultadosDoQuiz.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadosDoQuiz.Location = new Point(1, 9);
            lblResultadosDoQuiz.Name = "lblResultadosDoQuiz";
            lblResultadosDoQuiz.Size = new Size(215, 32);
            lblResultadosDoQuiz.TabIndex = 0;
            lblResultadosDoQuiz.Text = "Resultados do quiz";
            // 
            // lblPontuacao
            // 
            lblPontuacao.AutoSize = true;
            lblPontuacao.BackColor = Color.Yellow;
            lblPontuacao.Location = new Point(12, 61);
            lblPontuacao.Name = "lblPontuacao";
            lblPontuacao.Size = new Size(101, 25);
            lblPontuacao.TabIndex = 1;
            lblPontuacao.Text = "🏆 Pontos:";
            lblPontuacao.Click += lblPontuacao_Click;
            // 
            // lblAcertos
            // 
            lblAcertos.AutoSize = true;
            lblAcertos.BackColor = Color.Lime;
            lblAcertos.Location = new Point(12, 112);
            lblAcertos.Name = "lblAcertos";
            lblAcertos.Size = new Size(76, 25);
            lblAcertos.TabIndex = 2;
            lblAcertos.Text = "Acertos:";
            // 
            // lblErros
            // 
            lblErros.AutoSize = true;
            lblErros.BackColor = Color.Red;
            lblErros.Location = new Point(12, 137);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(56, 25);
            lblErros.TabIndex = 3;
            lblErros.Text = "Erros:";
            // 
            // lblSequencia
            // 
            lblSequencia.AutoSize = true;
            lblSequencia.BackColor = Color.Gold;
            lblSequencia.Location = new Point(12, 162);
            lblSequencia.Name = "lblSequencia";
            lblSequencia.Size = new Size(147, 25);
            lblSequencia.TabIndex = 4;
            lblSequencia.Text = "Maior Sequencia:";
            // 
            // lstResultados
            // 
            lstResultados.BackColor = Color.IndianRed;
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 25;
            lstResultados.Location = new Point(12, 204);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(634, 129);
            lstResultados.TabIndex = 5;
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = Color.Red;
            btnVoltarMenu.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            btnVoltarMenu.FlatStyle = FlatStyle.Flat;
            btnVoltarMenu.Location = new Point(12, 404);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(178, 34);
            btnVoltarMenu.TabIndex = 6;
            btnVoltarMenu.Text = "Voltar ao Menu";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // FrmTelaResultadoQuiz
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarMenu);
            Controls.Add(lstResultados);
            Controls.Add(lblSequencia);
            Controls.Add(lblErros);
            Controls.Add(lblAcertos);
            Controls.Add(lblPontuacao);
            Controls.Add(lblResultadosDoQuiz);
            Name = "FrmTelaResultadoQuiz";
            Text = "FrmTelaResultadoQuiz";
            Load += FrmTelaResultadoQuiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultadosDoQuiz;
        private Label lblPontuacao;
        private Label lblAcertos;
        private Label lblErros;
        private Label lblSequencia;
        private ListBox lstResultados;
        private Button btnVoltarMenu;
    }
}