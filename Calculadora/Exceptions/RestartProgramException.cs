namespace Calculadora.Exceptions
{
    public class RestartProgramException : Exception 
    {
        public RestartProgramException(string message) : base(message) { }

        public RestartProgramException() : base("") { }
    }
}
