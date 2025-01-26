class Guerrero: Humano
{
    private string tipoArma;
    private string tipoArmadura;

    public TipoArma opcionesArma;

    public Guerrero(string tipoArma, string tipoArmadura, string nombre, string sexo, string destreza, int edad, int peso, int inteligencia, int fuerza, int energía): base(nombre, sexo, destreza, edad, peso, inteligencia, fuerza, energía)
    {
        this.tipoArma = tipoArma;
        this.tipoArmadura = tipoArmadura;
    }

    public string GetTipoArma()
    {
        
        return tipoArma;
    }

    public void SetTipoArma(string tipoArma)
    {
        this.tipoArma = tipoArma;
    }

    public string GetTipoArmadura()
    {
        return tipoArmadura;
    }

    public void SetTipoArmadura(string tipoArmadura)
    {
        this.tipoArmadura = tipoArmadura;
    }

    public override string MostrarInformacion()
    {
        return base.MostrarInformacion() +$"El arma elegida es un {tipoArma} y la armadura es de tipo {tipoArmadura}";
    }


}