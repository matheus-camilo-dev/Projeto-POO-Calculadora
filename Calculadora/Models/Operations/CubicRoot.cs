using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class CubicRoot : OneNumberOperation
    {
        public CubicRoot(List<double> numbers) : base(numbers, "cbrt") { }

        public CubicRoot() : base(new List<double> { 0, 0 }, "cbrt") { }

        public override double Calculate()
        {
            return Math.Pow(Numbers[0], 1.0 / 3.0);
        }
    }
}
