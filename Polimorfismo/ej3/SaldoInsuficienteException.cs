
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensaje) : base(mensaje)
        {
            ;
        }
    }


    class ParametroNoValidoException : Exception
    {
        public ParametroNoValidoException()
        {
            ;
        }

        public ParametroNoValidoException(string message) : base(message)
        {
            ;
        }
    }

    class Ej03_ParametroNoValidoException
    {
        static double LogaritmoBase10(double n)
        {
            if (n <= 0)
                throw new ParametroNoValidoException($"No se puede calcular el logaritmos de un número menor o iguala cero.");

            return Math.Log10(n);
        }

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {
                    double valor = double.Parse(args[0]);
                    Console.WriteLine($"\nEl logaritmo de {valor} en base 10 es: {LogaritmoBase10(valor)}");
                }
                else
                    Console.WriteLine($"\aERROR: El programa solo admite un argumento.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"\aERROR: Parámetro introducido {args[0]} inválido.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\aERROR: {e.Message}");
            }
        }
    }
