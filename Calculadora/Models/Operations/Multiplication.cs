using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class Multiplication : TwoNumbersOperation
    {
        public Multiplication(List<double> numbers) : base(numbers, "*") { }

        public Multiplication() : base(new List<double> { 0, 0 }, "*") { }
        public override double Calculate()
        {
            return Numbers[0] * Numbers[1];
        }
    }
}
