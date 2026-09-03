using BCrypt.Net;
using Quiz_GrupoSenac.Modelos;
using Quiz_GrupoSenac.Repositories;
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

        private async void btnCadastrarTelaCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenhaTelaCadastro.Text != txtConfirmarSenhaTelaCadastro.Text)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }


            string senha = txtSenhaTelaCadastro.Text;
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }

            if (!senha.Any(char.IsUpper))
            {
                MessageBox.Show("A senha deve ter pelo menos uma letra maiúscula.");
                return;
            }

            if (!senha.Any(char.IsLower))
            {
                MessageBox.Show("A senha deve ter pelo menos uma letra minúscula.");
                return;
            }

            if (!senha.Any(char.IsDigit))
            {
                MessageBox.Show("A senha deve ter pelo menos um número.");
                return;
            }

            if (!senha.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("A senha deve ter pelo menos um caractere especial!");
                return;
            }

            string senhaCriptografada =
                BCrypt.Net.BCrypt.HashPassword(txtSenhaTelaCadastro.Text);

            Usuario usuario = new Usuario();

            usuario.Nome = txtNomeCompletoTelaCadastro.Text;
            usuario.Nick = txtNickTelaCadastro.Text;
            usuario.DataNascimento = DateTime.Now;
            usuario.Senha = senhaCriptografada;
            usuario.Tipo = "Aluno";

            await UsuarioRepository.Cadastrar(usuario);

            MessageBox.Show("Usuário cadastrado!");

            this.Hide();
            FrmTelaLogin frmTelaLogin = new FrmTelaLogin();
            frmTelaLogin.ShowDialog();

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
