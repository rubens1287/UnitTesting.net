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
            contaCorrente.Depositar(deposito);
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
            var moqContaCorrente = new Mock<IContaCorrente>();
            var contaCorrente = new ContaCorrenteConsumer(moqContaCorrente.Object);
            moqContaCorrente.Setup(x => x.Saldo).Returns(saldo);

            //Act
            var actual = contaCorrente.Saque(saque);

            var saldoAtu = contaCorrente.ConsultaSaldo();

            //Assert
            Assert.Equal(expect, actual);
            moqContaCorrente.VerifyGet(x => x.Saldo, Times.Exactly(2));

        }

      

    }
}
