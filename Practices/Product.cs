using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices
{
    internal class Product
    {
        public float Price { get; set; } 
        public float Quantity { set; get; }
        public float Discount { set; get; }
        public float Total => Price * Quantity;
        public string Title { set; get; }
        public string Description { set; get; }
        public string Code { set; get; }





    }
}
