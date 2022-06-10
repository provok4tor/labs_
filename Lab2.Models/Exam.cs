using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Exam
    {
        /// <summary>
        /// Дисциплина
        /// </summary>
        public string discipline;
        /// <summary>
        /// Число посетителей
        /// </summary>
        public int visitors;
        /// <summary>
        /// Длительность экзамена
        /// </summary>
        public double time;


        public Exam()
        {
            visitors = 25;
            time = 3.5;
        }

        public Exam(string discipline_, int visitors_, double time_)
        {
            discipline = discipline_;
            visitors = visitors_;
            time = time_;
        }

        public void set(string discipline_, int visitors_, double time_)
        {
            discipline = discipline_;
            visitors = visitors_;
            time = time_;
        }

        public virtual double Q()
        {
            if (time != 0)
                return visitors / time;
            else return 0;
        }

        public override string ToString()
        {
            return "Экзамен по " + discipline + " длился " + time + " часов. Посетило его " + visitors + " студентов. ";

        }
    }
}
