using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class SquareRoot : OneNumberOperation
    {
        public SquareRoot(List<double> numbers) : base(numbers, "sqrt") { }

        public SquareRoot() : base(new List<double> { 0, 0 }, "sqrt") { }

        public override double Calculate()
        {
            return Math.Pow(Numbers[0], 1.0 / 2.0);
        }
    }
}
