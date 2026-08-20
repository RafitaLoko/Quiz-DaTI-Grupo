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
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(usuario);
            this.Show();
        }
    }
}
