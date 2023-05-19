using Calculadora.Enums;
using Calculadora.Exceptions;
using Calculadora.Interfaces.IO;
using Calculadora.Models.Historic;
using Calculadora.Models.Operations;
using Calculadora.Models.Operations.Core;

public class Calculator
{
    private readonly IProgramOutput _programOutput;
    private readonly IProgramInput _programInput;
    private List<HistoricOperation> Historic { get; set; }

    public Calculator(IProgramOutput programOutput, IProgramInput programInput)
    {
        _programOutput = programOutput ?? throw new ArgumentNullException(nameof(programOutput));
        _programInput = programInput ?? throw new ArgumentNullException(nameof(programInput));
        Historic = new List<HistoricOperation>();
    }

    public void Run()
    {
        _programOutput.ShowBanner();
        double result = 0;
        while(true)
        {
            try
            {
                _programOutput.ShowMenuOptions();

                var optionNumber = _programInput.GetOptionNumber();
                ContinueProgram(optionNumber, out Operation operation);
                
                var numbers = _programInput.GetNumbers(operation, result, Historic.Any());
                operation.SetNumbers(numbers);
                result = operation.Calculate();

                _programOutput.BreakLine();
                _programOutput.ShowOperationResult(operation.Numbers, operation.Simbol, result);

                StoreOperationInHistoric(operation, result);
            }
            catch (RestartProgramException ex)
            {
                if (ex.Message != string.Empty)
                {
                    _programOutput.ShowMessage($"\n{ex.Message}\n");
                }
                continue;
            }
            catch (FinishProgramException ex)
            {
                if (ex.Message != string.Empty)
                {
                    _programOutput.ShowMessage($"\n{ex.Message}\n");
                }
                break;
            }
        }
    }

    private bool ContinueProgram(int? optionNumber, out Operation operation)
    {
        operation = null;
        if(optionNumber < 0 || optionNumber >= 10)
        {
            throw new RestartProgramException("Opção Inválida!");
        }

        if (optionNumber == (int)OptionNumber.Exit)
        {
            throw new FinishProgramException();
        }

        if (optionNumber == (int)OptionNumber.ShowHistory)
        {
            _programOutput.ShowHistoryOperations(Historic);
            throw new RestartProgramException();
        }

        operation = GetOperationInstance((OptionNumber) optionNumber);
        return true;
    }

    private Operation GetOperationInstance(OptionNumber optionNumber) 
    { 
        Operation operation = new Sum();
        switch (optionNumber) 
        {
            case OptionNumber.Subtraction:
                operation = new Subtraction();
                break;
            case OptionNumber.Multiplication:
                operation = new Multiplication();
                break;
            case OptionNumber.Division:
                operation = new Division();
                break;
            case OptionNumber.Square:
                operation = new Square();
                break;
            case OptionNumber.Cube:
                operation = new Cube();
                break;
            case OptionNumber.SquareRoot:
                operation = new SquareRoot();
                break;
            case OptionNumber.CubicRoot:
                operation = new CubicRoot();
                break;
        }
        return operation;
    }

    private void StoreOperationInHistoric(Operation operation, double result)
    {
        var history = new HistoricOperation(operation, result);
        Historic.Add(history);
    }
}




