using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumA = 0;
            int sumE = 0;
            int sumI = 0;
            int sumO = 0;
            int sumU = 0;
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a')
                    sumA++;
                else if (s[i] == 'e')
                    sumE += 2;
                else if (s[i] == 'i')
                    sumI += 3;
                else if (s[i] == 'o')
                    sumO += 4;
                else if (s[i] == 'u')
                    sumU += 5;
            }
            int ResultSum = sumA + sumE + sumI + sumO + sumU;
            Console.WriteLine(ResultSum);
        }
    }
}