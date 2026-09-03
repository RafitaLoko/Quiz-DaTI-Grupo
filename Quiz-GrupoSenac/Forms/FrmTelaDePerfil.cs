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
    public partial class FrmTelaDePerfil : Form
    {
        public FrmTelaDePerfil()
        {
            InitializeComponent();
        }

        private async void FrmTelaDePerfil_Load(object sender, EventArgs e)
        {
            var totais = await ResultadosRepository.ObterTotaisUsuario(Sessao.UsuarioLogado.Id);



            lblNicknamePerfil.Text = Sessao.UsuarioLogado.Nick;

            lblNivelPerfil.Text = "Iniciante";

            lblPontuacaoTotalPerfil.Text ="Pontuação Total: " + totais.PontuacaoTotal;
            lblAcertosPerfil.Text = "Acertos: " + totais.Acertos;
            lblPerguntasRespondidasPerfil.Text = "Perguntas respondidas: " + totais.PerguntasRespondidas;
            lblMaiorSequenciaAcertosPerfil.Text = "Maior sequência de acertos: " + totais.MaiorSequencia;
            


        }

        private void btnVoltarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }
    }
}
