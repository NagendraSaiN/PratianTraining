using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
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

        /// <summary>
        /// Method to read double values from the console
        /// </summary>
        /// <returns></returns>
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
