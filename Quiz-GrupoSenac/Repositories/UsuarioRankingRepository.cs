using Dapper;
using Quiz_GrupoSenac.Banco;
using Quiz_GrupoSenac.Modelos;



namespace Quiz_GrupoSenac.Repositories
{
    public class UsuarioRankingRepository
    {
        private static Conexao Conexao = new Conexao();
        public static async Task<IEnumerable<UsuarioRanking>> ObterTodos()
        {
            var UsuarioRanking = await Conexao.Conectar().QueryAsync<UsuarioRanking>();
                
        }
    }
}

