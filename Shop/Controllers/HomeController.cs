using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Models;
using Shop.Repository;

namespace Shop.Controllers
{
  
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ItemRepository _item;
        private static int page = 1;

        public HomeController(ILogger<HomeController> logger, ItemRepository product)
        {
            _logger = logger;
            _item = product;
        }
        public ActionResult Item( int perPage = 5)
        {
            var item = _item.Items.ToList();
            var pager = new Pager<Item>(item, page, perPage);

            var model = new ItemssListViewModel()
            {
                ItemsList = pager.PagedList,
                ItemsCount = pager.NumberOfTotalItems,
                CurrentPage = pager.CurrentPage,
                NumberOfPages = pager.NumberOfPages
            };
            if (page == 2) { page = 1; }
            else page++;
            return View(model);
        }
    }
}
