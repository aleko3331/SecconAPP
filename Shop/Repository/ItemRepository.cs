using Shop.Enums;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public class ItemRepository : ItemInterface
    {
        public IEnumerable<Item> Products => new List<Item>
        {
            new Item{Name = "ხელთათმანი", Condition = ItemCondition.Acceptable.ToString(), Price = 2000, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "ბურთი", Condition = ItemCondition.Good.ToString(), Price = 3000, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "ფეხსაცმელი", Condition = ItemCondition.New.ToString(), Price = 4000, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "კარავი", Condition = ItemCondition.Used.ToString(), Price = 5000, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "თოკი", Condition = ItemCondition.New.ToString(), Price = 1200, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "საძილე ტომარა", Condition = ItemCondition.Acceptable.ToString(), Price = 1223, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "ბურთი", Condition = ItemCondition.Used.ToString(), Price = 1121, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "ფეხსაცმელი2", Condition = ItemCondition.Acceptable.ToString(), Price = 1, PhotoUrl = "https://via.placeholder.com/150"},
            new Item{Name = "ბურთი3", Condition = ItemCondition.Acceptable.ToString(), Price = 1213, PhotoUrl = "https://via.placeholder.com/150"}
        };

        public IEnumerable<Item> Items => throw new NotImplementedException();
    }
}
