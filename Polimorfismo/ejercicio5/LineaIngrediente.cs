
class LineaIngrediente
{
    public LineaIngrediente(Ingrediente producto, int cantidad)
    {
        this.Producto = producto;
        this.Cantidad = cantidad;
    }
    public Ingrediente Producto{get; set;}
    public int Cantidad{
        get;
        private set;
    }

    public double SubTotal{
        get{
            return Producto.Precio * Cantidad;
        }
    }

    public override string ToString()
    {
        return " ";
    }

    public static implicit operator LineaIngrediente(Ingrediente v)
    {
        throw new NotImplementedException();
    }
}
