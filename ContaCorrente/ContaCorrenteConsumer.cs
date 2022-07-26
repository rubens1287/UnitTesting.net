namespace UnitTesting.contaCorrente
{
    public class ContaCorrenteConsumer
    {
        private readonly IContaCorrente _contaCorrente;


        public ContaCorrenteConsumer(IContaCorrente contaCorrente)
        {
            _contaCorrente = contaCorrente;
            _contaCorrente.ZeraSaldo();
        }

        public double Depositar(double valor)
        {
            if (valor <= 10)
            {
                if (valor > 0)
                {
                    _contaCorrente.Saldo = _contaCorrente.Saldo + valor;
                }
            }
            return _contaCorrente.Saldo;
        }

        public double Saque(double valor)
        {
            if (_contaCorrente.Saldo <= 0)
            {
                Console.WriteLine("Saldo insulficiente");
            }
            else
            {
                _contaCorrente.Saldo = _contaCorrente.Saldo - valor;
            }
            return _contaCorrente.Saldo;
        }

        public double ConsultaSaldo()
        {
            return _contaCorrente.Saldo;
        }

    }
}
