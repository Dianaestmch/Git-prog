using System.Security.Cryptography.X509Certificates;

class CuentaCorriente: Cuenta
{
    private int maximoTransaccionessGratuitasPorMes;
    private double recargoXTransaccionAdicional_Euros;
    private int numeroTransaccionesMesActual;

    public CuentaCorriente(in string numero, in string titular,in int maximoTransaccionessGratuitasPorMes, in double recargoXTransaccionAdicional_Euros, in int numeroTransaccionesMesActual): base(numero, titular)
    {
        this.maximoTransaccionessGratuitasPorMes = maximoTransaccionessGratuitasPorMes;
        this.recargoXTransaccionAdicional_Euros = recargoXTransaccionAdicional_Euros;
        this.numeroTransaccionesMesActual = numeroTransaccionesMesActual;
    }

    private void reiniciaTransacciones()
    {

    }

    public override void Ingreso(double cantidad)
    {
        saldo = saldo + cantidad;
    }

    public override double Reintegro(double cantidad)
    {
        return 25;
    }

    public void AplicaRecargoMes()
    {
        
    }

    public override string ToString()
    {
        return $"Retirnando {Reintegro} en C";
    }

}
