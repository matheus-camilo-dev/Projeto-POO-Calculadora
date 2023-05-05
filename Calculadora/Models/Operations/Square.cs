using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class Square : OneNumberOperation
    {
        public Square(List<double> numbers) : base(numbers, "^2") { }

        public Square() : base(new List<double> { 0, 0 }, "^2") { }
        public override double Calculate()
        {
            return Math.Pow(Numbers[0], 2);
        }
    }


}
