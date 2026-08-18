namespace Quiz_GrupoSenac
{
    partial class FrmTelaHistorico
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
            dgvHistorico = new DataGridView();
            btnVoltarTelaHistorico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(12, 12);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.RowHeadersWidth = 62;
            dgvHistorico.Size = new Size(776, 368);
            dgvHistorico.TabIndex = 0;
            dgvHistorico.CellContentClick += dgvHistorico_CellContentClick;
            // 
            // btnVoltarTelaHistorico
            // 
            btnVoltarTelaHistorico.BackColor = Color.PaleGoldenrod;
            btnVoltarTelaHistorico.FlatAppearance.BorderColor = Color.Gold;
            btnVoltarTelaHistorico.FlatStyle = FlatStyle.Flat;
            btnVoltarTelaHistorico.Location = new Point(348, 386);
            btnVoltarTelaHistorico.Name = "btnVoltarTelaHistorico";
            btnVoltarTelaHistorico.Size = new Size(112, 34);
            btnVoltarTelaHistorico.TabIndex = 1;
            btnVoltarTelaHistorico.Text = "Voltar";
            btnVoltarTelaHistorico.UseVisualStyleBackColor = false;
            btnVoltarTelaHistorico.Click += btnVoltarTelaHistorico_Click;
            // 
            // FrmTelaHistorico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarTelaHistorico);
            Controls.Add(dgvHistorico);
            Name = "FrmTelaHistorico";
            Text = "FrmTelaHistorico";
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorico;
        private Button btnVoltarTelaHistorico;
    }
}