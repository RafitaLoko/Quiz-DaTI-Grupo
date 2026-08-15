using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Nick { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Senha { get; set; }

        public string Tipo { get; set; }

        public int PontuacaoTotal { get; set; }

    }
}
