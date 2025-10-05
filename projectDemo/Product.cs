using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDemo
{
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Computed property
        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
