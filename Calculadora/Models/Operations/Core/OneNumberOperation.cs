namespace Calculadora.Models.Operations.Core
{
    public abstract class OneNumberOperation : Operation
    {
        public OneNumberOperation(List<double> numbers, string simbol) : base(numbers, simbol) { }
    }
}
