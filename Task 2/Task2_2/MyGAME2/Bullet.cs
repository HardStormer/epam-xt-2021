using System;
using System.Collections.Generic;
using System.Text;

namespace MyGAME2
{
   
    public class Bullet
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public string Direction { get; private set; }

        public Bullet(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
        public void Move(int a)
        {
            if (Direction == "LEFT")
            {
                X -= a;
            }
            else if (Direction == "RIGHT")
            {
                X += a;
            }
            else if (Direction == "UP")
            {
                Y -= a;
            }
            else if (Direction == "DOWN")
            {
                Y += a;
            }
        }
        public void Draw(ConsoleWriter writer)
        {
            
            writer.SetPoint(X, Y, ConsoleColor.Magenta, '*');
        }
    }
}
