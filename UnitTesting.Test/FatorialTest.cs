using Xunit;

namespace UnitTesting.Test
{
    public class FatorialTest
    {
        [Fact]
        public void TestComValorMenorQueZero()
        {
            //arrange
            Fatorial fatorial = new Fatorial();
            int actual;
            int expect = 0;

            //Act
            actual = fatorial.resultadoFatorial(-1);

            //Assert
            Assert.Equal(expect, actual);

        }

        [Fact]
        public void TestComValorIgualZero()
        {
            //arrange
            Fatorial fatorial = new Fatorial();
            int actual;
            int expect = 1;

            //Act
            actual = fatorial.resultadoFatorial(0);

            //Assert
            Assert.Equal(expect, actual);

        }


        [Fact]
        public void TestComValorMaiorQueZero()
        {
            //arrange
            Fatorial fatorial = new Fatorial();
            int actual;
            int expect = 6;

            //Act
            actual = fatorial.resultadoFatorial(3);

            //Assert
            Assert.Equal(expect, actual);

        }
    }
}
