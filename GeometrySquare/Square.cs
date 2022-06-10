using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySquare
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
}
