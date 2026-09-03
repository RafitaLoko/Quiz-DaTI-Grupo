using Dapper;
using Quiz_GrupoSenac.Banco;
using Quiz_GrupoSenac.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Repositories
{
    public class ResultadosRepository
    {
        private static Conexao conexao = new Conexao();

        public static async Task Cadastrar(ResultadoQuiz resultado)
        {
            await conexao.Conectar().QueryAsync(
                 @"INSERT INTO Resultados
(nick_id, pontuacao_total, maior_sequencia, acertos, erros)
                   VALUES
(@NickId, @PontuacaoTotal, @MaiorSequencia, @Acertos, @Erros)",

                 resultado
                );
        }


        



    }
}