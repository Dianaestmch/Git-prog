public abstract class TablaEnteros
{
    protected int[] tabla;
    public TablaEnteros(int tamaño)
    {
        tabla = new int[tamaño];
    }

    public abstract void GuardarNumerosEnTabla(int[] numeros);

    public virtual string DevuelveTabla()
    {
        return string.Join(", ", tabla);
    }

    public int SumaPropia()
    {
        int positivos = 0, negativos = 0, sumaPositivos = 0, sumaNegativos = 0;

        foreach (int numero in tabla)
        {
            if (numero > 0)
            {
                positivos++;
                sumaPositivos += numero;
            }
            else if (numero < 0)
            {
                negativos++;
                sumaNegativos += numero;
            }
        }

        return positivos >= negativos ? sumaPositivos : sumaNegativos;
    }

    public void MostrarTabla()
    {
        foreach (int numero in tabla)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }


}