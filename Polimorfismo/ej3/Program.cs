internal class Program
{
    private static void Main(string[] args)
    {
            try
            {
                Cuenta cuenta = new Cuenta("2085 0103 92 0300731702", "Vladimir Putin");
                cuenta.Ingreso(15400);
                Console.WriteLine(cuenta);
                do
                {
                    try
                    {
                        Console.Write("¿Cuanto quieres sacar?: ");
                        double reintegro = double.Parse(Console.ReadLine());
                        cuenta.Reintegro(reintegro);
                    }
                    catch (SaldoInsuficienteException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (cuenta.GetSaldo() > 0);
            }
            catch (NumeroCuentaIncorrectoException e)
            {
                Console.WriteLine(e.Message);
            }
        
    }
}