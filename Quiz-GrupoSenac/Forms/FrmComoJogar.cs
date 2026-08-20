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
    public partial class FrmComoJogar : Form
    {
        public FrmComoJogar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }

        private void FrmComoJogar_Load(object sender, EventArgs e)
        {

        }
    }
}
