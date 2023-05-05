using Calculadora.Models.Historic;
using Calculadora.Models.Operations.Core;

namespace Calculadora.Interfaces.IO
{
    public interface IProgramOutput
    {
        void ShowHistoryOperations(List<HistoricOperation> historyOperations);

        void ShowMenuOptions();

        void ShowMessage(string message);

        void ShowBanner();

        void ShowOperationResult(List<double> numbers, string simbol, double result);
    }
}
