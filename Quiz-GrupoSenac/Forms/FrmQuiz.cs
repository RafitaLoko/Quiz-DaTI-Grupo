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
        int numeroPergunta = 0;
        int pontuacaoTotal = 0;
        int sequenciaAcertos = 0;
        int maiorSequencia = 0;


        List<Pergunta> perguntas;

        List<string> resultados = new List<string>(); 
        
        
       




        public FrmQuiz()
        {
            InitializeComponent();
        }

        private void btnProximaQuiz_Click(object sender, EventArgs e)
        {

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

            btnProximaQuiz.Text = "Próxima";

            if (perguntas.Count < 10)
            {
                MessageBox.Show("Não existem 10 perguntas cadastradas.");
                return;
            }

        }

        private void lblNickQuiz_Click(object sender, EventArgs e)
        {
         
        }
    }
}
