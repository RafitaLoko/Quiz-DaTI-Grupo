using Npgsql;
using Quiz_GrupoSenac.Banco;
using Quiz_GrupoSenac.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Repositories
{
    public class UsuarioRepository
    {
        private static Conexao conexao = new Conexao();

        public void Cadastrar(Usuario usuario)
        {
            string sql = @" 
                INSERT INTO Usuario
                (Nome, Nick, DataNascimento, Senha, Tipo)
                VALUES
                (@Nome, @Nick, @DataNascimento, @Senha, @Tipo)";
            using (var conn = conexao.Conectar())
                using (var cmd = new NpgsqlCommand(sql, conn)) 
            {
                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Nick", usuario.Nick);
                cmd.Parameters.AddWithValue("@DataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Tipo", usuario);
                
                conn.Open();

                cmd.ExecuteNonQuery();
            
            }
        }
    }
}
