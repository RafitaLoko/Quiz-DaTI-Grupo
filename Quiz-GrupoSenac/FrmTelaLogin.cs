namespace Quiz_GrupoSenac
{
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
        }

        private void FrmTelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastreTelaLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaDeCadastro frmTelaDeCadastro = new FrmTelaDeCadastro();
            this.Show();
        }
    }
}
