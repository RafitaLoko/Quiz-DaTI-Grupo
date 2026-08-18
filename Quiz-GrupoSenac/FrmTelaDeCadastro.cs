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

        private void btnCadastrarTelaCadastro_Click(object sender, EventArgs e)
        {
            if (txtSenhaTelaCadastro.Text != txtConfirmarSenhaTelaCadastro.Text)
            {
                MessageBox.Show("As senhas não conferem.");
                return;
            }

            string senhaCriptografada =
                BCrypt.Net.BCrypt.HashPassword(txtSenhaTelaCadastro.Text);

            Usuario usuario = new Usuario();

            usuario.Nome = txtSenhaTelaCadastro.Text;
            usuario.Nick = txtNickTelaCadastro.Text;
            usuario.DataNascimento = DateTime.Now;
            usuario.Senha = senhaCriptografada;
            usuario.Tipo = "Aluno";

            UsuarioRepository repository = new UsuarioRepository();

            repository.Cadastrar(usuario);

            MessageBox.Show("Usuário cadastrado!");

        }

        private void btnCancelarTelaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaDeCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
