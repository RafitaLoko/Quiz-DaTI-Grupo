using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Modelos
{
    public class UsuarioRanking
    {
        public int UsuarioId {get; set; }

        public int PontuacaoTotal {get; set; }

        public int NumeroAcertos {get; set; }

        public int TotalPerguntasRespondidas {get; set; }

        public int AcertosConcecutivos {get; set; }

        public string TemaMaisAcertado {get; set; }
    }
}
