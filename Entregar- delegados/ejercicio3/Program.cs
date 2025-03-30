internal class Program
{
    public static void Mostrar<T>(T[] matriz)
    {
        foreach (var item in matriz)
        {
            Console.Write(item + "\t");
        }
    }

    public delegate void MuestraDelegado<T>(T[] matriz);

    private static void Main(string[] args)
    {
       // Muestra<int> muestra = null;
        //Console.WriteLine("Hello, World!");
        int[] numeros = { 1, 2, 3, 4 };
        Mostrar(numeros);
        Console.WriteLine("");
        string[] palabras = {"SAL", "AGUA", "AZUCAR", "VINO" };
        Mostrar(palabras);

        Console.WriteLine("");

        Console.WriteLine("Ahora con delegate");
        MuestraDelegado <int> delegadoInt = Mostrar;
        MuestraDelegado <string> delegadoString = Mostrar;

        delegadoInt(numeros);
        delegadoString(palabras);

    }
}