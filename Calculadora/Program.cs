using Calculadora.IO;

var programOutput = new ProgramOutput();
var calculator = new Calculator(programOutput, new ProgramInput(programOutput));
calculator.Run();