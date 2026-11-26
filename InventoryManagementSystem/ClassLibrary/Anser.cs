using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Anser
    {
        public bool Bool { get; set; }
        public string Text { get; set; }
        public Anser() { }
        public Anser(bool Bool, string text)
        {
            this.Bool = Bool;
            this.Text = text;
        }
    }
}
