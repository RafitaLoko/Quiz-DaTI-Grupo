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

namespace Quiz_GrupoSenac.Forms
{
    public partial class FrmQuizVF : Form
    {

        List<Pergunta> perguntas;
        int numeroPergunta = 0;

        PerguntaRepository repository = new PerguntaRepository();


        public FrmQuizVF()
        {
            InitializeComponent();
        }

        private void FrmQuizVF_Load(object sender, EventArgs e)
        {
            

            Pergunta pergunta = perguntas[numeroPergunta];


            lblPerguntaNumeroQuiz.Text = "Pergunta 1 de 10";
            lblPerguntaQuiz.Text = pergunta.Enunciado;
            lblTemaQuiz.Text = "Tema: " + pergunta.Tema;
            lblNivelQuiz.Text = "Nível: " + pergunta.Nivel;
            //lblValorQuiz.Text = "Valor: " + pergunta.Valor;
            lblPontuacaoQuiz.Text = "Vale: " + pergunta.Pontuacao + " Pontos";
            lblNickQuiz.Text = Sessao.UsuarioLogado.Nick;


            rbVerdadeiroQuiz.Text = pergunta.Alternativas[0].Texto;
            rbFalsoQuiz.Text = pergunta.Alternativas[1].Texto;



        }
    }
}
