using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
     public class DecimalSplitter
    {
        public static int GetWhole(double Number)
        {
            return (Convert.ToInt32((int)Number));
        }

   
        public static double GetFraction(double Number)
        {
            return (Number - Convert.ToInt32((int)Number));
        }

       
        public static bool IsOdd(double Number)
        {
            return true;
        }
    }
}
