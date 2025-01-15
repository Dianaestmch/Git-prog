internal class Program
{
    private static void Main(string[] args)
    {
        Empresa a = new Empresa("cif", "razonsociall123", "Calle el Pozo, 34 Bajo", " pepe", 2025);
        Console.WriteLine(a.DatosEmpresa());


        Empleado empleado1 = new Empleado("23453456", "Maria Soto", 1940);
        empleado1.SetCategoria(Categoria.Gerente);
        Empleado empleado2 = new Empleado("14568712", "Juanma Perez", 1941);
        empleado2.SetCategoria(Categoria.Administrativo);
        Empleado empleado3 = new Empleado("12346123", "Pedro Martinez", 1942);
        empleado3.SetCategoria(Categoria.JefeDepartamento);

        Console.WriteLine(empleado1.ACadena());
        Console.WriteLine(empleado2.ACadena());
        Console.WriteLine(empleado3.ACadena());

    }
}