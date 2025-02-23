class CuentaDeposito: CuentaAhorro
{
    private double recargo_tpu;
    public bool vencimiento;

    public CuentaDeposito(string numero, string titular, double interes_tpu, double recargo_tpu, bool vencimiento): base(numero, titular, interes_tpu)
    {
        this.recargo_tpu = 0.05;
        this.vencimiento = true;
    }
    public override double Reintegro(double cantidad)
    {
        if(saldo > cantidad)
        {
            if(!vencimiento)
            {
                cantidad = cantidad - (cantidad * recargo_tpu);
            }
            else
            {
                cantidad = saldo - cantidad;
            }
        }
        else
            throw new SaldoInsuficienteException($"Saldo en cuenta insuficiente para reintegro de {cantidad:C}.");
        
        return cantidad;
    }

    public override string ToString()
    {
        return $"en Cuenta Ahorro /n Numero de cuenta: {GetNumero} /n Titular: {GetTitular} /n Saldo: {saldo}.";
        

    }
}
