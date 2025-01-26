using System;

public class TablaImpares : TablaEnteros
{
    private Random random = new Random();

    public TablaImpares(int tamaño) : base(tamaño){}

    public override void GuardarNumerosEnTabla(int[] numeros)
    {
        int index = 0;
        while (index < tabla.Length)
        {
            int num = random.Next(0, 101);
            if (num % 2 != 0)
            {
                tabla[index] = num;
                index++;
            }
        }
    }

    public override string DevuelveTabla()
    {
        return $"Números Impares: {base.DevuelveTabla()}";
    }
}
