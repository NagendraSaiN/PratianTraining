using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT11
{
 
    class CustomConsole
    {
     
        public static string ReadString()
        {
            return Console.ReadLine();
        }

    
        public static float ReadFloat()
        {
            return float.Parse(Console.ReadLine());
        }


        public static double ReadDouble()
        {
            return Double.Parse(Console.ReadLine());
        }

        public static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static char ReadChar()
        {
            return char.Parse(Console.ReadLine());
        }
    }
}
