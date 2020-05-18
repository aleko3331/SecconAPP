using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ItemssListViewModel
    {
        public IEnumerable<Item> ItemsList { get; set; }
        public int ItemsCount { get; set; }
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
    }
}
