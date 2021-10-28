using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Orders
{
    class Order
    {
        public List<Item> items { get; set; } = new List<Item>();
    }
}