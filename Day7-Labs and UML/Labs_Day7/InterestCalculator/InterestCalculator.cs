using System;
using System.Collections.Generic;
using System.Text;

namespace InterestCalculator
{
    class InterestCalculator
    {
        public double principle, intrate;
        public int time;
        public InterestCalculator(int t, double p)
        {
            this.time = t;
            this.principle = p;
            if (t <= 5)
            {
                this.intrate = 10;
            }
            else
                this.intrate = 12;
            getInterest();
        }
        public void getInterest()
        {
            double Simple_interest = (principle * intrate * time) / 100;
            Console.WriteLine("Simple Interest for entered parameters : {0}", Simple_interest);
        }

    }
}
