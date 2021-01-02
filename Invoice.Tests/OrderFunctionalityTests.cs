using NUnit.Framework;

namespace Invoice.Tests
{
    public class OrderFunctionalityTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Index_IsReturned_WhenProductAdded()
        {
            //Arrange 
            OrderFunctionality o1 = new OrderFunctionality();
            Product product1 = new Product("1", "Test1", 0.01m);
            o1.NewProduct(product1);

            //Act
            //Assert
            Assert.AreEqual(o1.ProductInformation("1"), 0);
        }

        [Test]
        public void Index_IsNotReturned_WhenProductNotInList()
        {
            OrderFunctionality o2 = new OrderFunctionality();
            Product product2 = new Product("1", "Test2", 0.01m);
            o2.NewProduct(product2);

            //Act
            //Assert
            Assert.AreNotEqual(o2.ProductInformation("2"), 0);
        }

        [Test]
        public void Index_IsReturned_WhenDefaultConstructorIsUsed()
        {
            OrderFunctionality o3 = new OrderFunctionality();
            Product product3 = new Product();
            o3.NewProduct(product3);

            //Act
            //Assert
            Assert.AreEqual(o3.ProductInformation("P0000"), 0);
        }
    }
}
