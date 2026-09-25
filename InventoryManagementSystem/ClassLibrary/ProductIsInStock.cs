using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductIsInStock
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public double QuantityInStock { get; set; }
        public double QuantityForSale { get; set; }

        public ProductIsInStock(int id, Product product)
        {
            Id = id;
            Product = product;
        }
        public ProductIsInStock(int id, Product product, double quantityInStock, double quantityForSale)
        {
            Id = id;
            Product = product;
            QuantityInStock = quantityInStock;
            QuantityForSale = quantityForSale;
        }
    }
}
