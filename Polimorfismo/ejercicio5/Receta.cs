class Receta
{
    public LineaIngrediente[] ingredientes = new LineaIngrediente[1];
    public string Nombre{get;}

    public Receta(){}
    public double CosteTotal{
        get{
            double total = 0;
            foreach (LineaIngrediente item in ingredientes)
            {
                total += item.SubTotal;
            }
            return total;
        }
    }

    public void AñadeIngrediente(Ingrediente producto, int cantidad){

        if(producto.EnStock)
        {
            producto.Stock -= cantidad;
            ingredientes.Append(new LineaIngrediente (producto, cantidad));
        }
        else
        throw new IngredienteException();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}