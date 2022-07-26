using Moq;
using UnitTesting.contaCorrente;
using Xunit;

namespace UnitTesting.Test
{
    public class ContaCorrenteTest
    {
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
        public void ValidaSaqueComSaldoMoQ()
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
