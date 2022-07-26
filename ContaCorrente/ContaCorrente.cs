namespace UnitTesting.contaCorrente
{
    public class ContaCorrente : IContaCorrente
    {
        public double Saldo { get; set; }

        public void ZeraSaldo()
        {
            Saldo = 0;
        }
    }
}
