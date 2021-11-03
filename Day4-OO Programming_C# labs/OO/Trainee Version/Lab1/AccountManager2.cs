using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class AccountManager2
    {
      
        public void FillAccountData(Account Acc)
        {
            Acc.AccNo = "004701";
            Acc.Name = "Nitesh";
            Acc.Balance = 45000.0;
        }

    
        public void DisplayAccountData(Account Acc)
        {
            Console.WriteLine("AccNo : " + Acc.AccNo);
            Console.WriteLine("Name : " + Acc.Name);
            Console.WriteLine("Balance : " + Acc.Balance);
        }
    }
}
