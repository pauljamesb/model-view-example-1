using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S1.Models
{
    public class MenuModelView
    {
        public IEnumerable<Pizza> PizzaMV { get; set; }
        public IEnumerable<IceCream> IceCreamMV { get; set; }
    }
}
