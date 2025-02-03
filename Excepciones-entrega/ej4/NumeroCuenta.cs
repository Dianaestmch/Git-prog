using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

class NumeroCuenta
{


    private string entidad;
    private string sucursal;
    private string dcEntSuc;
    private string dcNumero;
    private string cuenta;

    public NumeroCuenta(in string numero)
    {
        entidad = sucursal = dcEntSuc = dcNumero = cuenta = "";
        // se pueden iniciar los atributos a "" conjunto vacio al igual que los int a 0        
        if(!FormatoCorrecto(numero))
        {
            throw new NumeroCuentaIncorrectoException("INCORRECTO");
        }
        if(!dcCorrecto(dcEntSuc, entidad+sucursal, [4, 8, 5, 10, 9, 7, 3, 6]))
        {
            throw new NumeroCuentaIncorrectoException("Error: entidad sucursal");
        }
        if (!dcCorrecto(dcNumero, cuenta, [4, 8, 5, 10, 9, 7, 3, 6]))
        {
            throw new NumeroCuentaIncorrectoException("Error: número de cuenta");
        }
        
    }

    public bool FormatoCorrecto(in string numero)
    {
        bool resultado = false;
        Regex patron = new Regex (@"^(?<entidad>\d{4})[ ]?(?<sucursal>\d{4})[ ]?(?<dcEntSuc>\d{1})(?<dcNumero>\d{1})[ ]?(?<cuenta>\d{10})");
        Match verificar = patron.Match(numero);

        if (verificar.Success)
        {
            entidad = verificar.Groups["entidad"].Value;
            sucursal = verificar.Groups["sucursal"].Value;
            dcEntSuc = verificar.Groups["dcEntSuc"].Value;
            dcNumero = verificar.Groups["dcNumero"].Value;
            cuenta = verificar.Groups["cuenta"].Value;
            resultado = true;
        }
        

        return resultado;
 
    }
    private bool dcCorrecto(in string dc, in string digitos, int[] ponderaciones)
    {
        bool resultado = false;
        int valor = 0;


        for (int i = 0; i < digitos.Length; i++)
        {
            valor += ponderaciones[i]*int.Parse(digitos[i].ToString());
        }
        valor = 11 -(valor%11);

        if (valor == 10)
        {
            valor = 1;
        }
        if (valor == 11)
        {
            valor = 0;
        }

        if (valor.ToString() == dc)
        {
            resultado = true;
        }

        return resultado;
    }

    public override string ToString()
    {
        return "pepe";
    }
    
}