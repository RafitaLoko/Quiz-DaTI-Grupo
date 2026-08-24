namespace Quiz_GrupoSenac
{
    partial class FrmRanking
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
            dataGridView1 = new DataGridView();
            Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(799, 376);
            dataGridView1.TabIndex = 0;
            // 
            // Voltar
            // 
            Voltar.BackColor = Color.PaleGreen;
            Voltar.FlatAppearance.BorderColor = Color.Red;
            Voltar.FlatStyle = FlatStyle.Flat;
            Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Voltar.Location = new Point(343, 380);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(140, 42);
            Voltar.TabIndex = 1;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = false;
            Voltar.Click += Voltar_Click;
            // 
            // FrmRanking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(Voltar);
            Controls.Add(dataGridView1);
            Name = "FrmRanking";
            Text = "TelaRanking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Voltar;
    }
}