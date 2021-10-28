using System;
using System.Collections.Generic;
using System.Text;

namespace Company_Orders
{
    class RegCustomer : Customer
    {
        public double splDiscount { get; set; }

        public RegCustomer(double discount)
        {
            this.splDiscount = discount;
        }

        public double getsplDiscount()
        {
            return splDiscount;
        }
    }
}
