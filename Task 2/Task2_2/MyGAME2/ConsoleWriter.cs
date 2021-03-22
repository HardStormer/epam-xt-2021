using System;
using System.Collections.Generic;
using System.Text;

namespace MyGAME2
{
    public class ConsoleWriter
    {
        public readonly int Width;
        public readonly int Height;

        private Point[,] _activeBuffer;
        private Point[,] _activeView;

        public ConsoleWriter(int width, int height)
        {
            Width = width;
            Height = height;

            Console.SetWindowSize(width, height);

            _activeBuffer = new Point[width, height];
            _activeView = new Point[width, height];

            Clean(_activeBuffer);
            Clean(_activeView);
        }

        public void Flush()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    var view = _activeView[i, j];
                    var buff = _activeBuffer[i, j];

                    if (!Equals(view, buff))
                    {
                        Console.SetCursorPosition(i, j);
                        Console.ForegroundColor = buff.Color;
                        Console.Write(buff.Symb);
                    }
                }
            }

            var temp = _activeBuffer;
            _activeBuffer = _activeView;
            _activeView = temp;

            Clean(_activeBuffer);
        }

        public void WriteText(int i, int j, string text, ConsoleColor color)
        {
            for (var ind = 0; ind < text.Length; ind++)
            {
                SetPoint(i + ind, j, color, text[ind]);
            }
        }

        public void SetPoint(int i, int j, ConsoleColor color, char symb)
        {
            if (i < 0 || i >= Width) return;
            if (j < 0 || j >= Height) return;

            _activeBuffer[i, j] = new Point(color, symb);
        }

        private void Clean(Point[,] view)
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    view[i, j] = Point.Empty;
                }
            }
        }

        class Point
        {
            public static Point Empty = new Point(ConsoleColor.Black, ' ');

            public ConsoleColor Color { get; }
            public char Symb { get; }

            public Point(ConsoleColor color, char symb)
            {
                Color = color;
                Symb = symb;
            }

            public override bool Equals(object obj)
            {
                return obj is Point point &&
                       Color == point.Color &&
                       Symb == point.Symb;
            }

            public override int GetHashCode()
            {
                var hashCode = 286535306;
                hashCode = hashCode * -1521134295 + Color.GetHashCode();
                hashCode = hashCode * -1521134295 + Symb.GetHashCode();
                return hashCode;
            }
        }
    }
}
