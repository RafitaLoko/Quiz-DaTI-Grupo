using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Modelos
{
    public class Pergunta
    {
        public int Id { get; set; }

        public string Enunciado { get; set; }

        public string Tipo { get; set; }

        public string Nivel { get; set; }

        public string Tema { get; set; }

        public int Pontuacao { get; set; }

        public List<Alternativa> alternativas { get; set; }


    }
}
