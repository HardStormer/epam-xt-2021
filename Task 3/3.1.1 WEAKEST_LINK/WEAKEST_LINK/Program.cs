using System;
using System.Collections.Generic;

namespace WEAKEST_LINK
{
    class Program
    {
        static void Main()
        {
            List<int> people = new List<int>();
            Console.WriteLine("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:");
            int del = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; ++i)
                people.Add(i);

            int round = 1;

            while (people.Count >= del && people.Count > 1)
            {
                people.RemoveAt(del - 1);
                Console.WriteLine($"Раунд {round}. Вычеркнут человек. Людей осталось: {people.Count}");
                round++;
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей");
        }
    }
}