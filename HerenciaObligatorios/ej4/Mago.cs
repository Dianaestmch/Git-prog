class Mago: Humano
{
    private string libroHechizos;
    private string tunica;

    public Mago(string libroHechizos, string tunica, string nombre, string sexo, string destreza, int edad, int peso, int inteligencia, int fuerza, int energia): base(nombre, sexo, destreza, edad, peso, inteligencia, fuerza, energia){
        this.libroHechizos = libroHechizos;
        this.tunica = tunica;
    }

    public string GetLibroHechizos()
    {
        return libroHechizos;
    }
    public void SetLibroHechizos(string libroHechizos)
    {
        this.libroHechizos = libroHechizos;
    }

    public string GetTunica()
    {
        return tunica;
    }

    public void SetTunica(string tunica)
    {
        this.tunica = tunica;
    }
    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() + $"Tiene el libro de {libroHechizos} y su túnica es {tunica}";
    }
}