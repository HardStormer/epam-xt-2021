using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class Ring : Circle
    {
        protected double radius2;
        public Ring(double x, double y, double r1, double r2) : base(x, y, r1)
        {
            radius2 = r2;
        }
        public override double Perimeter()
        {
            double p = 2 * Math.PI * (radius + radius2);
            return p;
        }
        public override double Area()
        {
            double s = Math.PI * (radius * radius - radius2 * radius2);
            return s;
        }
        public override void Print()
        {
            Console.WriteLine("Кольцо");
            Console.WriteLine($"Координаты центра - ({x0}, {y0}){Environment.NewLine} Радиус - {radius2}{Environment.NewLine}" +
                $"Периметр - {Perimeter():f2}{Environment.NewLine}Площадь - {Area():f2}{Environment.NewLine}");
        }
    }
}
