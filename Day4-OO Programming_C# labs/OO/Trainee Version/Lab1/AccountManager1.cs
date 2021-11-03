using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class AccountManager1
    {
     
        public void FillAccountData(Account Acc)
        {
            Acc.AccNo = "004701";       //Assigment to the wrong variable
            Acc.Name = "Nitesh";        //Assigment to the wrong variable 
            Acc.Balance = 45000.0;      //Assigment to the wrong variable
        }

     
        public void DisplayAccountData(Account Acc) 
        {
		    Console.WriteLine("AccNo : " + Acc.AccNo);  //Assigment to the wrong variable
            Console.WriteLine("Name : " + Acc.Name);    //Assigment to the wrong variable
            Console.WriteLine("Balance : " + Acc.Balance);  //Assigment to the wrong variable
	    }
    }
}
