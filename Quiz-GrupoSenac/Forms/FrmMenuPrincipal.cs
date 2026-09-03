using Quiz_GrupoSenac.Modelos;
using Quiz_GrupoSenac.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_GrupoSenac
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            //int usuarioId = Sessao.UsuarioLogado.Id;
            //ResultadosRepository repository = new ResultadosRepository();

            // bool jaFez = await repository.JaFezQuizHoje(nick);

            //if (jaFez)
            //{
            //    MessageBox.Show("Você já realizou o quiz hoje. Tente novamente amanhã!");
            //    return;
            //}

            FrmQuiz quiz = new FrmQuiz();
            quiz.ShowDialog();
            this.Hide();   
            
=======
            this.Hide();
            FrmQuiz frmQuiz = new FrmQuiz();
            frmQuiz.ShowDialog();
>>>>>>> a9700d055aefdbaacca593414fa9ce02e7fcb763
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRanking frmRanking = new FrmRanking();
            frmRanking.ShowDialog();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaHistorico frmTelaHistorico = new FrmTelaHistorico();
            frmTelaHistorico.ShowDialog();
            this.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaDePerfil frmTelaDePerfil = new FrmTelaDePerfil();
            frmTelaDePerfil.ShowDialog();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComoJogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmComoJogar frmComoJogar = new FrmComoJogar();
            frmComoJogar.ShowDialog();
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
