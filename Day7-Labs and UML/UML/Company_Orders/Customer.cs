using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Orders
{
    class Customer
    {
        public string Id { get; set; }
        public List<Order> orderList { get; set; } = new List<Order>();

        public RegCustomer RegCust { get; set; }


        public string Name { get; set; }
    }
}