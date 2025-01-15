using System.Security.Cryptography.X509Certificates;

class Empresa{
    private readonly string  cif;
    private readonly string razonSocial;
    private string direccion;

    public Empresa (in string cif, in string razonSocial, in string dni, in string nombre, in int anyNacimiento){
        this.cif = cif;
        this.razonSocial = razonSocial;
        this.direccion = direccion;
    }

    public Empresa(Empresa e)
    {
        cif = e.cif;
        razonSocial = e.razonSocial;
        direccion = e.direccion;
    }

    public void NombreGerente()
    {

    }

    public string GetRazonSocial()
    {
        return razonSocial;
    }

    public string GetDireccion()
    {
        return direccion;
    }

    public string GetCif()
    {
        return cif;
    }

    public void SetDireccion (in string direccion)
    {
        this.direccion = direccion;
    }

/*
    public Empleado[] GetEmpleados()
    {

    }
*/
    public void MasGerente(in string dni, in string nombre,in int anyNacimiento)
    {
        string nombreGerente = "María Soto";
    }

    public string DatosEmpresa()
    {
        string nombreEmpresa = "La Empresa S.L";

        return nombreEmpresa;
    }

    public void Contrata(in string dni, in string nombre, in int anyNacimiento, in string categoria)
    {

    }

    public void Acadena()
    {

    }
}