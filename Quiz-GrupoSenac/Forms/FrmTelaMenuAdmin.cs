using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_GrupoSenac.Forms
{
    public partial class FrmTelaMenuAdmin : Form
    {
        public FrmTelaMenuAdmin()
        {
            InitializeComponent();
        }

        private void FrmTelaMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRanking frmRanking = new FrmRanking();
            frmRanking.ShowDialog();
        }

        private void btnCadastrarPerguntasQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastrarPerguntaVF_ADMIN_ cadastrarPeguntas = new FrmCadastrarPerguntaVF_ADMIN_();
            cadastrarPeguntas.ShowDialog();
        }

        private void btnCadastrarPerguntasVF_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastrarPerguntaVF_ADMIN_ frmCadastrarPerguntaVF_ADMIN_ = new FrmCadastrarPerguntaVF_ADMIN_();
            frmCadastrarPerguntaVF_ADMIN_.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja realmente sair?", "Confirmar", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
