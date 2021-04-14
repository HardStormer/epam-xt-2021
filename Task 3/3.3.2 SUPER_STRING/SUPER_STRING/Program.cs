using System;
using System.Text.RegularExpressions;

namespace SUPER_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class StringExtension
    {
        public static void Language(this string inputString)
        {
            Regex russian = new Regex(@"[А-ЯЁа-яё]{1}");
            Regex english = new Regex(@"[A-Za-z]{1}");
            Regex digit = new Regex(@"[0-9]{1}");

            MatchCollection rus = russian.Matches(inputString);
            MatchCollection eng = english.Matches(inputString);
            MatchCollection dig = digit.Matches(inputString);

            if (rus.Count == inputString.Length)
                Console.WriteLine("Russian");
            else if (eng.Count == inputString.Length)
                Console.WriteLine("English");
            else if (dig.Count == inputString.Length)
                Console.WriteLine("Number");
            else
                Console.WriteLine("Mixed");
        }
    }
}
