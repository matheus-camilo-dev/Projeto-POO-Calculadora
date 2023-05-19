using Calculadora.Exceptions;
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
                throw new RestartProgramException("Não há nada no histórico!");
            }

            BreakLine();
            ShowMessage("Histórico de operações:\n");
            for (int i = 0; i < historyOperations.Count; i++)
            {
                ShowOperationResult(historyOperations[i].Numbers, historyOperations[i].Simbol, historyOperations[i].Result);
            }
        }

        public void ShowMenuOptions()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("[ 1 ] SOMA");
            Console.WriteLine("[ 2 ] SUBTRAÇÃO");
            Console.WriteLine("[ 3 ] MULTIPLICAÇÃO");
            Console.WriteLine("[ 4 ] DIVISÃO");
            Console.WriteLine("[ 5 ] ELEVAR NÚMERO AO QUADRADO");
            Console.WriteLine("[ 6 ] ELEVAR NÚMERO AO CUBO");
            Console.WriteLine("[ 7 ] RAIZ QUADRADA");
            Console.WriteLine("[ 8 ] RAIZ CÚBICA");
            Console.WriteLine("[ 9 ] MOSTRAR HISTÓRICO");
            Console.WriteLine("[ 0 ] SAIR");
            Console.WriteLine("==========================");

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
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
        }

        public void ShowOperationResult(List<double> numbers, string simbol, double result)
        {
            Console.Write($"Operação: {numbers[0]} {simbol}");

            if (numbers.Count == 2)
            {
                Console.Write($" {numbers[1]}");
            }

            Console.WriteLine($" = {result}");
        }

        public void BreakLine()
        {
            ShowMessage("\n");
        }
    }
}
