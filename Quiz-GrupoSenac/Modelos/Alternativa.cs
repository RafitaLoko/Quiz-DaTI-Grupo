using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Modelos
{
    public class Alternativa
    {
        public int Id { get; set; }

        public int PerguntaId { get; set; }

        public string Texto { get; set; }

        public bool Correta { get; set; }


    }
}
