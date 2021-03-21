using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class Rectangle : Square
    {
        protected double My_b;
        public Rectangle() : base()
        {
            My_b = 0;
        }
        public Rectangle(double a, double b) : base(a)
        {
            My_b = b;
        }
        public override double Perimeter()
        {
            double p = My_b * 2 + (My_a * 2);
            return p;
        }
        public override double Area()
        {
            double s = My_b * My_a;
            return s;
        }
        public override void Print()
        {
            Console.WriteLine("Прямоугольник");
            Console.WriteLine($"Высота - {My_a}{Environment.NewLine}Ширина - {My_b}");
            Console.WriteLine($"Периметр = {Perimeter():f2}{Environment.NewLine}Площадь = {Area():f2}{Environment.NewLine}");
        }
    }
}
