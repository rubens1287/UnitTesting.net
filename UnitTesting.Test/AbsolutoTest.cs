using Xunit;

namespace UnitTesting.Test
{
    
    public class AbsolutoTest
    {
        [Fact]
        public void TestComValorMenorQueZero()
        {
            //Arrange
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
            //Arrange
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