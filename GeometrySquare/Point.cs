using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrySquare
{
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
        public Point(double X_, double Y_)
        {
            X = X_;
            Y = Y_;
        }

    }
}
