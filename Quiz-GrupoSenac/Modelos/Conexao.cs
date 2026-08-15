using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Quiz_GrupoSenac.Modelos
{
    public class Conexao
    {
        private string connectionString =
            "Host=localhost;Port=5432;Database=quiz_informatica;Username=postgres;Password=1234";
        public NpgsqlConnection Conectar()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
