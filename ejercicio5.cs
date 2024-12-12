using System.Runtime.InteropServices;

internal class Program
{
    public static void MostrarJardin(int[][] jardin)
    {
        
        Console.WriteLine("Jardín: ");
        foreach (int[] item in jardin)
        {
            
            Console.WriteLine(string.Join(" ", item));
        }
    }

    public static void ContarFlores(int[][] jardin)
    {
        int [] colores = new int[5];
        for (int i = 0; i < 5; i++)
        {
            colores[i] = 0;
        }

        

        for (int i = 0; i <jardin.Length; i++)
        {
            for (int j = 0; j < jardin[i].Length; j++)
            {
                colores[jardin[i][j]]++;
                /*
        int color1 = 0;
        int color2 = 0;
        int color3 = 0;
        int color4 = 0;

                switch (jardin[i][j])
                {
                    case 1: color1++;
                    break;
                    case 2: color2++;
                    break;
                    case 3: color3++;
                    break;
                    case 4: color4++;
                    break;
                    */
                }
            }
        }
        
        Console.WriteLine("Flores por colores: ");
        Console.WriteLine($"Color 1: {color1} flores");
        Console.WriteLine($"Color 2: {color2} flores");
        Console.WriteLine($"Color 3: {color3} flores");
        Console.WriteLine($"Color 4: {color4} flores");
        
    }

    public static void ArriateMasDiverso(int[][] jardin)
    {
        int [] aux = jardin[0];
        int masDiverso = 0;
        int indiceDiverso = 0;
        //int masDiverso = numerosDistintos(aux);

        for (int i = 0; i < jardin.Length; i++)
        {
            int diversidadActual = jardin[i].Distinct().Count();

            if (diversidadActual > masDiverso)
            {
                masDiverso = diversidadActual;
                indiceDiverso = i;
            }
            
        }
        Console.WriteLine($"El arriate más diverso: Arriate {indiceDiverso +1} con {masDiverso} colores distintos");
    }
    private static void Main(string[] args)
    {
        int[][] jardin = new int [][]
        {
            new int [] {2, 3, 4, 1},
            new int [] {4, 4, 2},
            new int [] {2, 1, 1, 3, 1},
            new int [] {3, 2}
        };
        
        MostrarJardin(jardin);
        ContarFlores(jardin);
        ArriateMasDiverso(jardin);
    }
}