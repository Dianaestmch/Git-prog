internal class Program
{
    private static void Main(string[] args)
    {
        TablaPares tablaPares = new TablaPares(5);
        tablaPares.GuardarNumerosEnTabla(null);
        Console.WriteLine(tablaPares.DevuelveTabla());
        Console.WriteLine($"Suma de la tabla pares: {tablaPares.SumaPropia()}");

        TablaImpares tablaImpares = new TablaImpares(5);
        tablaImpares.GuardarNumerosEnTabla(null);
        Console.WriteLine(tablaImpares.DevuelveTabla());
        Console.WriteLine($"Suma de la tabla impares: {tablaImpares.SumaPropia()}");


    }
}