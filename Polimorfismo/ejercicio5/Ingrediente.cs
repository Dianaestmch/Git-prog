class Ingrediente
{
    private string nombre;
    private double precio;

    public Ingrediente(string nombre, double precio, int stock)
    {
        this.nombre = nombre;
        this.precio = precio;
        Stock = stock;
    }

    public string Nombre
    {
        get{return nombre;}
        set{if (value == " ")
            {
                throw new IngredienteException("El nombre no puede ser NULL");
            }
            nombre = value;
        }
    }

    public double Precio
    {
        get{return precio;}
        set{if (value < 1)
            {
                throw new IngredienteException("Precio inferior a 0 no válido");
            }
            precio = value;
        }
    }

    public int Stock{get; set;}

    public bool EnStock{

        get
        {
            bool comprobar = false;
            if (Stock > 0)
            {
                comprobar = true;
            }
            return comprobar;
        }

        
    }

    public  override string  ToString()
    {
        return $"Producto: {Nombre} \nPrecio: {Precio} \nStock: {Stock} unidades \nDisponible " + (EnStock? "si": "no");
        //{EnStock = true "si" ?? "no"}
    }


}