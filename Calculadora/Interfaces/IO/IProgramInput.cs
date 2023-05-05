using Calculadora.Models.Operations.Core;

namespace Calculadora.Interfaces.IO
{
    public interface IProgramInput
    {
        int? GetOptionNumber();

        List<double> GetNumbers(Operation operation);
    }
}
