using System;
using System.Collections.Generic;
using System.Text;

namespace Training_Project
{
    class Trainee
    {
        public Trainer Traine { get; set; }
        public List<Training> TrainingList { get; set; } = new List<Training>();
    }
}
