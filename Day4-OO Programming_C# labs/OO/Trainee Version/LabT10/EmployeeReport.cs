using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabT10
{
    class EmployeeReport
    {
       
        public string ReportDate { get; set; }
	
	    private void PrintLine() 
        {
		    Console.WriteLine("---------------------------------------------------------------------------");
	    }

	    private void DisplayHeader() 
        {
		    PrintLine();
		    Console.WriteLine("EMPLOYEE REPORT\t\t\t\t");
		    Console.WriteLine("Date : " + ReportDate);
		    PrintLine();
	    }

      
	    private void DisplayFooter(int Count) {
		    PrintLine();
		    Console.WriteLine("Total Employees : " + Count);
		    PrintLine();
	    }

   
	    public void DisplayEmployees(Employee[] Employees) 
        {
		    DisplayHeader();

            Console.WriteLine("EMP_ID\tNAME\tROLE\t\tBASIC\tHRA\tALLOW\tSALARY");
			for(int i=0;i<Employees.Length;i++)
            {
                Console.WriteLine(Employees[i].EmpId + "\t" + Employees[i].Name + "\t" + Employees[i].Role +"\t" + Employees[i].Basic+"\t"+Employees[i].HRA+"\t"+ Employee.GetAllowance(Employees[i])+"\t"+ Employee.GetSalary(Employees[i]) );
            }
            PrintLine();
            PrintLine();

    		
    		
    		//DisplayFooter(Employees.Length);
	    }
    }
}
