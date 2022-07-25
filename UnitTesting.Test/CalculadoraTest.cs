using Xunit;

namespace UnitTesting.Tests
{
    using Calculadora;
    public class CalculadoraTest
    {
        [Fact]
        public void TestSoma()
        {
            //Arange
            int valor1 = 10;
            int valor2 = 10;
            int expect = 20;
            int result;

            //Act
            result = Calculadora.Soma(valor1, valor2);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void TestDivisaoComZeroDivisor()
        {
            //Arange
            int dividento = 10;
            int divisor = 0;
            int expect = 0;
            int result;

            //Act
            result = Calculadora.Divisao(dividento, divisor);

            //Assert
            Assert.Equal(expect, result);
        }
    }
}