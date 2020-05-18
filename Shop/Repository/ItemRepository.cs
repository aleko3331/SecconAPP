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
        public IEnumerable<Item> Items => new List<Item>
        {
            new Item{Name = "კანფეტი1", Condition = ItemCondition.Acceptable.ToString(), Price = 20, PhotoUrl = "https://aprettylifeinthesuburbs.com/wp-content/uploads/2018/11/Easy-Christmas-Gumdrop-Nougat-Candy-150x150.jpg"},
            new Item{Name = "კანფეტი2", Condition = ItemCondition.Good.ToString(), Price = 12, PhotoUrl = "https://i.pinimg.com/474x/20/0b/57/200b57e6032a29f0d6e32925caf9ac35--sweets-clipart-candy-wrappers.jpg"},
            new Item{Name = "კანფეტი3", Condition = ItemCondition.New.ToString(), Price = 30, PhotoUrl = "https://americanprofile.com/wp-content/uploads/2013/10/halloween-candy-classics-150x150.jpg"},
            new Item{Name = "კანფეტი4", Condition = ItemCondition.Used.ToString(), Price = 25, PhotoUrl = "https://www.speldome.com/wp-content/uploads/2019/04/Mahjongg-Dimensions-Candy-150x150.jpg"},
            new Item{Name = "კანფეტი5", Condition = ItemCondition.New.ToString(), Price = 10, PhotoUrl = "https://aprettylifeinthesuburbs.com/wp-content/uploads/2011/12/Candy-Cane-Crumble-Nutella-Cookies-150x150.jpg"},
            new Item{Name = "კანფეტი6", Condition = ItemCondition.Acceptable.ToString(), Price = 5, PhotoUrl = "https://boulderlocavore.com/wp-content/uploads/2014/12/Candy-Cane-Hot-Cocoa-Pops-BoulderLocavore.com-205ps-150x150.jpg"},
            new Item{Name = "კანფეტი7", Condition = ItemCondition.Used.ToString(), Price = 25, PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTqpLEcv7QXNGLDDrIdymObkvNaaPx6OTY08L9ITOGiRqm5YOpK&usqp=CAU"},
            new Item{Name = "კანფეტი8", Condition = ItemCondition.Acceptable.ToString(), Price = 15, PhotoUrl = "https://wpcdn.us-east-1.vip.tn-cloud.net/www.channel3000.com/content/uploads/2019/12/modern-candy-company-pate-de-fruit-cbd-candy_1556743003799-jpg_38255181_ver1-0-150x150.jpg"},
            new Item{Name = "კანფეტი9", Condition = ItemCondition.Acceptable.ToString(), Price = 36, PhotoUrl = "https://www.sweetestmenu.com/wp-content/uploads/2019/10/caramelcandy19a-150x150.jpg"}
        };

    }
}
