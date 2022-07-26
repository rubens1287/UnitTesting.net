namespace UnitTesting
{
    public class ContaCorrente
    {
        private double Saldo;


        public ContaCorrente()
        {
            ZeraSaldo();
        }
       
        private void ZeraSaldo()
        {
            Saldo = 0;
        }

        public double Saque(double valor)
        {
            if (this.getSaldo() <= 0)
            {
                Console.WriteLine("Saldo insulficiente");
            } 
            else
            {
                setSaldo(getSaldo() - valor);
            }
            return getSaldo();
        }

        public double Depositar(double valor)
        {
            if (valor <= 10)
            {
                if (valor > 0)
                {
                    setSaldo(getSaldo() + valor);
                }
            }
            return getSaldo();
        }

        private void setSaldo(double value)
        {
            this.Saldo = value;
        }

        private double getSaldo()
        {
            return this.Saldo;
        }
    }
}
