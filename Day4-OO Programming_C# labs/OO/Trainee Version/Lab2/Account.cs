using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Account
    {
       
        internal string _AccNo;
        internal string _Name;
        internal double _Balance;

      
        public string AccNo
        {
            get
            {
                return _AccNo;
            }
            set
            {
                string BankCode = "ICI";
                _AccNo = BankCode + value;
            }
        }

       
        public string Name { get; set; }
        
        public double Balance
        {
            get
            {
                return _Balance + ComputeInterest();
            }
            set
            {
                _Balance = value;
            }
        }

  
        private double ComputeInterest()
        {
            double Interest = _Balance * 8.5 / 100.0;
            return Interest;
        }      
    }
}
