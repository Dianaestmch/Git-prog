class Humano
{
    private string nombre, sexo, destreza;
    private int edad, peso, inteligencia, fuerza, energia;

    public Humano(string nombre, string sexo, string destreza, int edad, int peso, int inteligencia, int fuerza, int energia)
    {
        this.nombre = nombre;
        this.sexo = sexo;
        this.destreza = destreza;
        this.edad = edad;
        this.peso = peso;
        this.inteligencia = inteligencia;
        this.fuerza = fuerza;
        this.energia = energia;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetSexo()
    {
        return nombre;
    }

    public void SetSexo(string sexo)
    {
        this.sexo = sexo;
    }

    public string GetDestreza()
    {
        return destreza;
    }

    public void SetDestreza(string destreza)
    {
        this.destreza = destreza;
    }

    public int GetEdad()
    {
        return edad;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public int GetPeso()
    {
        return peso;
    }

    public void SetPeso(int peso)
    {
        this.peso = peso;
    }

    public int GetInteligencia()
    {
        return inteligencia;
    }

    public void SetInteligencia(int inteligencia)
    {
        this.inteligencia = inteligencia;
    }
    public int GetFuerza()
    {
        return fuerza;
    }

    public void SetFuerza(int fuerza)
    {
        this.fuerza = fuerza;
    }

    public int GetEnergia()
    {
        return energia;
    }

    public void SetEnergia(int energia)
    {
        this.energia = energia;
    }

    public virtual string MostrarInformacion()
    {
        return $"El guerrero {nombre}, su sexo es {sexo}, tiene {edad} años y pesa {peso} kg. Su energía se encuentra al {energia}%, su fuerza al {fuerza}%. Tiene un porcentaje de inteligencia del {inteligencia}% lo que hace que su destreza sea el {destreza}. ";
    }











}