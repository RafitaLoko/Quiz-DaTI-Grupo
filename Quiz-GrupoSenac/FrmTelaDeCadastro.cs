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
    public partial class FrmTelaDeCadastro : Form
    {
        public FrmTelaDeCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarTelaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarTelaCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaLogin frmTelaLogin = new FrmTelaLogin();
            frmTelaLogin.ShowDialog();
        }

        private void FrmTelaDeCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
