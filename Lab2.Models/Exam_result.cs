using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Exam_result : Exam
    {
        /// <summary>
        /// Процент несдавших
        /// </summary>
        public double percent;

        public Exam_result()
        {
            percent = 50;
        }

        public void set(string discipline_, int visitors_, double time_, double percent_)
        {
            base.set(discipline_, visitors_, time_);
            percent = percent_;
        }

        public override double Q()
        {
            return base.Q() * (100 - percent) / 100;
        }

        public override string ToString()
        {
            return base.ToString() + "Процент получивших '2' составляет " + percent;
        }

    }
}
