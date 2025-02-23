class CuentaAhorro: Cuenta
{
    private double interes_tpu;

    public CuentaAhorro(string numero, string titular, double interes_tpu): base(numero, titular)
    {
        this.interes_tpu = 0.02;
    }

    public void SumaInteres()
    {
        saldo = saldo + (saldo * interes_tpu);
    }

    public override string ToString()
    {
        return $"en Cuenta Ahorro /n Numero de cuenta: {GetNumero} /n Titular: {GetTitular} /n Saldo: {saldo}.";

    }
}