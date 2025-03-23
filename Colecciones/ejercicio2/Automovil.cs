using Microsoft.VisualBasic;

class Automovil
{
    public string marca;
    
    public string modelo;
    public int cilindrada;
    public int anyoFabricacion;
    public string color;

    public List <Automovil> coches = new List<Automovil>();

    public Automovil(string marca, string modelo, int cilindrada, int anyoFabricacion, string color)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cilindrada = cilindrada;
        this.anyoFabricacion = anyoFabricacion;
        this.color = color;
    }

    public void AgregaAutmovil(Automovil automovil)
    {
        //List <Automovil> coche1 = new List<Automovil>();

        coches.Add(automovil);
    }

    public void EliminaAutomovil(int i)
    {
        coches.RemoveAt(i);
    }

    public List<Automovil> AutomovilesPorAnyoFabricacion(int fecha)
    {
        List <Automovil> nuevaLista = new List<Automovil>();

        foreach (var item in coches)
        {
            if (item.anyoFabricacion == fecha)
            {
                nuevaLista.Add(item);
            }
        }

        return nuevaLista;
    }

    public List<Automovil> AutomovilesPorAnyoFabricacionYColor(string colorA, int fecha)
    {
        List <Automovil> sublista = new List<Automovil>();

        foreach (var item in coches)
        {
            if (item.anyoFabricacion == fecha && item.color == colorA)
            {
                sublista.Add(item);
            }
        }

        return sublista;
    }

    public override string ToString() => $"{marca} {modelo} - {cilindrada}cc - Año: {anyoFabricacion} - Color: {color}";
}