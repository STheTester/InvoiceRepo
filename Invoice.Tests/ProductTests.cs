using NUnit.Framework;

namespace Invoice.Tests
{
    [TestFixture]
    public class ProductTests
    {
        readonly Product p = new Product();
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ProductNumber_IsReturned_WhenGetProductNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(p.getProductNumber().Equals("P0000"));
        }
        [Test]
        public void ProductName_IsReturned_WhenGetProductNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(p.getProductName().Equals("Name"));
        }

        [Test]
        public void ProductPrice_IsReturned_WhenGetProductNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(p.getProductPrice().Equals(0.00m));
        }
    }
}
