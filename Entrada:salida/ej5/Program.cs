using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string rutaDirectorio = @"C:\datos";
        string rutaArchivo = Path.Combine(rutaDirectorio, "ejemplo.txt");
         string valor = "";
         
        if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            
            //fichero.Close();
            }
        //streamreader y streamwriter
        do
        {
            Console.WriteLine("¿Qué quieres guardar en este archivo .txt?");
            valor = Console.ReadLine()?? "0";
            
            if (!File.Exists(rutaArchivo))
            {
                using(FileStream fichero = new FileStream(rutaArchivo,FileMode.Create))
                {
                    BinaryWriter bw = new BinaryWriter(fichero, Encoding.UTF8);
                    bw.Write(valor);
                }
            }

            Console.WriteLine("Texto guardado correctamente.");
            Console.WriteLine("Presiona ESC para salir o cualquier otra tecla para seguir escribiendo...");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        
        Console.WriteLine("\nSaliendo del programa...");

    }
}