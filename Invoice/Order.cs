using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Order
    {
        private string _orderNumber;
        private string _customerFirstName;
        private string _customerLastName;
        private string _address;
        private string _town;
        private string _county;
        private string _postcode;
        private string _orderDate;

        //Constructor with no params
        public Order()
        {
            _orderNumber = "REF-000-000";
            _customerFirstName = "First";
            _customerLastName = "Last";
            _address = "Address";
            _town = "Town";
            _county = "County";
            _postcode = "BT0 0OO";
            _orderDate = "01/01/1970";
        }
        //Constructor with params
        public Order(string orderNumber,
        string customerFirstName,
        string customerLastName,
        string address,
        string town,
        string county,
        string postcode,
        string orderDate)
        {
            setOrderNumber(orderNumber);
            setCustomerFirstName(customerFirstName);
            setCustomerLastName(customerLastName);
            setAddress(address);
            setTown(town);
            setCounty(county);
            setPostcode(postcode);
            setOrderDate(orderDate);
        }
        public string getOrderNumber()
        {
            return _orderNumber;
        }
        public void setOrderNumber(string orderNumber)
        {
            this._orderNumber = orderNumber;
        }
        public string getCustomerFirstName()
        {
            return _customerFirstName;
        }
        public void setCustomerFirstName(string customerFirstname)
        {
            this._customerFirstName = customerFirstname;
        }
        public string getCustomerLastName()
        {
            return _customerLastName;
        }
        public void setCustomerLastName(string customerLastname)
        {
            this._customerLastName = customerLastname;
        }
        public string getAddress()
        {
            return _address;
        }
        public void setAddress(string address)
        {
            this._address = address;
        }
        public string getTown()
        {
            return _town;
        }
        public void setTown(string town)
        {
            this._town = town;
        }
        public string getCounty()
        {
            return _county;
        }
        public void setCounty(string county)
        {
            this._county = county;
        }
        public string getPostcode()
        {
            return _postcode;
        }
        public void setPostcode(string postcode)
        {
            this._postcode = postcode;
        }
        public string getOrderDate()
        {
            return _orderDate;
        }
        public void setOrderDate(string orderDate)
        {
            this._orderDate = orderDate;
        }
    }
}
