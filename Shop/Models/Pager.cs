using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Pager<T>
    {

        IEnumerable<T> itemList;
        public int NumberOfTotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int ItemCountPerPage { get; set; }

        public int NumberOfPages
        {
            get
            {
                return (int)Math.Ceiling((double)NumberOfTotalItems / (double)ItemCountPerPage);
            }
        }

        public IEnumerable<T> PagedList
        {
            get
            {
                return itemList.Skip((CurrentPage - 1) * ItemCountPerPage).Take(ItemCountPerPage);
            }
        }

        public Pager(IEnumerable<T> itemList, int currentPage, int itemCountPerPage)
        {
            this.itemList = itemList;
            CurrentPage = currentPage;
            ItemCountPerPage = itemCountPerPage;
            NumberOfTotalItems = itemList.Count();
        }

    }
}
