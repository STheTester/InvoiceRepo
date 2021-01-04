using NUnit.Framework;

namespace Invoice.Tests
{
    public class OrderFunctionalityTests
    {
        [SetUp]
        public void Setup()
        {
            
        }
        //Product functionality tests
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
        public void ProductName_IsReturned_WhenProductAdded()
        {
            //Arrange 
            OrderFunctionality o1 = new OrderFunctionality();
            Product product1 = new Product("1", "Test1", 0.01m);
            o1.NewProduct(product1);

            //Act
            int i = o1.ProductInformation("1");

            //Assert
            Assert.AreEqual(o1.ProductName(i), "Test1");
        }

        [Test]
        public void ProductPrice_IsReturned_WhenProductAdded()
        {
            //Arrange 
            OrderFunctionality o1 = new OrderFunctionality();
            Product product1 = new Product("1", "Test1", 0.01m);
            o1.NewProduct(product1);

            //Act
            int i = o1.ProductInformation("1");

            //Assert
            Assert.AreEqual(o1.ProductPrice(i), 0.01m);
        }

        //Order functionality tests
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
            OrderDetails od2 = new OrderDetails("REF-000-000-02", "REF-000-001", "P0001", 1);
            o6.NewOrderDetails(od2);
            //Act
            //Assert
            Assert.AreEqual(o6.OrderProducts("REF-000-000-02"), 1);
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
            Assert.AreEqual(o7.OrderProducts("REF-000-000-01"), 1);
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
            Assert.AreEqual(o8.OrderTotal("REF-000-000-01", "1"), 0.01m);
        }
        [Test]
        public void OrderTotalIsZero_IsReturned_WhenQuantityIsZero()
        {
            //Arrange 
            OrderFunctionality o8 = new OrderFunctionality();
            OrderDetails od1 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0001", 0);
            o8.NewOrderDetails(od1);
            Product product1 = new Product("1", "Test1", 0.01m);
            o8.NewProduct(product1);
            //Act
            //Assert
            Assert.AreEqual(o8.OrderTotal("REF-000-000-01", "1"), 0.00m);
        }

        [Test]
        public void CustomerFirstName_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county", "12345", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderFirstName(i), "test");
        }

        [Test]
        public void CustomerLastName_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county", "12345", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderLastName(i), "name");
        }

        [Test]
        public void CustomerAddress_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county", "12345", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderAddress(i), "1 High St");
        }

        [Test]
        public void CustomerTown_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "Belfast", "county", "12345", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderTown(i), "Belfast");
        }

        [Test]
        public void CustomerCounty_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "Antrim", "12345", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderCounty(i), "Antrim");
        }

        [Test]
        public void CustomerPostcode_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county", "BT71AA", "01/03/2020");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderPostcode(i), "BT71AA");
        }
        [Test]
        public void OrderDate_IsReturned_WhenOrderAdded()
        {
            //Arrange
            OrderFunctionality o9 = new OrderFunctionality();
            Order o3 = new Order("REF-000-001", "test", "name", "1 High St", "town", "county", "12345", "01/04/2025");
            o9.NewOrder(o3);

            //Act
            int i = o9.OrderInformation("REF-000-001");

            //Assert
            Assert.AreEqual(o9.OrderOrderDate(i), "01/04/2025");
        }
        [Test]
        public void OrderDetailsOrderNumber_IsReturned_WhenOrderDetailsAdded()
        {
            //Arrange
            OrderFunctionality o10 = new OrderFunctionality();
            OrderDetails od3 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0000", 1);
            o10.NewOrderDetails(od3);

            //Act
            int i = o10.OrderProducts("REF-000-000-01");

            //Assert
            Assert.AreEqual(o10.OrderDetailsOrderNumber(i), "REF-000-001");
        }
        [Test]
        public void OrderProductNumber_IsReturned_WhenOrderDetailsAdded()
        {
            //Arrange
            OrderFunctionality o10 = new OrderFunctionality();
            OrderDetails od3 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0000", 1);
            o10.NewOrderDetails(od3);

            //Act
            int i = o10.OrderProducts("REF-000-000-01");

            //Assert
            Assert.AreEqual(o10.OrderProductNumber(i), "P0000");
        }
        [Test]
        public void Quantity_IsReturned_WhenOrderDetailsAdded()
        {
            //Arrange
            OrderFunctionality o10 = new OrderFunctionality();
            OrderDetails od3 = new OrderDetails("REF-000-000-01", "REF-000-001", "P0000", 1);
            o10.NewOrderDetails(od3);

            //Act
            int i = o10.OrderProducts("REF-000-000-01");

            //Assert
            Assert.AreEqual(o10.OrderQuantity(i), 1);
        }

    }
}
