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
    public class AlternativaRepository
    {
        private static Conexao conexao = new Conexao();

        public static async Task Cadastrar(Alternativa alternativa)
        {
            await conexao.Conectar().QueryAsync(

                @"    INSERT INTO ( PerguntaId, Texto, Correta) 
                        VALUES ( @PerguntaId, @Texto, @Coreta)

              ",
                alternativa
                );
        }

        public static async Task<Alternativa> BuscarPergunta( int perguntaId)
        {
            var alternativa = await conexao.Conectar().QueryFirstOrDefaultAsync<Alternativa>(
            @"
                SELECT 
                    Id,
                    PerguntaId,
                    Texto,
                    Correta
                FROM
                    Alternativa
                WHERE
                    PerguntaId = @PerguntaId

            ",
            new
            {
                PerguntaId = perguntaId
            }
            );
            return alternativa;
        }


    }
}
