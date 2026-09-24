using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductIsInStock
    {
        public Product Product { get; set; }
        public double QuantityInStock { get; set; }
        public double QuantityForSale { get; set; }
    }
}
