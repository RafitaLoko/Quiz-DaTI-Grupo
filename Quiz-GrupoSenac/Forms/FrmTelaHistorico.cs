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
    public partial class FrmTelaHistorico : Form
    {
        public FrmTelaHistorico()
        {
            InitializeComponent();
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltarTelaHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();

        }

        private async void FrmTelaHistorico_Load(object sender, EventArgs e)
        {
            var historico = await ResultadosRepository.ObterHistorico(Sessao.UsuarioLogado.Id);
            dgvHistorico.DataSource = historico;

            dgvHistorico.Columns["Nick"].HeaderText = "Jogador";
            dgvHistorico.Columns["PontuacaoTotal"].HeaderText = "Pontuação";
            dgvHistorico.Columns["Acertos"].HeaderText = "Acertos";
        }
    }
}
