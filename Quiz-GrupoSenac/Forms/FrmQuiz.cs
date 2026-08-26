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

        }

        private void FrmQuiz_Load(object sender, EventArgs e)
        {
            lblNickQuiz.Text = Sessao.UsuarioLogado.Nick;

           


        }

        private void lblNickQuiz_Click(object sender, EventArgs e)
        {
         
        }
    }
}
