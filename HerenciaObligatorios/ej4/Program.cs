internal class Program
{
    private static void Main(string[] args)
    {
        string tipoArma;
        string tipoArmadura;
        string libroHechizos;
        Guerrero guer1 = new Guerrero("alicate", "nose", "Pablo", "masculino", "fuego", 23, 70, 120, 70, 20);
        Humano humano1 = new Humano("alicate", "nose", "Pablo", 23, 70, 120, 70, 20);
        
        Mago mago1 = new Mago("libro", "pepe", "Juan", "hombre", "saltar", 25, 90, 100, 20, 120);

        do
        {
            Console.WriteLine("¿Qué tipo de arma deseas usar? Estas son tus opciones: ");

            string [] mostrarArma = Enum.GetNames(typeof(TipoArma));
            foreach (string item in mostrarArma)
            {
                Console.WriteLine($"{item}");
            }
            tipoArma = (Console.ReadLine() ?? string.Empty);
            
        } while (!Enum.IsDefined(typeof(TipoArma), tipoArma));
        guer1.SetTipoArma(tipoArma);

        do
        {
            Console.WriteLine("¿De qué tipo de armadura deseas usar? Estas son tus opciones: ");

            string [] mostrarArmadura = Enum.GetNames(typeof(TipoArmadura));
            foreach (string item in mostrarArmadura)
            {
                Console.WriteLine($"{item}");
            }
            tipoArmadura = (Console.ReadLine() ?? string.Empty);
            
        } while (!Enum.IsDefined(typeof(TipoArmadura), tipoArmadura));
        guer1.SetTipoArmadura(tipoArmadura);

        do
        {
            Console.WriteLine("¿De qué tipo de libro de hechizos deseas usar? Estas son tus opciones: ");

            string [] mostrarLibro = Enum.GetNames(typeof(TipoLibroHechizos));
            foreach (string item in mostrarLibro)
            {
                Console.WriteLine($"{item}");
            }
            libroHechizos = (Console.ReadLine() ?? string.Empty);
            
        } while (!Enum.IsDefined(typeof(TipoLibroHechizos), libroHechizos));
        mago1.SetLibroHechizos(libroHechizos);
    
        Console.WriteLine(mago1.MostrarInformacion());
        //Console.WriteLine(guer1);
    }
}