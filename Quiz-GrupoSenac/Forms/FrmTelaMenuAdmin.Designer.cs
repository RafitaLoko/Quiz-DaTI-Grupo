namespace Quiz_GrupoSenac.Forms
{
    partial class FrmTelaMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaMenuAdmin));
            btnVerRanking = new Button();
            btnCadastrarPerguntasQuiz = new Button();
            btnCadastrarPerguntasVF = new Button();
            SuspendLayout();
            // 
            // btnVerRanking
            // 
            btnVerRanking.BackColor = Color.Gold;
            btnVerRanking.FlatAppearance.BorderColor = Color.Blue;
            btnVerRanking.FlatStyle = FlatStyle.Flat;
            btnVerRanking.Location = new Point(293, 63);
            btnVerRanking.Name = "btnVerRanking";
            btnVerRanking.Size = new Size(212, 59);
            btnVerRanking.TabIndex = 0;
            btnVerRanking.Text = "Ranking";
            btnVerRanking.UseVisualStyleBackColor = false;
            btnVerRanking.Click += btnVerRanking_Click;
            // 
            // btnCadastrarPerguntasQuiz
            // 
            btnCadastrarPerguntasQuiz.BackColor = Color.OrangeRed;
            btnCadastrarPerguntasQuiz.FlatAppearance.BorderColor = Color.Lime;
            btnCadastrarPerguntasQuiz.FlatStyle = FlatStyle.Flat;
            btnCadastrarPerguntasQuiz.Location = new Point(293, 185);
            btnCadastrarPerguntasQuiz.Name = "btnCadastrarPerguntasQuiz";
            btnCadastrarPerguntasQuiz.Size = new Size(212, 59);
            btnCadastrarPerguntasQuiz.TabIndex = 1;
            btnCadastrarPerguntasQuiz.Text = "Cadastrar Perguntas";
            btnCadastrarPerguntasQuiz.UseVisualStyleBackColor = false;
            btnCadastrarPerguntasQuiz.Click += btnCadastrarPerguntasQuiz_Click;
            // 
            // btnCadastrarPerguntasVF
            // 
            btnCadastrarPerguntasVF.BackColor = Color.Chocolate;
            btnCadastrarPerguntasVF.FlatAppearance.BorderColor = Color.DeepPink;
            btnCadastrarPerguntasVF.FlatStyle = FlatStyle.Flat;
            btnCadastrarPerguntasVF.Location = new Point(293, 306);
            btnCadastrarPerguntasVF.Name = "btnCadastrarPerguntasVF";
            btnCadastrarPerguntasVF.Size = new Size(212, 59);
            btnCadastrarPerguntasVF.TabIndex = 2;
            btnCadastrarPerguntasVF.Text = "Cadastrar Perguntas VF";
            btnCadastrarPerguntasVF.UseVisualStyleBackColor = false;
            btnCadastrarPerguntasVF.Click += btnCadastrarPerguntasVF_Click;
            // 
            // FrmTelaMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarPerguntasVF);
            Controls.Add(btnCadastrarPerguntasQuiz);
            Controls.Add(btnVerRanking);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTelaMenuAdmin";
            Text = "FrmTelaMenuAdmin";
            Load += FrmTelaMenuAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerRanking;
        private Button btnCadastrarPerguntasQuiz;
        private Button btnCadastrarPerguntasVF;
    }
}