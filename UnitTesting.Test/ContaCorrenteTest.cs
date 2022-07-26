using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTesting.Test
{
    public class ContaCorrenteTest
    {
        [Fact]
        public void testSaqueComSaldoInsulficiente()
        {
            //Arrage
            ContaCorrente contaCorrente = new ContaCorrente();
            double valorSaque = 10;
            double actual;
            double expect = 0;

            //act
            actual = contaCorrente.Saque(valorSaque);

            //Assert
            Assert.Equal(expect, actual, 0);
        }

        [Fact]
        public void testSaqueComSaldoMaior()
        {
            //arrange
            ContaCorrente contaCorrente = new ContaCorrente();
            double valorSaque = 9;
            double actual;
            double esperado = 1;
            //act
            contaCorrente.Depositar(10);
            actual = contaCorrente.Saque(valorSaque);

            //Assert
            Assert.Equal(esperado, actual, 0);
        }

    }
}
