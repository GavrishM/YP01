using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StorageMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StorageMethod(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
