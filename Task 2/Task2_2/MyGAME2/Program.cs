using System;

namespace MyGAME2
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleWriter(120, 30);
            var game = new Game(writer);
            game.Run();
            Console.ReadLine();
        }
    }
}
