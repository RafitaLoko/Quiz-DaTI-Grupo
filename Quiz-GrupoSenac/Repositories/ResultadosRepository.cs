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


        public static async Task<List<ResultadoQuiz>> ObterRanking()
        {
            var resultado = await conexao.Conectar().QueryAsync<ResultadoQuiz>(
                @"SELECT u.Nick, r.pontuacao_total AS PontuacaoTotal, r.acertos AS Acertos, r.maior_sequencia AS MaiorSequencia
                        FROM Resultados r
                    INNER JOIN Usuario u ON r.nick_id = u.Id
                    ORDER BY r.pontuacao_total DESC
                    LIMIT 10"

                  );
            return resultado.ToList();
        }


    //    public async Task<bool> JaFezQuizHoje(int usuarioId)
    //    {
    //        string sql = @"
    //    SELECT COUNT(*)
    //    FROM Resultado
    //    WHERE UsuarioId = @UsuarioId
    //    AND DATE(DataHora) = CURRENT_DATE
    //";

    //        using (var conexao = Conexao.Conectar())
    //        {
    //            int quantidade = await conexao.ExecuteScalarAsync<int>(
    //                sql,
    //                new { UsuarioId = usuarioId }
    //            );

    //            return quantidade > 0;
    //        }
    //    }









        public static async Task<List<ResultadoQuiz>> ObterHistorico(int nickId)
        {
            var resultado = await conexao.Conectar().QueryAsync<ResultadoQuiz>(
                @"SELECT u.Nick, r.pontuacao_total AS PontuacaoTotal, r.acertos AS Acertos, r.erros AS Erros, r.maior_sequencia AS MaiorSequencia
                        FROM Resultados r
                    INNER JOIN Usuario u ON r.nick_id = u.Id
                    WHERE r.nick_id = @NickId
                    ORDER BY r.id DESC
                    ",
                new { NickId = nickId }

                  );
            return resultado.ToList();
        }

        public static async Task<ResultadoQuiz>ObterTotaisUsuario(int nickId)
        {
            var resultado = await conexao.Conectar().QueryFirstOrDefaultAsync<ResultadoQuiz>(
                @"SELECT
                COALESCE(SUM(pontuacao_total), 0) AS PontuacaoTotal,
                COALESCE(SUM(acertos), 0) AS Acertos,
                COALESCE(SUM(acertos + erros), 0) AS PerguntasRespondidas,
                COALESCE(MAX(maior_sequencia), 0) AS MaiorSequencia
                FROM Resultados
                WHERE nick_id = @NickId",
                new { NickId = nickId }
              );
            return resultado;
        }




    }
}