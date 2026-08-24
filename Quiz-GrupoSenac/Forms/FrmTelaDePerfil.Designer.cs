namespace Quiz_GrupoSenac
{
    partial class FrmTelaDePerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaDePerfil));
            lblNicknamePerfil = new Label();
            lblNivelPerfil = new Label();
            lblPontuacaoTotalPerfil = new Label();
            lblAcertosPerfil = new Label();
            lblPerguntasRespondidasPerfil = new Label();
            lblMaiorSequenciaAcertosPerfil = new Label();
            lblConquistasPerfil = new Label();
            btnVoltarPerfil = new Button();
            SuspendLayout();
            // 
            // lblNicknamePerfil
            // 
            lblNicknamePerfil.AutoSize = true;
            lblNicknamePerfil.Location = new Point(22, 19);
            lblNicknamePerfil.Name = "lblNicknamePerfil";
            lblNicknamePerfil.Size = new Size(0, 25);
            lblNicknamePerfil.TabIndex = 0;
            // 
            // lblNivelPerfil
            // 
            lblNivelPerfil.AutoSize = true;
            lblNivelPerfil.Location = new Point(22, 86);
            lblNivelPerfil.Name = "lblNivelPerfil";
            lblNivelPerfil.Size = new Size(55, 25);
            lblNivelPerfil.TabIndex = 1;
            lblNivelPerfil.Text = "Nível:";
            // 
            // lblPontuacaoTotalPerfil
            // 
            lblPontuacaoTotalPerfil.AutoSize = true;
            lblPontuacaoTotalPerfil.Location = new Point(366, 29);
            lblPontuacaoTotalPerfil.Name = "lblPontuacaoTotalPerfil";
            lblPontuacaoTotalPerfil.Size = new Size(140, 25);
            lblPontuacaoTotalPerfil.TabIndex = 2;
            lblPontuacaoTotalPerfil.Text = "Pontuação total:";
            // 
            // lblAcertosPerfil
            // 
            lblAcertosPerfil.AutoSize = true;
            lblAcertosPerfil.Location = new Point(366, 76);
            lblAcertosPerfil.Name = "lblAcertosPerfil";
            lblAcertosPerfil.Size = new Size(76, 25);
            lblAcertosPerfil.TabIndex = 3;
            lblAcertosPerfil.Text = "Acertos:";
            // 
            // lblPerguntasRespondidasPerfil
            // 
            lblPerguntasRespondidasPerfil.AutoSize = true;
            lblPerguntasRespondidasPerfil.Location = new Point(366, 134);
            lblPerguntasRespondidasPerfil.Name = "lblPerguntasRespondidasPerfil";
            lblPerguntasRespondidasPerfil.Size = new Size(197, 25);
            lblPerguntasRespondidasPerfil.TabIndex = 4;
            lblPerguntasRespondidasPerfil.Text = "Perguntas respondidas:";
            // 
            // lblMaiorSequenciaAcertosPerfil
            // 
            lblMaiorSequenciaAcertosPerfil.AutoSize = true;
            lblMaiorSequenciaAcertosPerfil.Location = new Point(366, 195);
            lblMaiorSequenciaAcertosPerfil.Name = "lblMaiorSequenciaAcertosPerfil";
            lblMaiorSequenciaAcertosPerfil.Size = new Size(232, 25);
            lblMaiorSequenciaAcertosPerfil.TabIndex = 5;
            lblMaiorSequenciaAcertosPerfil.Text = "Maior sequência de acertos:";
            // 
            // lblConquistasPerfil
            // 
            lblConquistasPerfil.AutoSize = true;
            lblConquistasPerfil.Location = new Point(22, 266);
            lblConquistasPerfil.Name = "lblConquistasPerfil";
            lblConquistasPerfil.Size = new Size(100, 25);
            lblConquistasPerfil.TabIndex = 6;
            lblConquistasPerfil.Text = "Conquistas";
            // 
            // btnVoltarPerfil
            // 
            btnVoltarPerfil.BackColor = SystemColors.GradientInactiveCaption;
            btnVoltarPerfil.FlatAppearance.BorderColor = Color.Gold;
            btnVoltarPerfil.FlatStyle = FlatStyle.Flat;
            btnVoltarPerfil.Location = new Point(676, 403);
            btnVoltarPerfil.Name = "btnVoltarPerfil";
            btnVoltarPerfil.Size = new Size(112, 35);
            btnVoltarPerfil.TabIndex = 7;
            btnVoltarPerfil.Text = "Voltar";
            btnVoltarPerfil.UseVisualStyleBackColor = false;
            btnVoltarPerfil.Click += btnVoltarPerfil_Click;
            // 
            // FrmTelaDePerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarPerfil);
            Controls.Add(lblConquistasPerfil);
            Controls.Add(lblMaiorSequenciaAcertosPerfil);
            Controls.Add(lblPerguntasRespondidasPerfil);
            Controls.Add(lblAcertosPerfil);
            Controls.Add(lblPontuacaoTotalPerfil);
            Controls.Add(lblNivelPerfil);
            Controls.Add(lblNicknamePerfil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTelaDePerfil";
            Text = "FrmTelaDePerfil";
            Load += FrmTelaDePerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNicknamePerfil;
        private Label lblNivelPerfil;
        private Label lblPontuacaoTotalPerfil;
        private Label lblAcertosPerfil;
        private Label lblPerguntasRespondidasPerfil;
        private Label lblMaiorSequenciaAcertosPerfil;
        private Label lblConquistasPerfil;
        private Button btnVoltarPerfil;
    }
}