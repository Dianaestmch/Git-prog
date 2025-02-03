[System.Serializable]
public class NumeroCuentaIncorrectoException : System.Exception
{
    public NumeroCuentaIncorrectoException() { }
    public NumeroCuentaIncorrectoException(string message) : base(message) { }
    public NumeroCuentaIncorrectoException(string message, System.Exception inner) : base(message, inner) { }
    
}