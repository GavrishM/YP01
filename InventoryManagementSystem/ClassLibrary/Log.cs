using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Log
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }

        public Log(int id, Product product)
        {
            Id = id;
            Product = product;
        }
        public Log(int id, Product product, string type, double quantity)
        {
            Id = id;
            Product = product;
            Type = type;
            Quantity = quantity;
        }
    }
}
