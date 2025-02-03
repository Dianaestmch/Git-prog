class ParametroNoValidoException: Exception
{
    public ParametroNoValidoException(): base("Error: El valor debe ser mayor que 0."){}

    public ParametroNoValidoException(string message): base(message)
    {
    }

}