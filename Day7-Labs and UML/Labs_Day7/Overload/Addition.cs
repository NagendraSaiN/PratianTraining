using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    class Addition
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static string add(string a, string b)
        {
            return a + b;
        }
        public static double add(double a, double b)
        {
            return a + b;
        }

        static dynamic add(dynamic a, dynamic b)
        {
            return a + b;
        }
    }
}
