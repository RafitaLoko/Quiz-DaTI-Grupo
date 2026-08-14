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
            lblNicknamePerfil = new Label();
            lblNivelPerfil = new Label();
            SuspendLayout();
            // 
            // lblNicknamePerfil
            // 
            lblNicknamePerfil.AutoSize = true;
            lblNicknamePerfil.Location = new Point(22, 19);
            lblNicknamePerfil.Name = "lblNicknamePerfil";
            lblNicknamePerfil.Size = new Size(90, 25);
            lblNicknamePerfil.TabIndex = 0;
            lblNicknamePerfil.Text = "Nickname";
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
            // FrmTelaDePerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNivelPerfil);
            Controls.Add(lblNicknamePerfil);
            Name = "FrmTelaDePerfil";
            Text = "FrmTelaDePerfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNicknamePerfil;
        private Label lblNivelPerfil;
    }
}