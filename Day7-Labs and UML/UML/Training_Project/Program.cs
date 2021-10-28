using System;
using System.Linq;
using System.Collections.Generic;


namespace Training_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Training t = new Training();
            
            Trainee t1= new Trainee();
            Trainee t2 = new Trainee();
            t.trainees.Add(t1);
            t.trainees.Add(t2);
            

            Course c = new Course();

            Module m1 = new Module();
            Module m2 = new Module();
            Module m3 = new Module();


            Unit u1 = new Unit { durationHrs = 4 };
            Unit u2 = new Unit { durationHrs = 5 };


            Topic top1 = new Topic { T_Name = "C#" };
            Topic top2 = new Topic { T_Name = "Java" };
            Topic top3 = new Topic { T_Name = "C++" };

            u1.TopicList.Add(top1);
            u2.TopicList.Add(top2);
            u1.TopicList.Add(top3);
            u1.TopicList.Add(top2);
            u2.TopicList.Add(top1);
            u2.TopicList.Add(top3);

            m1.UnitList.Add(u1);
            m1.UnitList.Add(u2);
            m2.UnitList.Add(u1);
            m2.UnitList.Add(u2);
            m3.UnitList.Add(u1);

            c.ModuleList.Add(m1);
            c.ModuleList.Add(m2);
            c.ModuleList.Add(m3);

            t.course = c;
            t.getTrainingOrganizationName();
            t.getNumOfTrainees();
            Console.WriteLine("Duration in Hours :" + $"{t.getTrainingDurationInHrs()}");

        }
    }
}
