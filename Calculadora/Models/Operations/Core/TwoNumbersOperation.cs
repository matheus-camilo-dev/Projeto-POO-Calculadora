namespace Calculadora.Models.Operations.Core
{
    public abstract class TwoNumbersOperation : Operation
    {
        public TwoNumbersOperation(List<double> numbers, string simbol) : base(numbers, simbol) { }
    }

}
