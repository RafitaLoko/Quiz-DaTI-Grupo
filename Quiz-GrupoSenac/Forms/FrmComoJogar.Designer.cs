namespace Quiz_GrupoSenac
{
    partial class FrmComoJogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComoJogar));
            label1 = new Label();
            btnVoltar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(315, -2);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 0;
            label1.Text = "Como Jogar";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Crimson;
            btnVoltar.FlatAppearance.BorderColor = Color.Gold;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(676, 404);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(112, 34);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 2;
            label2.Text = "Objetivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(597, 25);
            label3.TabIndex = 3;
            label3.Text = "Responda perguntas de informática e acumule pontos para subir de nível!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 4;
            label4.Text = "Regras:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 149);
            label5.Name = "label5";
            label5.Size = new Size(392, 100);
            label5.TabIndex = 5;
            label5.Text = "- Você pode realizar 1 quiz por dia.  \r\n- Cada quiz possui 10 perguntas. \r\n- Pelo menos 1 pergunta será avançada.\r\n- Cada nível de pergunta vale pontos diferentes.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(77, 30);
            label6.TabIndex = 6;
            label6.Text = "Bônus:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 330);
            label7.Name = "label7";
            label7.Size = new Size(287, 75);
            label7.TabIndex = 7;
            label7.Text = "* 3 acertos seguidos -> +10%\r\n* 5 acertos seguidos -> +20%\r\n* Ao errar, a sequência é reiniciada.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(533, 209);
            label8.Name = "label8";
            label8.Size = new Size(76, 30);
            label8.TabIndex = 8;
            label8.Text = "Níveis:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 253);
            label9.Name = "label9";
            label9.Size = new Size(287, 100);
            label9.TabIndex = 9;
            label9.Text = "Nível 1 -> 0 a 500 pontos\r\nNível 2 -> 501 a 2.000 pontos\r\nNível 3 -> 2.001 a 10.000 pontos\r\nNível 4 -> acima de 10.000 pontos";
            // 
            // FrmComoJogar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmComoJogar";
            Text = "Como Jogar";
            Load += FrmComoJogar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}