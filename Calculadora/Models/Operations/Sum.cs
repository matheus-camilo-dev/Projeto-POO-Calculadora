using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class Sum : TwoNumbersOperation
    {
        public Sum(List<double> numbers) : base(numbers, "+") { }

        public Sum() : base(new List<double> { 0, 0 }, "+") { }

        public override double Calculate()
        {
            return Numbers[0] + Numbers[1];
        }
    }
}
