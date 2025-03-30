internal class Program
{
    public delegate void Infinitivo();
    public static void Ser()
    {
        Console.WriteLine("BE");
    }

    public static void Correr()
    {
        Console.WriteLine("RUN");
    }

    public static void Ver()
    {
        Console.WriteLine("SEE");
    }

    public static void Pensar()
    {
        Console.WriteLine("Think");
    }

    public static void Comer()
    {
        Console.WriteLine("Eat");
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Infinitivo verbos = null;
        //verbos.Invoke();
        verbos+= Ser;
        verbos+= Correr;
        verbos+= Ver;
        
        Console.WriteLine("Métodos añadidos");
        verbos.Invoke();

        verbos -= Ser;
        verbos -= Ver;
        verbos += Pensar;
        verbos += Comer;

        Console.WriteLine("Métodos eliminados");
        verbos.Invoke();
        
        //Console.WriteLine(verbos.ToString());
    }
}