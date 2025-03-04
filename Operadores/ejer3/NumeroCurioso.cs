using System.ComponentModel;

class NumeroCurioso
{
    private double a;
    private double b;
    private double c;


    public NumeroCurioso(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    private static double SumaCudrados(double a, double b, double c) => Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);

    public bool ComprobarQueNoSeaCero()
    {
        bool comprobacion = true;
        double respuesta = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
        if (respuesta == 0 || a == 0 || b == 0 || c == 0)
        {
            throw new Exception("Error");
            comprobacion = false;
        }

        return comprobacion;
    }

    public double Salida()
    {

    }

    public override string ToString()
    {
        return $"El número a es {a}\n el número b es {b}\n el número c es {c}";
    }
}