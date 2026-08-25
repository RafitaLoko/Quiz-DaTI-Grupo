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

        public static async Task Cadastrar(Pergunta pergunta)
        {
            await conexao.Conectar().QueryAsync(
            @"
                INSERT INTO Pergunta (Enunciado, Tipo, Nivel, Tema, Pontuacao)
                VALUES (@Enunciado, @Tipo, @Nivel, @Tema, @Pontuacao)
            ",
            pergunta
             );

        }

        public static async void BuscarPorEnunciado(string enunciado)
        {
            var pergunta = await conexao.Conectar().QueryFirstOrDefaultAsync<Pergunta>(
           @"
              SELECT 
                Id,
                Enunciado,
                Tipo,
                Nivel,
                Tema,
                Pontuacao
              FROM
                Pergunta
              WHERE
                Enunciado = @Enunciado

           ",
            new
            {
                Enunciado = enunciado
            }
            );
            

        }





    }
}
