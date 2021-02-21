using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_2
{
    public class FuncionarioService
    {
        public decimal AtualizaSalario(Funcionario funcionario, int ano)
        {
            var novoSalario = funcionario.SalarioInicial;
            int anoCorrente = funcionario.AnoContratacao + 1;
            float incremento = 1;
            float percentualCorrente = funcionario.Percentual;

            while (anoCorrente < ano)
            {
                percentualCorrente *= incremento;

                novoSalario += novoSalario * (decimal)percentualCorrente;

                if (incremento < 2)
                    incremento++;

                anoCorrente++;
            }

            return novoSalario;
        }


    }
}
