internal class Program
{
    private static void Main(string[] args)
    {
        /*
        List <Automovil> coche1 = new List<Automovil>();

        List<Automovil> listaAutomoviles = new List<Automovil>
        {
            new Automovil("Toyota", "Corolla", 1, 2020, "rojo"),
            new Automovil("Ford", "Mustang", 5, 2022, "verde"),
            new Automovil("Honda", "Civic", 2, 2020, "amarillo")
        };
        */
        //Automovil.AutomovilesPorAnyoFabricacion(200);
        // List<Automovil> autosEncontrados = Automovil.AutomovilesPorAñoFabricacion(200);

        //List<Automovil> autosEncontrados = Automovil.AutomovilesPorAnyoFabricacion(2020);

        Automovil auto1 = new Automovil("Toyota", "Corolla", 1800, 2020, "Rojo");
        Automovil auto2 = new Automovil("Ford", "Mustang", 5000, 2022, "Azul");
        Automovil auto3 = new Automovil("Honda", "Civic", 2000, 2020, "Rojo");


        Automovil gestor = new Automovil("", "", 0, 0, "");
        gestor.AgregaAutmovil(auto1);
        gestor.AgregaAutmovil(auto2);
        gestor.AgregaAutmovil(auto3);

        Console.WriteLine("Automóviles en el sistema:");
        foreach (var auto in gestor.coches)
        {
            Console.WriteLine(auto.ToString());
        }

        Console.WriteLine("\nAutomóviles fabricados en 2020:");
        List<Automovil> autos2020 = gestor.AutomovilesPorAnyoFabricacion(2020);
        foreach (var auto in autos2020)
        {
            Console.WriteLine(auto.ToString());
        }

        Console.WriteLine("\nAutomóviles rojos de 2020:");
        List<Automovil> autosRojos2020 = gestor.AutomovilesPorAnyoFabricacionYColor("Rojo", 2020);
        foreach (var auto in autosRojos2020)
        {
            Console.WriteLine(auto.ToString());
        }


    }
}