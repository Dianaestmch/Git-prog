class CuentaCredito: Cuenta
{
    private double interes_tpu;
    private double creditoMaximo_Euros;

    public CuentaCredito(string numero, string titular, double interes_tpu, double creditoMaximo_Euros): base(numero, titular)
    {
        this.interes_tpu = 0.2;
        this.creditoMaximo_Euros = creditoMaximo_Euros;
    }

    public override double Reintegro(double cantidad)
    {

        double cargo = (saldo < 0) ? Math.Abs(saldo) * interes_tpu : 0d;
        saldo = saldo - cargo;

        return cantidad;
    }

    public double CargaInteresesMes(){
        return 20;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}