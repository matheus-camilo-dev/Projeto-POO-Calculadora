using Calculadora.Models.Operations.Core;

namespace Calculadora.Models.Historic
{
    public class HistoricOperation
    {
        public string Simbol { get; set; }
        public List<double> Numbers { get; set; }

        public double Result { get; set; }

        public HistoricOperation(Operation operation, double result)
        {
            Simbol = operation.Simbol;
            Numbers = operation.Numbers;
            Result = result;
        }
    }
}
