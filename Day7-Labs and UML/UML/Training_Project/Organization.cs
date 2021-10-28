using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Project
{
    class Organization
    {
        public string org_name { get; set; }
        public string getName(string str)
        {
            org_name = str;
            return org_name;
        }

    }
}
