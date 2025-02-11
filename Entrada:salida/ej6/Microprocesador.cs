class Microprocesador
{
    private string modelo;
    private double nucleos;
    private double frecuencia;

    public Microprocesador(string modelo, double nucleos, double frecuencia)
    {
        this.modelo = modelo;
        this.nucleos = nucleos;
        this.frecuencia = frecuencia;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public void SetModelo(string modelo)
    {
        this.modelo=modelo;
    }
    public double GetNucleos()
    {
        return nucleos;
    }

    public void SetNucleos(double nucleos)
    {
        this.nucleos = nucleos;
    }
    public double GetFrecuencia()
    {
        return frecuencia;
    }

    public string ACSV()
    {
        //string espacio = ",";

        return $"{modelo},{nucleos},{frecuencia}";
    }

    public static Microprocesador AMicroprocesador(string cadenaACSV)
    {
        string[] datos = cadenaACSV.Split(";");
        return new Microprocesador(datos[0], double.Parse(datos[1]), double.Parse(datos[2]));
    }

    public override string ToString()
    {
        return $"Modelo: {modelo} \nNucleos: {nucleos} \nFrecuencia: {frecuencia}";
    }

    //EndOfStream devuelve T/F dependiendo de si ha terminado de leer devuelve T en caso contrario F

}