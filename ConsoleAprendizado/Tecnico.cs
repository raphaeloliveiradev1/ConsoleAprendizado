using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApredizado
{
    public class Tecnico
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set;}
        public int Idade { get; set;}
        public String Endereco { get; set;}
        public int CPF { get; set;}
        public int Telefone { get; set; }
        public Boolean PossuiComissaoTecnica { get; set;}
        public DateTime TempoDeContrato { get; set;}
        public float Salario { get; set;}
        public String PerfilTecnico { get; set;}
        public String UltimoClube { get; set;}
    }
}
