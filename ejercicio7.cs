internal class Program
{
    public static void Menu()
    {
        Console.WriteLine("Menú: 1. Venta de entradas | 2. Estadísitica de aforo | Para salir pulse 'ESC'");
        //eleccion = Console.ReadKey();
    }

    public static void VentaEntradas(int entradas, int sala, int sesión)
    {
        Console.WriteLine("El número de entradas que se van a comprar: ");
        entradas = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("La sala: ");
        sala = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("La sesión a la que se quiere asistir: ");
        sesión = int.Parse(Console.ReadLine() ?? "0");
        /*
        int [,] entradasDisponibles= new int [3, 3]
        {
            {200, 200 , 200}, 
            {150, 150, 150},
            {125, 125, 125}
        };

        for (int i = 0; i < entradasDisponibles.GetLength(0); i++)
        {
            for (int j = 0; j < entradasDisponibles.GetLength(1); j--)
            {
                j =  j - entradas;
                Console.Write(string.Join(" " , entradasDisponibles[i, j]));
            }
            
        }
        */
        int [,] entradasDisponibles= new int [3, 3]
        {
            {200, 200 , 200}, 
            {150, 150, 150},
            {125, 125, 125}
        };


        for (int i = 0; i < entradasDisponibles.GetLength(0); i++)
        {
            for (int j = 0; j < entradasDisponibles.GetLength(1); j++)
            {
                entradasDisponibles[i, j] =  j - entradas;
                Console.Write(string.Join(" " , entradasDisponibles[i, j]));
            }
            
        }
    

    }

    private static void Main(string[] args)
    {
        ConsoleKeyInfo eleccion;
        string respuesta = "";
        int entradas = 0;
        int sala = 0;
        int sesión = 0;

        do
        {
            Menu();
            eleccion = Console.ReadKey(true);
            /*
            respuesta = eleccion.KeyChar switch
            {
                '1' => "Has seleccionado la venta de entradas" ,
                '2' => "Has seleccionado la estadísitca del aforo",
                _ => "Error en la selección"
            };
            */

            switch (eleccion.KeyChar)
            {
                case '1': VentaEntradas(entradas, sala, sesión);
                break;
            }
        
        } while (eleccion.Key != ConsoleKey.Escape);
        Console.WriteLine(respuesta);
    }
}