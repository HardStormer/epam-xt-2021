using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class Triangle
    {
        protected double My_a;
        protected double My_b;
        protected double My_c;
        public Triangle()
        {
            My_a = 0;
            My_b = 0;
            My_c = 0;
        }
        public Triangle(double a, double b, double c)
        {
            My_a = a;
            My_b = b;
            My_c = c;
        }
        public virtual double Perimeter()
        {
            return My_a + My_b + My_c;
        }
        public virtual double Area()
        {
            double p = (My_a + My_b + My_c) / 2;
            return Math.Sqrt(p * (p - My_a) * (p - My_b) * (p - My_c));
        }
        public virtual void Print()
        {
            Console.WriteLine("Треугольник");
            Console.WriteLine($"Первая сторона - {My_a}{Environment.NewLine}Вторая сторона - {My_b}{Environment.NewLine}Третья сторона - {My_c}");
            Console.WriteLine($"Периметр - {Perimeter():f2}{Environment.NewLine}Площадь - {Area():f2}{Environment.NewLine}");
        }
    }
}
