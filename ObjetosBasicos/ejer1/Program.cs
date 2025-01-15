internal class Program
{
    private static void Main(string[] args)
    {
        Empleado a = new Empleado("1234", "pepe", 15);

        a.SetCategoria(Categoria.JefeDepartamento);
        Console.WriteLine(a.ACadena());
    }
}