using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    class SkillAssureTrainingModel
    {
        public string ClientName { get; set; }
        public List<Iteration> iterations { get; set; } = new List<Iteration>();
        public List<Course> courses { get; set; } = new List<Course>();

        public int getTotalAssessmentInTheTraining()
        {
            int total = 0;

            for (int i = 0; i < this.iterations.Count; i++)
            {
                foreach (var item in this.iterations[i].courses)
                {
                    total += item.assessments.Count;
                }

            }
            return total;
        }


        public int getNumMCQBasedQuestions()
        {
            int total = 0;

            for (int i = 0; i < this.iterations.Count; i++)
            {
                foreach (var item in this.iterations[i].courses)
                {
                    for (int j = 0; j < item.assessments.Count; j++)
                    {
                        total += item.assessments[j].mcqs.Count;
                    }
                }

            }

            return total;
        }

        public int getNumHandsOnQuestions()
        {
            int total = 0;

            for (int i = 0; i < this.iterations.Count; i++)
            {
                foreach (var item in this.iterations[i].courses)
                {
                    for (int j = 0; j < item.assessments.Count; j++)
                    {
                        total += item.assessments[j].handsOns.Count;
                    }
                }

            }

            return total;
        }

        public int getTotalScoresOfAlAssignments()
        {
            int total = 0;
            for (int i = 0; i < this.iterations.Count; i++)
            {
                foreach (var item in this.iterations[i].courses)
                {
                    for (int j = 0; j < item.assessments.Count; j++)
                    {
                        total += item.assessments[j].TotalMarks();
                    }
                }

            }

            return total;
        }


    }
}