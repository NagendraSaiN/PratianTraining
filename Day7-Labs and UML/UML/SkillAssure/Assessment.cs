using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    class Assessment
    {
        public string AssessmentId { get; set; }
        public string Desc { get; set; }
        public int NoOfQuestions { get; set; }
        public DateTime AssessmentDate { get; set; }
        public List<MCQquestion> mcqs { get; set; } = new List<MCQquestion>();
        public List<HandsOnQuestion> handsOns { get; set; } = new List<HandsOnQuestion>();
        public int TotalMarks()
        {
            int total = 0;
            for (int i = 0; i < this.mcqs.Count; i++)
                total += this.mcqs[i].marks + this.handsOns[i].marks;

            return total;
        }
    }
}