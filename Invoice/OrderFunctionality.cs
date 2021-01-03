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
        
        readonly List<Product> ProductList = new List<Product>();
        readonly List<Order> OrderList = new List<Order>();
        readonly List<OrderDetails> OrderDetailsList = new List<OrderDetails>();

        public void NewProduct(Product n)
        {
            ProductList.Add(n);
        }
        public int ProductInformation(string productNumber)
        {
            int productIndex = ProductList.FindIndex(p => p.getProductNumber() == productNumber);
            return productIndex;
        }
        public void NewOrder(Order o) 
        { 
            OrderList.Add(o);
        }

        //Although the requirements state that I should pass in both
        //order and order details in the same call, I have separated out new order into two parts
        //This is to allow more than one item added to an order be added to an order.
        public void NewOrderDetails(OrderDetails od)
        {
            OrderDetailsList.Add(od);
        }
        public int OrderInformation(string orderNumber)
        {
            int orderIndex = OrderList.FindIndex(or => or.getOrderNumber() == orderNumber);
            return orderIndex;
        }
        public int OrderProducts(string orderNumber)
        {
            int orderDetailsIndex = OrderDetailsList.FindIndex(od => od.getOrderNumber() == orderNumber);
            return orderDetailsIndex;
        }
        //Need to figure out how to get all products added to an order.
        public decimal OrderTotal(string orderNumber, string productNumber)
        {
            int o = OrderProducts(orderNumber);
            int p = ProductInformation(productNumber);
            int pQuantity = OrderDetailsList[o].getQuantity();
            decimal pPrice = ProductList[p].getProductPrice();
            decimal total = pQuantity * pPrice;
            return total;
        }
    }
}
