using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_GrupoSenac.Modelos
{
    public class ResultadoQuiz
    {
        public int NickId { get; set; }
        public int PontuacaoTotal { get; set;}

        public int MaiorSequencia {  get; set;}

        public int Acertos {  get; set;}

        public int Erros {  get; set;}

    }
}
