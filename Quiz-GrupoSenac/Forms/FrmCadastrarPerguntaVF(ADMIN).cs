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
            cbPontuacaoPergunta.SelectedIndex = -1;


            rbVerdadeiro.Checked = false;
            rbFalso.Checked = false;


            txtEnuciado.Focus();
        }
    }
}
