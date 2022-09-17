using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    internal class Order
    {
        Product Prod = new Product();
        public float discount { get; set; }
        public float shipping { get; set; }
        public float total => GetTotal();

        public List<Product> products { get; set; }

        public Order()
        {
            this.products = new List<Product>();
        }

        private float GetTotal()
        {
            float total = 0;
            foreach (Product product in this.products)
            {
                total = total + product.Total;
            }
            total = total + shipping * (discount/100);
            return total;
        }
        public void AddToOrder(Product NewProduct)
        {
            foreach (Product P in products)
            {
                if (P.Code == NewProduct.Code)
                {
                    P.Quantity += NewProduct.Quantity;

                }
                else
                {
                    this.products.Add(NewProduct);
                }
            }
        }
    }
}
