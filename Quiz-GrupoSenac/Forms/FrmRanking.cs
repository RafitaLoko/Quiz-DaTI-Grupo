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
    public partial class FrmRanking : Form
    {
        public FrmRanking()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }

        private async void FrmRanking_Load(object sender, EventArgs e)
        {
            var ranking = await ResultadosRepository.ObterRanking();
            dgvRanking.DataSource = ranking;


            dgvRanking.Columns["Nick"].HeaderText = "Jogador";
            dgvRanking.Columns["PontuacaoTotal"].HeaderText = "Pontuação";
            dgvRanking.Columns["Acertos"].HeaderText = "Acertos";
        }
    }
}
