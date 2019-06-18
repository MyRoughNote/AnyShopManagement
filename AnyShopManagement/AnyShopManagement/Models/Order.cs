using System;
using System.Collections.Generic;

namespace AnyShopManagement.Models
{
    public class Order : Item
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
