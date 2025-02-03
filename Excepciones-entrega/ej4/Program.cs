internal class Program
{
    private static void Main(string[] args)
    {    
        Cuenta cuenta1 = new Cuenta("2085 0103 92 0300731702", "Pepe");
        

        Console.WriteLine(cuenta1.ToString());
        //"2085 0103 92 0300731702"
    }
}