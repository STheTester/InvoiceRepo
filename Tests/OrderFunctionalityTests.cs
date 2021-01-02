using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Compatibility;
using Invoice;

namespace Tests
{
    [TestFixture]
    class OrderFunctionalityTests
    {
        [TestCase]
        public void Test1()
        {
            Assert.That(1 == 1);
        }

        [TestCase]
        public void When_ProductAddedToList_ReturnsTrue()
        {
            //Arrange
            OrderFunctionality or = new OrderFunctionality();

            //Act

            //Assert
        }
    }
}
