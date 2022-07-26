namespace UnitTesting.contaCorrente
{
    public class ContaCorrente : IContaCorrente
    {
        public double Saldo { get; set; }

        public void ZeraSaldo()
        {
            this.Saldo = 0;
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }
    }
}
