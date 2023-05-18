using Calculadora.Exceptions;
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
            throw new RestartProgramException("Opção Incorreta! Tente Novamente!");
        }

        public List<double> GetNumbers(Operation operation, double result, bool hasHistoric)
        {
            var numbers = new List<double>();
            if (operation is OneNumberOperation)
            {
                var number = GetNumberByMessage("\nDigite um número: ", result, hasHistoric);
                numbers.Add(number);
            }
            else
            {
                var number = GetNumberByMessage("\nDigite o primeiro número: ", result, hasHistoric);
                numbers.Add(number);

                number = GetNumberByMessage("Digite o segundo número: ", result, hasHistoric);
                numbers.Add(number);
            }
            return numbers;
        }

        private static double GetInputNumber(double result)
        {
            var input = Console.ReadLine();
            if (input == "")
            {
                return result;
            }
            if (!double.TryParse(input, out double number)){
                throw new RestartProgramException("Número Inválido!");
            }
            return number;
        }

        private double GetNumberByMessage(string message, double result, bool hasHistoric)
        {
            if (hasHistoric)
            {
                message = $"{message}[Pressione enter para pegar o resultado anterior] ";
            }
            _programOutput.ShowMessage(message);
            var number = GetInputNumber(result);
            return number;
        }
    }
}
