using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT11
{
    class RoleBuilder
    {
  
        private static string[] Roles = { "UNDEFINED", "DEVELOPER", "TEST_ENGINEER", "SR_DEVELOPER", "DESIGNER" };

  
        public static string GetRoleDescription(int RoleId)
        {
            if (RoleId < 0 || RoleId > Roles.Length - 1)
                RoleId = 0;

            return Roles[RoleId];
        }
    }
}
