using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{

    public class Subtraction : TwoNumbersOperation
    {
        public Subtraction(List<double> numbers) : base(numbers, "-") { }

        public Subtraction() : base(new List<double> { 0, 0 }, "-") { }

        public override double Calculate()
        {
            return Numbers[0] - Numbers[1];
        }
    }
}
