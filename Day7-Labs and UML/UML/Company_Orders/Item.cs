using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Orders
{
    class Item
    {
        public string desc { get; set; }
        public double rate { get; set; }
        public OrderedItem orderedItem { get; set; } = new OrderedItem();

        public List<OrderedItem> orderedItemsList = new List<OrderedItem>();
    }
}