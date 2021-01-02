using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class main
    {
        static void Main()
        {
            OrderFunctionality or = new OrderFunctionality();

            Product p = new Product("1", "test", 0.00m);
            Product l = new Product("3", "test", 0.00m);
            or.NewProduct(p);
            or.NewProduct(l);
            Console.WriteLine(or.ProductInformation("3")); ;
            Console.WriteLine(or.ProductInformation("1"));;
            Console.ReadKey();
        }
    }
}
