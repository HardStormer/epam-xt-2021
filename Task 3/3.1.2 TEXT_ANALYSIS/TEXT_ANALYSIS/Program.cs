using System;
using System.Collections.Generic;
using System.Linq;

namespace TEXT_ANALYSIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            Console.WriteLine("Введите текст");
            string input = Console.ReadLine();
            char[] separators = new char[] { ' ', ';', ',', ':', '.', '!', '?', '-', '"' };
            string[] mywords = input.Split(separators);
            for (int i = 0; i < mywords.Length; ++i)
            {
                if (words.Count == 0)
                    words.Add(mywords[i].ToLower(), 1);
                else if (mywords[i] != "")
                {
                    if (!words.ContainsKey(mywords[i].ToLower())) 
                        words.Add(mywords[i].ToLower(), 1); 
                    else
                        words[mywords[i].ToLower()]++;
                }
            }
            List<int> lovedwords = new List<int>();
            foreach (KeyValuePair<string, int> word in words)
                lovedwords.Add(word.Value / mywords.Length * 100);
            int sum = 0;
            int num = 0;
            foreach (int spamParam in lovedwords)
                sum += spamParam;
            for (int i = 0; i < lovedwords.Count; ++i)
                if (lovedwords[i] >= 2)
                    num++;
            if (sum > 70)
                Console.WriteLine("У вас однообразный текст");
            else if (sum < 70 && sum > 20)
                Console.WriteLine("Ваш текст приемлим");
            else if (sum < 20)
                Console.WriteLine("У вас получился отличный текст");
            if (num > 0)
            {
                var loved =
                    from wordval in words
                    orderby wordval.Value
                    select wordval;
                foreach (var result in loved)
                    Console.WriteLine($"{result.Key} встречается {result.Value} раз(а)");
            }
        }
    }
}
