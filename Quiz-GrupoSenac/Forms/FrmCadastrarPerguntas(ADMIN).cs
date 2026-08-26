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
    public partial class CadastrarPerguntas_ADMIN_ : Form
    {
        public CadastrarPerguntas_ADMIN_()
        {
            InitializeComponent();
        }

        private void btnCadastrarPergunta_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEnuciado.Clear();

            txtAlternativa1.Clear();
            txtAlternativa2.Clear();
            txtAlternativa3.Clear();
            txtAlternativa4.Clear();

            cbTipoPergunta.SelectedIndex = -1;
            cbNivelPergunta.SelectedIndex = -1;
            cbTemaPergunta.SelectedIndex = -1;
            cbPontuacaoPergunta.SelectedIndex = -1;
            cbRespostaCorreta.SelectedIndex = -1;

            txtEnuciado.Focus();
        }

        private void CadastrarPerguntas_ADMIN__Load(object sender, EventArgs e)
        {

        }
    }
}
