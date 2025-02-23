class Cuenta
    {
        private NumeroCuenta numero;
        private string titular;
        public double saldo {get; protected set;}
        private string nombreUsuario;

    
        public double GetSaldo()
        {
            return saldo;
        }
    
        public string GetTitular()
        {
            return titular;
        }
        public NumeroCuenta GetNumero()
        {
            return numero;
        }

        public Cuenta(string numero, string titular)
        {
            this.numero = new NumeroCuenta(numero);
            this.titular = titular;
            saldo = 0;
        }

        public virtual void Ingreso(double cantidad)
        {
            saldo = saldo + cantidad;
        }

        public virtual double Reintegro(double cantidad)
        {
            if (saldo - cantidad > 0)
                saldo = saldo - cantidad;
            else
                throw new SaldoInsuficienteException($"Saldo en cuenta {numero} {saldo:C} insuficiente para reintegro de {cantidad:C}.");
        
            return cantidad;
        }


        public override string ToString()
        {
            
            return $"Retirnando  en C";
        }
    }