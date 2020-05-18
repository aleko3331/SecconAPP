using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Repository
{
    public interface ItemInterface
    {
        IEnumerable<Item> Items { get; }

    }
}
