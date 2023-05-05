using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Operations
{
    public class Division : TwoNumbersOperation
    {
        public Division(List<double> numbers) : base(numbers, "/") { }
        public Division() : base(new List<double> { 0, 0 }, "/") { }

        public override double Calculate()
        {
            return Numbers[0] / Numbers[1];
        }
    }
}
