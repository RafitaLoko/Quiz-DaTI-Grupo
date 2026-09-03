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

namespace Quiz_GrupoSenac.Forms
{
    public partial class FrmTelaResultadoQuiz : Form
    {
        public FrmTelaResultadoQuiz(int pontuacaoTotal, int maiorSequencia, List<Resultado> resultados)
        {
            InitializeComponent();

            lblPontuacao.Text = "🏆 Pontos: " + pontuacaoTotal;
            lblSequencia.Text = "Maior sequencia: " + maiorSequencia;
            lblAcertos.Text = "Acertos: " + resultados.Count(r => r.Acertou).ToString();
            lblErros.Text = "Erros: " + resultados.Count(r => !r.Acertou).ToString();

            foreach (var r in resultados)
            {

                string status = r.Acertou ? "✔️ Acertou" : "❌ Errou";
                lstResultados.Items.Add($"{r.EnunciadoResultado} - {status} ({r.PontosGanhos} pontos)");
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.ShowDialog();

        }

        private void FrmTelaResultadoQuiz_Load(object sender, EventArgs e)
        {




        }

        private void lblPontuacao_Click(object sender, EventArgs e)
        {

        }
    }
}
