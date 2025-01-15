class Empleado
{   
    private readonly string dni;
    private readonly string nombre;
    private readonly int anyNacimiento;
    public Categoria categoria;
    
  
    public Empleado(in string dni, in string nombre, in int anyNacimiento )
    {
        this.dni = dni;
        this.nombre = nombre;
        this.anyNacimiento = anyNacimiento;
    }

    public Empleado(Empleado p)
    {
        dni = p.dni;
        nombre = p.nombre;
        anyNacimiento = p.anyNacimiento;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public int GetAñoNacimiento()
    {
        return anyNacimiento;
    }

    public string GetDni()
    {
        return dni;
    }

    public void SetCategoria(in Categoria categoria)
    {
        this.categoria = categoria;
    }

    public double Salario()
    {
        const double salarioBase = 1200;
        double salarioTotal = 0;
        double incremento = (int)categoria / 100.0;
        
        //Categoria [] categorias =(Categoria[])Enum.GetValues(typeof(Categoria));

/*
        foreach (Categoria cat in categorias)
        {
            if (Enum.IsDefined(typeof(Categoria), categoria))
            {
                    
                incremento = (int)cat /100;
                Console.WriteLine(incremento);
            }
        }
*/
        
        return salarioTotal = (salarioBase * incremento) + salarioBase;
    }

    public string ACadena()
    {
        return $"El emplado {nombre} con DNI {dni} tiene un salario de {Salario()} y su categoria es {categoria}";
    }
}