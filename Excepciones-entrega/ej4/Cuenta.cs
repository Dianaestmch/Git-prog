using System.Data;

class Cuenta
{
    private NumeroCuenta numero1;
    private string titular;
    private double saldo;

/*
    public Cuenta(string titular, double saldo){
        this.titular = titular;
        this.saldo = 3;
        
    }
*/
    public Cuenta(in string numero, in string titular)
    {
        this.numero1 = new NumeroCuenta(numero);
        this.titular = titular;
        this.saldo = 3;
    }

    public void Ingreso(in double cantidad)
    {
        saldo += cantidad;
    }
    public void Reintegro(in double cantidad)
    {
        if (saldo < cantidad)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente");
        }
        saldo -= cantidad;
    }

    public override string ToString()
    {
        return "pepe";
    }
}