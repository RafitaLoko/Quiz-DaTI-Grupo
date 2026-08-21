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

namespace Quiz_GrupoSenac
{
    public partial class FrmTelaDePerfil : Form
    {
        public FrmTelaDePerfil()
        {
            InitializeComponent();
        }

        private void FrmTelaDePerfil_Load(object sender, EventArgs e)
        {


            lblNicknamePerfil.Text = Sessao.UsuarioLogado.Nick;
            //lblNivelPerfil.Text = Sessao.UsuarioLogado.
            //lblPontuacaoTotalPerfil.Text = Sessao.UsuarioLogado.PontuacaoTotal;
            //lblAcertosPerfil.Text = Sessao.UsuarioLogado.
            //lblPerguntasRespondidasPerfil.Text = Sessao.UsuarioLogado.
            //lblMaiorSequenciaAcertosPerfil.Text = Sessao.UsuarioLogado.
            //lblConquistasPerfil.Text = Sessao.UsuarioLogado.


        }

        private void btnVoltarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }
    }
}
