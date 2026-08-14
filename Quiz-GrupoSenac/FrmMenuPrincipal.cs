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
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaDePerfil frmTelaDePerfil = new FrmTelaDePerfil();
            this.Show(frmTelaDePerfil);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
