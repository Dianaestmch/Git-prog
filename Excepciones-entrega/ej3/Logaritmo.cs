using Microsoft.Win32.SafeHandles;

class Logaritmo
{
    double numero;
    //donet run 8, esto está en args[0]

    public Logaritmo(double numero)
    {
        this.numero = numero;
    }


    public static double CalculaLogoritmo(double numero)
    {
        if (numero <= 0)
        {
            throw new ParametroNoValidoException();
        }
        
        return Math.Log10(numero);
    }
    
}