using System;
using System.Collections.Generic;
using System.Text;

namespace MyGAME2
{
    class Walls
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Walls(int x, int y)
        {
            X = x;
            Y = y;
        }
        public bool Hit(int x, int y)
        {
            if (Math.Abs(X - x) < 1 && Math.Abs(Y - y) < 1) return true;
            return false;
        }
        
        public void Draw(ConsoleWriter writer)
        {
            writer.SetPoint(X, Y, ConsoleColor.DarkGray, '#');
        }
    }
}
