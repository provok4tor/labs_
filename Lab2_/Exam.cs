using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 
 Экзамен: 
дисциплина; 
число студентов на экзамене;    - продолжительность экзамена (ч). 
Q = число студентов / продолжительность 
P: процент двоек  
 
 
Qp = Q· ( 100-Р)/100 


 
 
 */



namespace Lab2_
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
            return visitors / time;
        }

        public override string ToString()
        {
            return "Экзамен по " + discipline + " длился " + time + " часов. Посетило его " + visitors + " студентов. ";

        }
    }


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
