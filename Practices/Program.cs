using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] Product = new Product[20];
            Product Prod1 = new Product();
            Order order = new Order();

            Prod1.Price = 150;
            Prod1.Quantity = 5;
            Prod1.Title = "Colors BIC";
            Prod1.Description = "Box of 24 colors";
            Prod1.Code = "MVSLEPYOHPOETM";


            Product Prod2 = new Product();
            Prod2.Price = 170;
            Prod2.Quantity = 6;
            Prod2.Title = "Colors BIC";
            Prod2.Description = "Box of 24 colors";
            Prod2.Code = "MVSLEPYOHPOETM";

            order.AddToOrder(Prod1);
            order.AddToOrder(Prod2);
            order.shipping = 100;
            order.discount = 5;



        }
    }
}
