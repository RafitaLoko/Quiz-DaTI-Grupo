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
    public class PerguntaRepository
    {
        private static Conexao conexao = new Conexao();

        public static async Task<int> Cadastrar(Pergunta pergunta)
        {
            int idPergunta = await conexao.Conectar().QueryFirstOrDefaultAsync<int>(
            @"
                INSERT INTO Pergunta (Enunciado, Tipo, Nivel, Tema, Pontuacao)
                VALUES (@Enunciado, @Tipo, @Nivel, @Tema, @Pontuacao) 
                RETURNING Id
            ",
            pergunta
             );

            return idPergunta;
        }

        public static async Task <List<Pergunta>> BuscarPerguntas()
        {
            string sql = @"
              SELECT 
                p.Id,
                p.Enunciado,
                p.Tipo,
                p.Nivel,
                p.Tema,
                p.Pontuacao,

                a.Id,
                a.PerguntaId,
                a.Texto,
                a.Correta
                
                FROM Pergunta p

                INNER JOIN Alternativa a
                ON a.PerguntaId = p.Id

                ORDER BY p.Id, a.Id;

           ";

            var perguntas = new Dictionary<int, Pergunta>();

            await conexao.Conectar().QueryAsync<Pergunta, Alternativa, Pergunta>(
                sql,
                (pergunta, alternativa) =>
                {
                    if (!perguntas.TryGetValue(pergunta.Id, out var perguntaExistente))
                    {
                        perguntaExistente = pergunta;
                        perguntaExistente.Alternativas = [];
                        perguntas.Add(pergunta.Id, perguntaExistente);
                    }

                    if (alternativa is not null && alternativa.Id != 0)
                    {
                        perguntaExistente.Alternativas.Add(alternativa);
                    }

                    return perguntaExistente;
                },
                splitOn: "Id"
                );

            var resultado = perguntas.Values.ToList();

            return resultado;

        }





    }
}
