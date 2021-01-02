using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class OrderDetails
    {
        private string _orderDetailsNumber;
        private string _orderNumber;
        private string _productNumber;
        private int _quantity;
        //Constructor with no params
        public OrderDetails()
        {
            _orderDetailsNumber = "REF-000-000-00";
            _orderNumber = "REF-000-000";
            _productNumber = "P0000";
            _quantity = 0;
        }
        //Constructor with params
        public OrderDetails(string orderDetailsNumber, string orderNumber, string productNumber, int quantity)
        {
            setOrderDetailsNumber(orderDetailsNumber);
            setOrderNumber(orderNumber);
            setProductNumber(productNumber);
            setQuantity(quantity);
        }

        public string getOrderDetailsNumber()
        {
            return _orderDetailsNumber;
        }

        public void setOrderDetailsNumber(string orderDetailsNumber)
        {
            this._orderDetailsNumber = orderDetailsNumber;
        }

        public string getOrderNumber()
        {
            return _orderNumber;
        }

        public void setOrderNumber(string orderNumber)
        {
            this._orderNumber = orderNumber;
        }

        public string getProductNumber()
        {
            return _productNumber;
        }

        public void setProductNumber(string productNumber)
        {
            this._productNumber= productNumber;
        }
        public int getQuantity()
        {
            return _quantity;
        }
        public void setQuantity(int quantity)
        {
            this._quantity = quantity;
        }
    }
}
