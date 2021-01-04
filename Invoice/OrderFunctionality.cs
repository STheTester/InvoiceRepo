using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class OrderFunctionality
    {
        
        List<Product> ProductList = new List<Product>();
        List<Order> OrderList = new List<Order>();
        List<OrderDetails> OrderDetailsList = new List<OrderDetails>();

        //Product functions
        //Add new product
        public void NewProduct(Product n)
        {
            ProductList.Add(n);
            
        }
        //Get product object from list
        public int ProductInformation(string productNumber)
        {
            int productIndex = ProductList.FindIndex(p => p.getProductNumber() == productNumber);
            return productIndex;
        }
        //Get product details from object in list
        public string ProductName(int i)
        {
            string name = ProductList[i].getProductName();
            return name;
        }

        public decimal ProductPrice(int i)
        {
            decimal price = ProductList[i].getProductPrice();
            return price;
        }

        //Order functions
        //Add order to list
        public void NewOrder(Order o) 
        { 
            OrderList.Add(o);
        }

        //Get order details from object in list
        public string OrderFirstName(int i)
        {
            string first = OrderList[i].getCustomerFirstName();
            return first;
        }
        public string OrderLastName(int i)
        {
            string last = OrderList[i].getCustomerLastName();
            return last;
        }
        public string OrderAddress(int i)
        {
            string add = OrderList[i].getAddress();
            return add;
        }
        public string OrderTown(int i)
        {
            string town = OrderList[i].getTown();
            return town;
        }
        public string OrderCounty(int i)
        {
            string county = OrderList[i].getCounty();
            return county;
        }
        public string OrderPostcode(int i)
        {
            string postCode = OrderList[i].getPostcode();
            return postCode;
        }
        public string OrderOrderDate(int i)
        {
            string orderDate = OrderList[i].getOrderDate();
            return orderDate;
        }
        //Although the requirements state that I should pass in both
        //order and order details in the same call, I have separated out new order into two parts
        //This is to allow more than one item added to an order be added to an order.

        //Add order details to list
        public void NewOrderDetails(OrderDetails od)
        {
            OrderDetailsList.Add(od);
        }
        //Get order details index from order list
        public int OrderInformation(string orderNumber)
        {
            int orderIndex = OrderList.FindIndex(or => or.getOrderNumber() == orderNumber);
            return orderIndex;
        }
        //Get orderDetails details from object in list
        public int OrderProducts(string orderDetailsNumber)
        {
            int orderDetailsIndex = OrderDetailsList.FindIndex(od => od.getOrderDetailsNumber() == orderDetailsNumber);
            return orderDetailsIndex;
        }
        public string OrderProductNumber(int i)
        {
            string orderPn = OrderDetailsList[i].getProductNumber();
            return orderPn;
        }
        public string OrderDetailsOrderNumber(int i)
        {
            string orderOn= OrderDetailsList[i].getOrderNumber();
            return orderOn;
        }
        public int OrderQuantity(int i)
        {
            int orderQ = OrderDetailsList[i].getQuantity();
            return orderQ;
        }

        //OrderTotal
        public decimal OrderTotal(string orderNumber, string productNumber)
        {
            try
            {
                int o = OrderProducts(orderNumber);
                int p = ProductInformation(productNumber);
                int pQuantity = OrderDetailsList[o].getQuantity();
                decimal pPrice = ProductList[p].getProductPrice();
                decimal total = pQuantity * pPrice;
                return total;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
