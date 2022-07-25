using Xunit;

namespace UnitTesting.Tests
{
    
    public class AbsolutoTest
    {
        [Fact]
        public void TestComValorMenorQueZero()
        {
            //arrange
            Absoluto absoluto = new Absoluto();
            int actual;
            int expect = 1;

            //Act
            actual = absoluto.retornaValorAbsoluto(-1);

            //Assert
            Assert.Equal(expect, actual);

        }

        [Fact]
        public void TestComValorZero()
        {
            //arrange
            Absoluto absoluto = new Absoluto();
            int actual;
            int expect = 0;

            //Act
            actual = absoluto.retornaValorAbsoluto(0);

            //Assert
            Assert.Equal(expect, actual);

        }
    }
}