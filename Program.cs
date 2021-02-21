using System;
using System.Globalization;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario
            {
                Nome = "Marcio",
                RG = "23.567.890-4",
                SalarioInicial = 1000,
                AnoContratacao = 2016,
                Percentual = 1.5f / 100
            };

            var service = new FuncionarioService();
            var salarioAtualizado2020 = service.AtualizaSalario(funcionario, 2020);

            Console.WriteLine($"Nome:\t\t {funcionario.Nome}");
            Console.WriteLine($"RG:\t\t {funcionario.RG}");
            Console.WriteLine($"Salário:\t {salarioAtualizado2020.ToString("C2", CultureInfo.CurrentCulture)}(em 2020)");

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }

        public static decimal AtualizaSalario(Funcionario funcionario, int ano)
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
