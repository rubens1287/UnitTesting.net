
using Moq;
using Xunit;

namespace UnitTestingMoq.Test
{
    public class PropertyManagerConsumerTest
    {

        [Fact]
        public void SetupPropertyWithSetupGet()
        {
            //Arrange
            var mock = new Mock<IPropertyManager>();
            var propertyManagerConsumer = new PropertyManagerConsumer(mock.Object);
            mock.SetupGet(m => m.FirstName).Returns("Someone Nice");

            //Act
            var name = propertyManagerConsumer.GetName();

            //Assert
            Assert.Equal("Someone Nice", name);
            mock.VerifyGet(m => m.FirstName, Times.Once);
        }

        [Fact]
        public void VerifyPropertyIsSet_WithSpecificValue_WithSetupSet()
        {
            //Arrange
            var mock = new Mock<IPropertyManager>();
            var propertyManagerConsumer = new PropertyManagerConsumer(mock.Object);
            mock.SetupSet(m => m.FirstName = "Knights Of Ni!").Verifiable();

            //Act
            propertyManagerConsumer.ChangeName("Rubens Tester");

            //Assert
            mock.VerifySet(m => m.FirstName = "Rubens Tester", Times.Exactly(1));
        }

        [Fact]
        public void VerifyChangeRemoteName()
        {
            //Arrange
            var mock = new Mock<IPropertyManager>();
            var propertyManagerConsumer = new PropertyManagerConsumer(mock.Object);
            mock.SetupAllProperties();
            mock.Object.FirstName = "Rubens";

            //Act
            propertyManagerConsumer.ChangeRemoteName("My dear old wig");

            //Assert
            mock.Verify(m => m.MutateFirstName(It.Is<string>(a => a == "My dear old wig")));
        }

        [Fact]
        public void TrackPropertyWithSetUpProperty()
        {
            //Arrange
            var mock = new Mock<IPropertyManager>();
            mock.SetupProperty(m => m.FirstName);

            //Act
            mock.Object.FirstName = "Ni!";

            //Assert
            Assert.Equal("Ni!", mock.Object.FirstName);
       
        }

        [Fact]
        public void TrackAllPropertiesWithSetupAllProperties()
        {
            //Arrange
            var mock = new Mock<IPropertyManager>();
            mock.SetupAllProperties();

            //Act
            mock.Object.FirstName = "Robert";
            mock.Object.LastName = "Paulson";

            //Assert
            Assert.Equal("Robert", mock.Object.FirstName);
            Assert.Equal("Paulson", mock.Object.LastName);
        }

    }
}