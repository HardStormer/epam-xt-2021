using System;
using System.Collections.Generic;
using System.Text;

namespace MyGAME2
{
    public class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }


        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int dx, int dy)
        {
            X += dx;

            Y += dy;
        }
        public void Back()
        {
            X = 60;
            Y = 25;
        }
        public void Draw(ConsoleWriter writer)
        {
            writer.SetPoint(X, Y, ConsoleColor.Green, '■');
        }
    }
}
