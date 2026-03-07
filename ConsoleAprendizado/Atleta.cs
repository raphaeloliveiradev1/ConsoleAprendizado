using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApredizado
{
    public class Atleta
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Endereco { get; set; }
        public String Base { get; set; }
        public float PercentualMassa { get; set; }
        public float PesoAtual { get; set; }
        public String AreaAtuacao { get; set; }       
        public Boolean  EhBatedorDePenaltis { get; set; }
        public Boolean CanhatoOuDestro { get; set; }

    }
}
