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

            lblPontuacao.Text = pontuacaoTotal.ToString();
            lblSequencia.Text = maiorSequencia.ToString();
            lblAcertos.Text = resultados.Count(r => r.Acertou).ToString();
            lblErros.Text = resultados.Count(r => !r.Acertou).ToString();

            foreach (var r in resultados)
            {

                string status = r.Acertou ? "✔️ Acertou" : "❌ Errou";
                lstResultados.Items.Add($"{r.EnunciadoResultado} - {status} ({r.PontosGanhos} pontos)");
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void FrmTelaResultadoQuiz_Load(object sender, EventArgs e)
        {




        }
    }
}
