using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySquare
{
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
