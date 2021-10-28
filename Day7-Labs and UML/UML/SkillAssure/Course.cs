using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssure
{
    class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }

        public List<Assessment> assessments { get; set; } = new List<Assessment>();

    }
}