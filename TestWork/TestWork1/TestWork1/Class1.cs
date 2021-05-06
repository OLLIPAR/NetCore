using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestWork1
{
     
    public class Class1
    {
        /// <summary>
        /// Площадь круга.
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns></returns>
        public string S(double r)
        {
            if (r > 0)
            { 
            double s;
            s = (r * r) * Math.PI;
            return "Площадь круга=" +s;
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Площадь квадрата/прямоугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <returns></returns>
        public string S(double a, double b)
        {
            if(a>0&&b>0)
            {
                if(a==b)
                {
                    return "Площадь квадрата ="+a*b;
                }
                else 
                {

                    return "Площадь прямоугольника ="+((b+a)*2); 
                }
            }
            else throw new IndexOutOfRangeException();
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns></returns>
        public string S(double a, double b, double c)
        {
            double s;
            double pp;
            if (a > 0 && b > 0 && c > 0)
            {
                pp = (a + b + c) / 2;
                s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));

                if(
                    Math.Sin((a * a + b * b - c * c) / (2 * a * b))!=90
                    || 
                    Math.Sin((a * a + c * c - b * b) / (2 * a * c)) != 90
                    ||
                    Math.Sin((c * c + b * b - a * a) / (2 * b * c)) != 90)
                {
                    return "Площадь треугольника=" + s;
                }
                else return "Площадь прямоугольного треугольника=" + s;
            }
            else throw new IndexOutOfRangeException();
        }

}
    
}

    