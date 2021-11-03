using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT11
{
    class Employee
    {
   
        public string EmpId { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
        public double HRA { get; set; }
        public double AllowancePercentage { get; set; }
        public int Role { get; set; }

        //public Employee(string EmpId, string Name, double Basic, double HRA, double AllowancePercentage, int Role)
        //{
          //  this.EmpId = EmpId;
            //this.Name = Name;
            //this.Basic = Basic;
            //this.HRA = HRA;
            //this.AllowancePercentage = AllowancePercentage;
            //this.Role = Role;
        //}


        public double GetSalary()
        {
            //Delegation
            return SalaryCalculator.GetSalary(this);
        }

   
        public double GetAllowance()
        {
            //Delegation
            return SalaryCalculator.GetAllowance(this);
        }

        public static string GetRoleDescription(int RoleId)
        {
            return RoleBuilder.GetRoleDescription(RoleId);
        }


        
    }
}
