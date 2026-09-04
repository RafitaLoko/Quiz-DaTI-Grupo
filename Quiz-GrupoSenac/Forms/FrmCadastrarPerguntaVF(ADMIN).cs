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
    public partial class FrmCadastrarPerguntaVF_ADMIN_ : Form
    {
        private string AlternativaCorreta;

        public FrmCadastrarPerguntaVF_ADMIN_()
        {
            InitializeComponent();
        }

        private void FrmCadastrarPerguntaVF_ADMIN__Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEnuciado.Clear();


            cbTipoPergunta.SelectedIndex = -1;
            cbNivelPergunta.SelectedIndex = -1;
            cbTemaPergunta.SelectedIndex = -1;
            cbNivelPergunta.Items.Clear();
            rbVerdadeiro.Checked = false;
            rbFalso.Checked = false;


            txtEnuciado.Focus();
        }

        private async void btnCadastrarPergunta_Click(object sender, EventArgs e)
        {
            Pergunta pergunta = new Pergunta();

            pergunta.Enunciado = txtEnuciado.Text;
            pergunta.Tipo = (string)cbTipoPergunta.SelectedItem;
            pergunta.Nivel = (string)cbNivelPergunta.SelectedItem;
            pergunta.Tema = (string)cbTemaPergunta.SelectedItem;

            if (pergunta.Nivel == "Iniciante")
            {
                pergunta.Pontuacao = 10;
            }
            else if (pergunta.Nivel == "Fasil")
            {
                pergunta.Pontuacao = 20;
            }
            else if (pergunta.Nivel == "Intermediário")
            {
                pergunta.Pontuacao = 30;
            }
            else if (pergunta.Nivel == "Avançado")
            {
                pergunta.Pontuacao = 50;
            }

            int idPergunta = await PerguntaRepository.Cadastrar(pergunta);

            if (pergunta.Tipo == "Alternativa")
            {
                Alternativa alternativa1 = new Alternativa();

                alternativa1.Texto = txtAlternativa1.Text;
                alternativa1.PerguntaId = idPergunta;

                Alternativa alternativa2 = new Alternativa();

                alternativa2.Texto = txtAlternativa2.Text;
                alternativa2.PerguntaId = idPergunta;

                Alternativa alternativa3 = new Alternativa();

                alternativa3.Texto = txtAlternativa3.Text;
                alternativa3.PerguntaId = idPergunta;

                Alternativa alternativa4 = new Alternativa();

                alternativa4.Texto = txtAlternativa4.Text;
                alternativa4.PerguntaId = idPergunta;

                if (AlternativaCorreta == "1")
                    alternativa1.Correta = true;
                else if (AlternativaCorreta == "2")
                    alternativa2.Correta = true;
                else if (AlternativaCorreta == "3")
                    alternativa3.Correta = true;
                else if (AlternativaCorreta == "4")
                    alternativa4.Correta = true;

                await AlternativaRepository.Cadastrar(alternativa1);

                await AlternativaRepository.Cadastrar(alternativa2);

                await AlternativaRepository.Cadastrar(alternativa3);

                await AlternativaRepository.Cadastrar(alternativa4);
            }

            MessageBox.Show("Pergunta cadastrado!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlternativaCorreta = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlternativaCorreta = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlternativaCorreta = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlternativaCorreta = "4";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaMenuAdmin menuAdmin = new FrmTelaMenuAdmin();
            menuAdmin.ShowDialog();
        }
    }
}
