using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nBrand:{Brand}\nPrice:{Price}";
        }
    }
}
