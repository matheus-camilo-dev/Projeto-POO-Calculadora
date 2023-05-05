using Calculadora.Interfaces.IO;
using Calculadora.Models.Historic;

namespace Calculadora.IO
{
    public class ProgramOutput : IProgramOutput
    {
        public void ShowHistoryOperations(List<HistoricOperation> historyOperations)
        {
            if (!historyOperations.Any())
            {
                Console.WriteLine("\nNão há nada na histórico!\n");
            }

            for (int i = 0; i < historyOperations.Count; i++)
            {
                ShowOperationResult(historyOperations[i].Numbers, historyOperations[i].Simbol, historyOperations[i].Result);
            }
        }

        public void ShowMenuOptions()
        {
            Console.WriteLine("[ 1 ] Adição");
            Console.WriteLine("[ 2 ] Subtração");
            Console.WriteLine("[ 3 ] Multiplicação");
            Console.WriteLine("[ 4 ] Divisão");
            Console.WriteLine("[ 5 ] Elevado ao quadrado");
            Console.WriteLine("[ 6 ] Elevado ao Cubo");
            Console.WriteLine("[ 7 ] Raiz Quadrada");
            Console.WriteLine("[ 8 ] Raiz Cubica");
            Console.WriteLine("[ 9 ] Mostrar Histórico");
            Console.WriteLine("[ 10 ] Sair");

            Console.Write("\nDigite o número da opção desejada: ");
        }

        public void ShowMessage(string message)
        {
            Console.Write(message);
        }

        public void ShowBanner()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("= C A L C U L A D O R A =");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        }

        public void ShowOperationResult(List<double> numbers, string simbol, double result)
        {
            Console.Write($"{numbers[0]} {simbol}");

            if (numbers.Count == 2)
            {
                Console.Write($" {numbers[1]}");
            }

            Console.WriteLine($" = {result}\n");
        }
    }
}
