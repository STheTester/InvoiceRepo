using NUnit.Framework;


namespace Invoice.Tests
{
    [TestFixture]
    public class OrderTests
    {
        readonly Order or = new Order();
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        //getOrderNumber
        public void OrderNumber_IsReturned_WhenGetOrderNumberIsCalled()
        {
            //Arrange
            //Act
            //Assert
            Assert.That(or.getOrderNumber().Equals("REF-000-000"));
        }
        //getCustomerFirstName
        [Test]
        public void CustomerFirstName_IsReturned_WhenGetCustomerFirstNameIsCalled()
        {
            Assert.That(or.getCustomerFirstName().Equals("First"));
        }
        //getCustomerLastName
        [Test]
        public void CustomerLastName_IsReturned_WhenGetCustomerLastNameIsCalled()
        {
            Assert.That(or.getCustomerLastName().Equals("Last"));
        }
        //getAddress
        [Test]
        public void Address_IsReturned_WhenGetAddressIsCalled()
        {
            Assert.That(or.getAddress().Equals("Address"));
        }
        //getTown
        [Test]
        public void Town_IsReturned_WhenGetTownIsCalled()
        {
            Assert.That(or.getTown().Equals("Town"));
        }
        //getCounty
        [Test]
        public void County_IsReturned_WhenGetCountyIsCalled()
        {
            Assert.That(or.getCounty().Equals("County"));
        }
        //getPostcode
        [Test]
        public void Postcode_IsReturned_WhenGetPostcodeIsCalled()
        {
            Assert.That(or.getPostcode().Equals("BT0 0OO"));
        }
        //getOrderDate
        [Test]
        public void OrderDate_IsReturned_WhenGetOrderDateIsCalled()
        {
            Assert.That(or.getOrderDate().Equals("01/01/1970"));
        }
    }
}
