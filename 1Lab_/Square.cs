using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab_
{
    /// <summary>
    /// Квадратик
    /// </summary>
    public class Square
    {
        /// <summary>
        /// Цвет квадратика
        /// </summary>
        public string colour;
        /// <summary>
        /// Точка пересечения диагоналей/Геометрический центр квадратика
        /// </summary>
        public Point center;
        /// <summary>
        /// Отрезок, соединяющий центр квадратика и одну из его вершин
        /// </summary>
        public Segment semidiag;

        public Square()
        {
            colour = "Empty";
            center = new Point();
            semidiag = new Segment();
        }


        public Square(string colour_, Point center_, Segment smd_)
        {
            colour = colour_;
            center = center_;
            semidiag = smd_;
        }

        /// <summary>
        /// Задание размеров квадрата.
        /// При этом квадрат создаётся с полудиагональю заданной длинны
        /// и ориентированный так, что все его стороны будут параллельны
        /// осям координат
        /// </summary>
        public int SetDimension()
        {
            Random rnd = new Random();
            int sc = rnd.Next(1, 10);
            semidiag.pt1 = center;
            semidiag.pt2 = new Point(center.X + (sc / Math.Sqrt(2)), center.Y + (sc / Math.Sqrt(2)));
            return sc;
        }
        /// <summary>
        /// Растяжение квадратика
        /// </summary>
        public int Increase()
        {
            Random rnd = new Random();
            int inc = rnd.Next(2, 5);
            semidiag.Stretch(inc);
            return inc;

        }
        /// <summary>
        /// Сжатие квадрата
        /// </summary>
        public int Decrease()
        {
            Random rnd = new Random();
            int dec = rnd.Next(2, 5);
            semidiag.Compress(dec);
            return dec;
        }
        /// <summary>
        /// Поворот квадрата
        /// </summary>
        public int Turn()
        {
            Random rnd = new Random();
            int angle = rnd.Next(1, 180);
            Point vec = semidiag.ConvertToVector();
            double X_ = vec.X;
            double Y_ = vec.Y;
            vec.X = X_ * Math.Cos(angle * Math.PI / 180) - Y_ * Math.Sin(angle * Math.PI / 180);
            vec.Y = X_ * Math.Sin(angle * Math.PI / 180) + Y_ * Math.Cos(angle * Math.PI / 180);
            Point newPt2 = new Point(semidiag.pt1.X + vec.X, semidiag.pt1.Y + vec.Y);
            semidiag.pt2 = newPt2;
            return angle;
        }
        /// <summary>
        /// Изменение цвета квадрата
        /// </summary>
        public void ChangeColour(string newColour)
        {
            colour = newColour;
        }

    }


    /// <summary>
    /// Точка
    /// </summary>
    public class Point
    { 
        /// <summary>
        /// Абсцисса
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Ордината
        /// </summary>
        public double Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point (double X_, double Y_)
        {
            X = X_;
            Y = Y_;
        }

    }

    /// <summary>
    /// Отрезок
    /// </summary>
    public class Segment
    {
        
        public Point pt1 { get; set; }
        public Point pt2 { get; set; }

        public Segment()
        {
            pt1 = new Point();
            pt2 = new Point();
        }
        public Segment(Point pt1_, Point pt2_)
        {
            pt1 = pt1_;
            pt2 = pt2_;
        }
        /// <summary>
        /// Представляем наш отрезок в виде вектора
        /// </summary>
        /// <returns></returns>
        public Point ConvertToVector()
        {
            Point result = new Point(pt2.X - pt1.X, pt2.Y - pt1.Y);
            return result;
        }
        /// <summary>
        /// Увеличение отрезка в некоторое количество раз, притом pt1 остаётся прежней
        /// </summary>
        /// <param name="sc">Число раз</param>
        public void Stretch(int sc)
        {
            Point vec = this.ConvertToVector();
            //double length = Math.Sqrt(Math.Pow(vec.X, 2) + Math.Pow(vec.Y, 2));
            vec.X = vec.X * sc; //Умножаем длину вестора на заданное число
            vec.Y = vec.Y * sc;

            Point newPt2 = new Point(pt1.X + vec.X, pt1.Y + vec.Y);
            pt2 = newPt2;
        }
        /// <summary>
        /// Сжатие в некоторое число раз, притом точка pt1 остаётся прежней
        /// </summary>
        /// <param name="sc">Число раз</param>
        public void Compress(int sc)
        {
            Point vec = this.ConvertToVector();
            //double length = Math.Sqrt(Math.Pow(vec.X, 2) + Math.Pow(vec.Y, 2));
            vec.X = vec.X / sc; //Делим длину вестора на заданное число
            vec.Y = vec.Y / sc;

            Point newPt2 = new Point(pt1.X + vec.X, pt1.Y + vec.Y);
            pt2 = newPt2;
        }

    }




}
