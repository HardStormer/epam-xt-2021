using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class Square
    {
        protected double My_a;
        public Square()
        {
            My_a = 0;
        }
        public Square(double a)
        {
            My_a = a;
        }
        public virtual double Perimeter()
        {
            double p = 4 * My_a;
            return p;
        }
        public virtual double Area()
        {
            double s = My_a * My_a;
            return s;
        }
        public virtual void Print()
        {
            Console.WriteLine("Квадрат");
            Console.WriteLine($"Сторона - {My_a}{Environment.NewLine}" +
                $"Периметр - {Perimeter():f2}{Environment.NewLine}Площадь - {Area():f2}{Environment.NewLine}");
        }
    }
}
