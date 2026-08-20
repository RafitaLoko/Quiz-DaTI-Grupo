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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(Usuario Usuario)
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.Hide();   
            FrmQuiz frmQuiz = new FrmQuiz();
            frmQuiz.Show();
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaHistorico frmTelaHistorico = new FrmTelaHistorico();
            frmTelaHistorico.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaDePerfil frmTelaDePerfil = new FrmTelaDePerfil();
            frmTelaDePerfil.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComoJogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmComoJogar frmComoJogar = new FrmComoJogar();
            frmComoJogar.Show();
        }
    }
}
