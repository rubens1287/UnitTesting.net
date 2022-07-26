using Xunit;

namespace UnitTesting.Tests
{
    using Calculadora;
    public class CalculadoraTest
    {
        [Fact]
        public void ValidaSoma()
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
        public void ValidaMultiplicacao()
        {
            //Arange
            int valor1 = 2;
            int valor2 = 2;
            int expect = 4;
            int result;

            //Act
            result = Calculadora.Multiplicao(valor1, valor2);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void ValidaSubtracao()
        {
            //Arange
            int valor1 = 10;
            int valor2 = 2;
            int expect = 8;
            int result;

            //Act
            result = Calculadora.Subtracao(valor1, valor2);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void ValidaDivisaoComZeroDivisor()
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

        [Fact]
        public void ValidaDivisaoComDivisorMaiorQueZero()
        {
            //Arange
            int dividento = 10;
            int divisor = 2;
            int expect = 5;
            int result;

            //Act
            result = Calculadora.Divisao(dividento, divisor);

            //Assert
            Assert.Equal(expect, result);
        }


    }
}