using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_2
{
    public class Funcionario
        : Pessoa
    {
        public decimal SalarioInicial { get; set; }

        public float Percentual { get; set; }

        public decimal SalarioTotal { get; set; }

        public int AnoContratacao { get; set; }
    }
}
