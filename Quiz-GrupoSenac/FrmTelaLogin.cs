using Quiz_GrupoSenac.Modelos;
using Quiz_GrupoSenac.Repositories;

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

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Usuario usuario = await UsuarioRepository.BuscarPorNick(txtNick.Text);
=======
            if (txtNick.Text == "admin" &&  txtSenha.Text == "1234")
            {
                this.Hide();
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Nick ou Senha invalidos");
            }

>>>>>>> bc2ba16b4a73661876337e327705aca17e6a54f2

            if (usuario != null && BCrypt.Net.BCrypt.Verify(txtSenha.Text, usuario.Senha))
            {
                this.Hide();
                FrmMenuPrincipal menu = new FrmMenuPrincipal(usuario);
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nick ou Senha incorretos.");
            }
        }

        private void btnCadastreTelaLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaDeCadastro frmTelaDeCadastro = new FrmTelaDeCadastro();
            frmTelaDeCadastro.Show();
        }
    }
}
