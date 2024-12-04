internal class Program
{
    private static void Main(string[] args)
    {
        int[][] m = new int[][]
        {
            new int [] {1,2,3,4},
            new int [] {5,6,7},
            new int [] {9,10,11,12,5},
            new int [] {9,10}
        };

        int [] mayor = m[0];

    // con for
    /*
        for (int i = 0; i < m.Length; i++)
        {
            
            if( m[i].Length > mayor.Length)
            {
                mayor = m[i];
            }

        }
        for (int j = 0; j < mayor.Length; j++)
            {
                Console.Write(string.Join(" ", mayor[j]));
            }
    */

        
        int [] aux = m[0];

        foreach (int[] cajas in m)
        {
            
            if (aux.Length < cajas.Length)
            {
                aux = cajas;
            }

            
        }
        
        foreach (int item in aux)
        {
            Console.Write(item);
        }

        /*

        git config --global http.proxy 10.100.0.1:8080 (sólo en clase)
        git clone https://github.com/Dianaestmch/Programacion---Diana-Morocho.git dentro de una carpeta que hagamos solo para git :)
        añadirlo con git add . / git add "nombre fichero"
        confirmación con git commit -m "trabajo del día"
        y subirlo git push
        

        git config --global user.name
        git config --global user.mail

        */
        

    }
}