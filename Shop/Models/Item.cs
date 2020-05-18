using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Condition { get; set; }
        public string PhotoUrl { get; set; }
        public double Price { get; set; }
    }
}
