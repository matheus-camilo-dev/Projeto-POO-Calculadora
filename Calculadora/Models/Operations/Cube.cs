using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class Cube : OneNumberOperation
    {
        public Cube(List<double> numbers) : base(numbers, "^3") { }

        public Cube() : base(new List<double> { 0, 0 }, "^3") { }

        public override double Calculate()
        {
            return Math.Pow(Numbers[0], 3); ;
        }
    }
}
