using Pri.Generics.Cons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    internal class Order<T> 
    {
        public T Item { get; set; }
        public int Quantity { get; set; }
    }
}
