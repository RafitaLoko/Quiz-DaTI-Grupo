using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Quiz_GrupoSenac.Banco
{
    public class Conexao
    {
        private string connectionString =
            "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=admin";
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
