using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Entities
{
    public class Television :BaseEntity
    {
        public int ScreenSize { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\nScreensize:{ScreenSize}\nModel:{Model}";
        }
    }
}
