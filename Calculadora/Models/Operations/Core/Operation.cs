using Calculadora.Interfaces;
using Calculadora.Models.Historic;

namespace Calculadora.Models.Operations.Core
{
    public abstract class Operation : IOperation
    {
        public List<double> Numbers { get; set; }

        public string Simbol { get; set; }

        public Operation(List<double> numbers, string simbol)
        {
            SetNumbers(numbers);
            Simbol = simbol;
        }

        public void SetNumbers(List<double> numbers)
        {
            Numbers = numbers;
        }

        public abstract double Calculate();
    }
}
