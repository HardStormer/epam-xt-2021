using System;
using System.Collections.Generic;
using System.Text;

namespace MyGAME2
{
    public class Enemy
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private string back;

        public Enemy(int x, int y)
        {
            X = x;
            Y = y;
            back = "Y -1";
        }

        public void Move(int a)
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 6);
            switch (rand)
            {
                case 1:
                    Y += a;
                    back = "Y -1";
                    break;
                case 2:
                    Y -= a;
                    back = "Y +1";
                    break;
                case 3:
                    X += a;
                    back = "X -1";
                    break;
                case 4:
                    X -= a;
                    back = "X +1";
                    break;
                default:
                    break;
            }
        }
        public void Back()
        {
            string b = back;

            if (b.Contains("Y"))
            {
                if (b.Contains("-1"))
                {
                    Y -= 1;
                }
                else if (b.Contains("+1"))
                {
                    Y += 1;
                }
            }
            else if (b.Contains("X"))
            {
                if (b.Contains("-1"))
                {
                    X -= 1;
                }
                else if (b.Contains("+1"))
                {
                    X += 1;
                }
            }
        }
        public bool Hit(int x, int y)
        {
            if (Math.Abs(X - x) < 2 && Math.Abs(Y - y) < 2) return true;
            return false;
        }

        public void Draw(ConsoleWriter writer)
        {
            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    if (i != j && i != -j)
                        writer.SetPoint(i + X, j + Y, ConsoleColor.Red, '0');
                }
            }
        }
    }
}
