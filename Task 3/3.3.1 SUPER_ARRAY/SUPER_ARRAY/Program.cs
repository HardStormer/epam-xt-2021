using System;
using System.Collections.Generic;

namespace SUPER_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public static class ArrayExtension
    {
        #region 
        delegate void Operation(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mul(int x, int y)
        {
            return x * y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
        #endregion
        public static int Sum(int[] array)
        {
            int sum = 0;
            foreach (int x in array)
                sum += x;
            return sum;
        }

        public static int Mean(int[] array)
        {
            int mean = 0;
            foreach (int x in array)
                mean += x;
            return mean / array.Length;
        }

        public static int Freq(int[] array)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>(array.Length);

            for (int i = 0; i < array.Length; ++i)
            {
                if (!freq.ContainsKey(array[i]))
                {
                    freq.Add(array[i], 1);
                }
                else
                    freq[array[i]]++;
            }

            int max = 0;
            int maxFreqElement = 0;

            foreach (var freqOfTheElement in freq)
            {
                if (freqOfTheElement.Value > max)
                {
                    max = freqOfTheElement.Value;
                    maxFreqElement = freqOfTheElement.Key;
                }
            }

            return maxFreqElement;
        }
    }
}
