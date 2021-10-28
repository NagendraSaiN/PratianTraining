using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Project
{
    class Training
    {
        public List<Trainee> trainees = new List<Trainee>();
        public Course course { get; set; }

        public void getTrainingOrganizationName()
        {
            Console.WriteLine("Enter the Organization Name");
            string str = Console.ReadLine();
            Trainer trainer = new Trainer();
            trainer.getOrganizationName(str);
        }
        public void getNumOfTrainees()
        {
            Console.WriteLine("Number of Trainees:" + trainees.Count);
        }
        public int getTrainingDurationInHrs()
        {
            int total = 0;
            for (int i = 0; i < course.ModuleList.Count; i++)
            {
                Module module = course.ModuleList[i];
                for (int j = 0; j < module.UnitList.Count; j++)
                {
                    total += module.UnitList[j].durationHrs;
                }
            }
            return total;
        }
    }
}
