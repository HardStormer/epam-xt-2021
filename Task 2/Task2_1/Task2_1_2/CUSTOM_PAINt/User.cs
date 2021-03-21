using System;
using System.Collections.Generic;
using System.Text;

namespace CUSTOM_PAINt
{
    class User
    {
        private string MyName;
        private List<Circle> circle;
        private List<Ring> ring;
        private List<Square> square;
        private List<Rectangle> rectangle;
        private List<Triangle> triangle;
        public User(string name)
        {
            MyName = name;
            circle = new List<Circle>();
            ring = new List<Ring>();
            square = new List<Square>();
            rectangle = new List<Rectangle>();
            triangle = new List<Triangle>();
        }
        public Circle AddCircle
        {
            set
            {
                circle.Add(value);
            }
        }
        public List<Circle> OutCircle
        {
            get
            {
                return circle;
            }
        }
        public Ring AddRing
        {
            set
            {
                ring.Add(value);
            }
        }
        public List<Ring> OutRing
        {
            get
            {
                return ring;
            }
        }
        public Square AddSquare
        {
            set
            {
                square.Add(value);
            }
        }
        public List<Square> OutSquare
        {
            get
            {
                return square;
            }
        }
        public Rectangle AddRectangle
        {
            set
            {
                rectangle.Add(value);
            }
        }
        public List<Rectangle> OutRectangle
        {
            get
            {
                return rectangle;
            }
        }
        public Triangle AddTriangle
        {
            set
            {
                triangle.Add(value);
            }
        }
        public List<Triangle> OutTriangle
        {
            get
            {
                return triangle;
            }
        }
        public string Name
        {
            set
            {
                MyName = value;
            }
            get
            {
                return MyName;
            }
        }
    }
}
