internal class Program
{
    private static void Main(string[] args)
    {
        string datos = "Intel Core I8;4;3.6";
    /*
        Microprocesador m1 = new Microprocesador("Intelcore i7", 4, 3.6);
        Console.WriteLine(m1.ToString());

        Console.WriteLine(m1.ACSV());
    */
        Microprocesador nuevoMicro = Microprocesador.AMicroprocesador(datos);
        Console.WriteLine(nuevoMicro.ToString());
        
    }
}