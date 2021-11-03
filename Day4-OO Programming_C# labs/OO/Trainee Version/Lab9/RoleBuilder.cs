using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9
{
    class RoleBuilder
    {
     
        private static string[] Roles = { "UNDEFINED", "DEVELOPER", "TEST_ENGINEER", "SR_DEVELOPER", "DESIGNER" };

    
        public static string GetRoleDescription(int RoleId)
        {
            if(RoleId<1 || RoleId>4)
            {
                return "UNDEFINED";
            }
            else
                return Roles[RoleId];
        }
    }
}
