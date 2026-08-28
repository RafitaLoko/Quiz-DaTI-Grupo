using Quiz_GrupoSenac.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz_GrupoSenac.Repositories;


namespace Quiz_GrupoSenac
{
    public partial class FrmQuiz : Form
    {
        List<Pergunta> perguntas;
        int numeroPergunta = 0;

        PerguntaRepository repository =
            new PerguntaRepository();


        public FrmQuiz()
        {
            InitializeComponent();
        }

        private void btnProximaQuiz_Click(object sender, EventArgs e)
        {
            Pergunta pergunta = perguntas[numeroPergunta];

            int respostaEscolhida = -1;

            if (rbResposta1.Checked)
                respostaEscolhida = 0;
            else if (rbResposta2.Checked)
                respostaEscolhida = 1;
            else if (rbResposta3.Checked)
                respostaEscolhida = 2;
            else if (rbResposta4.Checked)
                respostaEscolhida = 3;


            if (respostaEscolhida == -1)
            {
                MessageBox.Show("Escolha uma resposta.");
                return;
            }

            bool acertou = pergunta.Alternativas[respostaEscolhida].Correta;

            
            //if (numeroPergunta == 9)
            //{
            //    FinalizarQuiz();
            //    return;
            //}

            numeroPergunta++;

            Pergunta proxima = perguntas[numeroPergunta];
            lblPerguntaNumeroQuiz.Text = "Pergunta" + (numeroPergunta + 1) + " de 10";

            lblPerguntaQuiz.Text = proxima.Enunciado;
            lblTemaQuiz.Text = "Tema: " + proxima.Tema;
            lblNickQuiz.Text = "Nivel: " + proxima.Nivel;
            //lblPontuacaoQuiz = "Vale: " + proxima.Pontuacao + " pontos";

            rbResposta1.Text = proxima.Alternativas[0].Texto;
            rbResposta2.Text = proxima.Alternativas[1].Texto;
            rbResposta3.Text = proxima.Alternativas[2].Texto;
            rbResposta4.Text = proxima.Alternativas[3].Texto;
            
            if (numeroPergunta == 9)
            {
                btnProximaQuiz.Text = "Finalizar";
            }

        }

        private async void FrmQuiz_Load(object sender, EventArgs e)
        {



            perguntas = await PerguntaRepository.BuscarPerguntas();
            Pergunta pergunta = perguntas[numeroPergunta];

            lblPerguntaNumeroQuiz.Text = "Pergunta 1 de 10";
            lblPerguntaQuiz.Text = pergunta.Enunciado;
            lblTemaQuiz.Text = "Tema: " + pergunta.Tema;
            lblNivelQuiz.Text = "Nível: " + pergunta.Nivel;
            lblPontuacaoQuiz.Text = "Vale: " + pergunta.Pontuacao + " pontos";
            lblNickQuiz.Text = Sessao.UsuarioLogado.Nick;

            rbResposta1.Text = pergunta.Alternativas[0].Texto;
            rbResposta2.Text = pergunta.Alternativas[1].Texto;
            rbResposta3.Text = pergunta.Alternativas[2].Texto;
            rbResposta4.Text = pergunta.Alternativas[3].Texto;


        }

        private void lblNickQuiz_Click(object sender, EventArgs e)
        {
         
        }
    }
}
