using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Acc = new Account();
		
		    Console.WriteLine("Performing Account Transactions using AccManager...");
            AccountManager Manager = new AccountManager();
            Manager.FillAccountData(Acc);
            Console.WriteLine("======================================");
            Manager.DisplayAccountData(Acc);
            Console.ReadLine();
        }
    }
}
