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
            //Arrange 
            OrderFunctionality o2 = new OrderFunctionality();
            Product product2 = new Product("1", "Test2", 0.01m);
            o2.NewProduct(product2);

            //Act
            //Assert
            Assert.AreNotEqual(o2.ProductInformation("2"), 0);
        }

        [Test]
        public void ProductListIndex_IsReturned_WhenDefaultConstructorIsUsed()
        {
            //Arrange 
            OrderFunctionality o3 = new OrderFunctionality();
            Product product3 = new Product();
            o3.NewProduct(product3);

            //Act
            //Assert
            Assert.AreEqual(o3.ProductInformation("P0000"), 0);
        }

        [Test]
        public void OrderListIndex_IsReturned_WhenOrderIsAdded()
        {
            //Arrange 
            OrderFunctionality o4 = new OrderFunctionality();
            Order or1 = new Order();
            o4.NewOrder(or1);
            Order or2 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county","12345","01/03/2020");
            o4.NewOrder(or2);
            //Act
            //Assert
            Assert.AreEqual(o4.OrderInformation("REF-000-001"), 1);
        }
        [Test]
        public void OrderListIndex_IsReturned_WhenDefaultConstructorIsUsed()
        {
            //Arrange 
            OrderFunctionality o5 = new OrderFunctionality();
            Order or2 = new Order();
            o5.NewOrder(or2);
            //Act
            //Assert
            Assert.AreEqual(o5.OrderInformation("REF-000-000"),0);
        }

        [Test]
        public void OrderDetailsListIndex_IsReturned_WhenOrderDetailsAreAdded()
        {
            //Arrange 
            OrderFunctionality o6 = new OrderFunctionality();
            OrderDetails od1 = new OrderDetails();
            o6.NewOrderDetails(od1);
            OrderDetails od2 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0001", 1);
            o6.NewOrderDetails(od2);
            //Act
            //Assert
            Assert.AreEqual(o6.OrderProducts("REF-000-001"), 1);
        }
        [Test]
        public void OrderDetailsListIndex_IsReturned_WhenDefaultConstructorIsUsed()
        {
            //Arrange 
            OrderFunctionality o7 = new OrderFunctionality();
            OrderDetails od1 = new OrderDetails();
            o7.NewOrderDetails(od1);
            OrderDetails od2 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0001", 1);
            o7.NewOrderDetails(od2);
            //Act
            //Assert
            Assert.AreEqual(o7.OrderProducts("REF-000-000"), 0);
        }
        [Test]

        public void OrderTotal_IsReturned_WhenOrderDetailsAreAdded()
        {
            //Arrange 
            OrderFunctionality o8 = new OrderFunctionality();
            OrderDetails od1 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0001", 1);
            o8.NewOrderDetails(od1);
            Product product1 = new Product("1", "Test1", 0.01m);
            o8.NewProduct(product1);
            //Act
            //Assert
            Assert.AreEqual(o8.OrderTotal("REF-000-001", "1"), 0.01m);
        }
        [Test]
        public void OrderTotalIsZero_IsReturned_WhenQuanttityIsZero()
        {
            //Arrange 
            OrderFunctionality o8 = new OrderFunctionality();
            OrderDetails od1 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0001", 0);
            o8.NewOrderDetails(od1);
            Product product1 = new Product("1", "Test1", 0.01m);
            o8.NewProduct(product1);
            //Act
            //Assert
            Assert.AreEqual(o8.OrderTotal("REF-000-001", "1"), 0.00m);
        }
    }
}
