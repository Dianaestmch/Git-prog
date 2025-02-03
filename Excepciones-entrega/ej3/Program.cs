internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
    
            double numero = double.Parse(args[0]);
            double resultado = Logaritmo.CalculaLogoritmo(numero);
            Console.WriteLine(resultado);
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Has introducido un valor que no es de tipo double");
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Has introducido un valor nulo");
        }
        catch(ParametroNoValidoException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        
    }
}