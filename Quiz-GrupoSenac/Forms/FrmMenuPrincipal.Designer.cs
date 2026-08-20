namespace Quiz_GrupoSenac
{
    partial class FrmMenuPrincipal
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
            btnIniciar = new Button();
            btnVerRanking = new Button();
            btnHistorico = new Button();
            btnPerfil = new Button();
            btnComoJogar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.HotTrack;
            btnIniciar.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Location = new Point(308, 33);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(203, 56);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Quiz";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnVerRanking
            // 
            btnVerRanking.BackColor = Color.DodgerBlue;
            btnVerRanking.FlatAppearance.BorderColor = Color.Lime;
            btnVerRanking.FlatStyle = FlatStyle.Flat;
            btnVerRanking.Location = new Point(308, 134);
            btnVerRanking.Name = "btnVerRanking";
            btnVerRanking.Size = new Size(203, 56);
            btnVerRanking.TabIndex = 1;
            btnVerRanking.Text = "Ver Ranking";
            btnVerRanking.UseVisualStyleBackColor = false;
            btnVerRanking.Click += btnVerRanking_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.DeepSkyBlue;
            btnHistorico.FlatAppearance.BorderColor = Color.MediumSpringGreen;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Location = new Point(308, 240);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(203, 56);
            btnHistorico.TabIndex = 2;
            btnHistorico.Text = "Histórico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = SystemColors.InactiveCaption;
            btnPerfil.FlatAppearance.BorderColor = Color.DarkCyan;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(308, 347);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(203, 56);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnComoJogar
            // 
            btnComoJogar.BackColor = Color.LightSkyBlue;
            btnComoJogar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnComoJogar.FlatStyle = FlatStyle.Flat;
            btnComoJogar.Location = new Point(652, 404);
            btnComoJogar.Name = "btnComoJogar";
            btnComoJogar.Size = new Size(136, 34);
            btnComoJogar.TabIndex = 4;
            btnComoJogar.Text = "Como jogar";
            btnComoJogar.UseVisualStyleBackColor = false;
            btnComoJogar.Click += btnComoJogar_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComoJogar);
            Controls.Add(btnPerfil);
            Controls.Add(btnHistorico);
            Controls.Add(btnVerRanking);
            Controls.Add(btnIniciar);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            Load += FrmMenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnVerRanking;
        private Button btnHistorico;
        private Button btnPerfil;
        private Button btnComoJogar;
    }
}