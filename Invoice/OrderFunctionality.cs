using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class OrderFunctionality
    {
        
        List<Product> ProductList = new List<Product>();
        List<Order> OrderList = new List<Order>();
        List<OrderDetails> OrderDetailsList = new List<OrderDetails>();

        public void NewProduct(Product n)
        {
            ProductList.Add(n);
        }
        public int ProductInformation(string n)
        {
            int myIndex = ProductList.FindIndex(p => p.getProductNumber() == n);
            return myIndex;
        }
        public void OrderInformation() 
        { 
        }
        public void NewOrder() 
        { 
        }
        public void OrderProducts() 
        {          
        }
        public void OrderTotal()
        { 
        }
    }
}
