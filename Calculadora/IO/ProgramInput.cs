using Calculadora.Interfaces.IO;
using Calculadora.Models.Operations.Core;

namespace Calculadora.IO
{
    public class ProgramInput : IProgramInput
    {
        private readonly IProgramOutput _programOutput;

        public ProgramInput(IProgramOutput programOutput)
        {
            _programOutput = programOutput;
        }
        public int? GetOptionNumber()
        { 
            if (int.TryParse(Console.ReadLine(), out int optionNumber)){
                return optionNumber;
            }
            return null;
        }

        public List<double> GetNumbers(Operation operation)
        {
            var numbers = new List<double>();
            if (operation is OneNumberOperation)
            {
                var number = GetNumberByMessage("\nDigite um número: ");
                numbers.Add(number);
            }
            else
            {
                var number = GetNumberByMessage("\nDigite o primeiro número: "); ;
                numbers.Add(number);

                number = GetNumberByMessage("Digite o segundo número: ");
                numbers.Add(number);
            }
            return numbers;
        }

        private static double GetInputNumber()
        {
            if (!double.TryParse(Console.ReadLine(), out double number)){
                throw new Exception("Número Inválido!");
            }
            return number;
        }

        private double GetNumberByMessage(string message)
        {
            _programOutput.ShowMessage(message);
            var number = GetInputNumber();
            return number;
        }
    }
}
