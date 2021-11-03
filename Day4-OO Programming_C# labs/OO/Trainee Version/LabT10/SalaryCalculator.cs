using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class SalaryCalculator
    {
    
        public static double GetSalary(Employee emp)
        {
            double Salary = 0;

            Salary = emp.Basic + emp.HRA + GetAllowance(emp);

            return Salary;
        }

    
        public static double GetAllowance(Employee emp)
        {
            double allowance = (emp.Basic * emp.AllowancePercentage / 100.0);
            return allowance;
        }
    }
}
