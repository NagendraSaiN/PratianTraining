using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Orders
{
    class Company
    {
        public List<Customer> customersList { get; set; } = new List<Customer>();

        public List<Item> itemsList { get; set; } = new List<Item>();

        public double getTotalWorthOfOrderPlaced(List<Order> orders)
        {
            double total = 0.0;
            for (int i = 0; i < orders.Count; i++)
            {
                total += (orders[i].items[i].rate * orders[i].items[i].orderedItem.qty);
            }
            return total;
        }
    }
}