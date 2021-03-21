using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class Circle
    {
        protected double x0;
        protected double y0;
        protected double radius;

        public Circle(double x, double y, double r)
        {
            x0 = x;
            y0 = y;
            radius = r;
        }
        public virtual double Perimeter()
        {
            double p = 2 * Math.PI * radius;
            return p;
        }
        public virtual double Area()
        {
            double s = Math.PI * radius * radius;
            return s;
        }
        public virtual void Print()
        {
            Console.WriteLine("Круг");
            Console.WriteLine($"Координаты центра - ({x0}, {y0}){Environment.NewLine}Радиус - {radius}{Environment.NewLine}" +
                $"Периметр - {Perimeter():f2}{Environment.NewLine}Площадь - {Area():f2}{Environment.NewLine}");
            
        }
    }
}
