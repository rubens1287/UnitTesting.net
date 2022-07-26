using Moq;
using UnitTesting.contaCorrente;
using Xunit;

namespace UnitTesting.Test
{
    public class ContaCorrenteTest
    {
        [Fact]
        public void ValidaDepositoIgualUm()
        {
            //Arrange
            int deposito = 1;
            int expect = 1;
            var contaCorrente = new ContaCorrenteConsumer(new ContaCorrente());

            //Act
            var actual = contaCorrente.Deposita(deposito);

            //Assert
            Assert.Equal(expect, actual);

        }

        [Fact]
        public void ValidaDepositoMaiorQueDez()
        {
            //Arrange
            int deposito = 11;
            int expect = 0;
            var contaCorrente = new ContaCorrenteConsumer(new ContaCorrente());

            //Act
            var actual = contaCorrente.Deposita(deposito);

            //Assert
            Assert.Equal(expect, actual);

        }

        [Fact]
        public void ValidaDepositoIgualDez()
        {
            //Arrange
            int deposito = 10;
            int expect = 10;
            var contaCorrente = new ContaCorrenteConsumer(new ContaCorrente());

            //Act
            var actual = contaCorrente.Deposita(deposito);

            //Assert
            Assert.Equal(expect, actual);

        }

        [Fact]
        public void ValidaSaqueSemSaldo()
        {
            //Arrange
            int saque = 8;
            int expect = 0;
            var contaCorrente = new ContaCorrenteConsumer(new ContaCorrente());

            //Act
            var actual = contaCorrente.Saque(saque);

            //Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void ValidaSaqueComSaldo()
        {
            //Arrange
            int deposito = 10;
            int saque = 8;
            int expect = 2;
            var contaCorrente = new ContaCorrenteConsumer(new ContaCorrente());

            //Act
            contaCorrente.Deposita(deposito);
            var actual = contaCorrente.Saque(saque);

            //Assert
            Assert.Equal(expect, actual);
        }


        [Fact]
        public void ValidaSaqueComSaldoComMock()
        {
            //Arrange
            int saldo = 10;
            int saque = 8;
            int expect = 2;
            var mock = new Mock<IContaCorrente>();
            var contaCorrenteConsumer = new ContaCorrenteConsumer(mock.Object);
            mock.SetupAllProperties();
            mock.Object.Saldo = saldo;

            //Act
            var actual = contaCorrenteConsumer.Saque(saque);

            //Assert
            Assert.Equal(expect, actual);
            mock.VerifyGet(m => m.Saldo,Times.Exactly(3));

        }

       

    }
}
