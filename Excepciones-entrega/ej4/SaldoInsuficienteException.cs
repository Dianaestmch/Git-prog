[System.Serializable]
public class SaldoInsuficienteException: System.Exception
{
    public SaldoInsuficienteException() { }
    public SaldoInsuficienteException(string message) : base(message) { }
    public SaldoInsuficienteException(string message, System.Exception inner) : base(message, inner) { }

}