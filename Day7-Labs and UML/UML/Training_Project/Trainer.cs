using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Project
{
    class Trainer
    {
        List<Trainee> trainees = new List<Trainee>();
        List<Training> trainings = new List<Training>();
        Organization org = new Organization();
        public void getOrganizationName(string str)
        {
            Console.WriteLine("Organisation Name: " + org.getName(str));
        }
       
    }
}
