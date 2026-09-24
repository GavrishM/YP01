using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductRange { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public OptionForSelling OptionForSelling { get; set; }
        public StorageMethod StorageMethod { get; set; }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Product(int id,
                       string name,
                       string productRange,
                       Category category,
                       Supplier supplier,
                       OptionForSelling optionForSelling,
                       StorageMethod storageMethod)
        {
            Id = id;
            Name = name;
            ProductRange = productRange;
            Category = category;
            Supplier = supplier;
            OptionForSelling = optionForSelling;
            StorageMethod = storageMethod;
        }
    }
}
