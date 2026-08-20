using Dapper;
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

        public static async Task Cadastrar(Usuario usuario)
        {
            await conexao.Conectar().QueryAsync(
                @"
                    INSERT INTO Usuario (Nome, Nick, DataNascimento, Senha, Tipo, PontuacaoTotal)
                    VALUES (@Nome, @Nick, @DataNascimento, @Senha, @Tipo, @PontuacaoTotal)
                ",
                usuario
                 );
            
            
        }

        public static async Task<Usuario> BuscarPorNick(string nick)
        {
            var usuario = await conexao.Conectar().QueryFirstOrDefaultAsync<Usuario>(
                @"
                    SELECT 
                        Id,
                        Nome,
                        Nick,
                        DataNascimento,
                        Senha,
                        Tipo,
                        PontuacaoTotal
                    FROM
                        Usuario
                    WHERE
                        Nick = @Nick
                    ",
                new
                {
                    Nick = nick
                }
                );
            return usuario;

         
        }
    }
}


        
