using Calculadora.Models.Historic;

namespace Calculadora.Interfaces.IO
{
    public interface IProgramOutput
    {
        void ShowHistoryOperations(List<HistoricOperation> historyOperations);

        void ShowMenuOptions();

        void ShowMessage(string message);

        void ShowBanner();

        void ShowOperationResult(List<double> numbers, string simbol, double result);

        void BreakLine();
    }
}
