using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
namespace Invoice.Tests
{
    public class OrderDetailsTests
    {
        readonly OrderDetails o = new OrderDetails();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void OrderDetailsNumber_IsReturned_WhenGetOrderDetailsNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(o.getOrderDetailsNumber().Equals("REF-000-000-00"));
        }

        [Test]
        public void OrderNumber_IsReturned_WhenGetOrderNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(o.getOrderNumber().Equals("REF-000-000"));
        }

        [Test]
        public void ProductNumber_IsReturned_WhenGetProductNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(o.getProductNumber().Equals("P0000"));
        }

        [Test]
        public void Quantity_IsReturned_WhenGetQuantityIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(o.getQuantity().Equals(0));
        }
    }
}
