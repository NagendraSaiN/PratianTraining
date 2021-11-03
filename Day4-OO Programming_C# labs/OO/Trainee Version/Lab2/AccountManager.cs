using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class AccountManager
    {
     
        public void FillAccountData(Account Acc)
        {
            Console.WriteLine("Enter the Acc number");
            Acc.AccNo = CustomConsole.ReadString();
            Console.WriteLine("Enter the Acc name");
            Acc.Name = CustomConsole.ReadString();
            Console.WriteLine("Enter the Amount");
            Acc.Balance = CustomConsole.ReadDouble();
        }

      
        public void DisplayAccountData(Account Acc)
        {
            Console.WriteLine();
            Console.WriteLine("AccNo : " + Acc.AccNo);
            Console.WriteLine("Name : " + Acc.Name);
            Console.WriteLine("Balance : " + Acc.Balance);
        }
    }
}
