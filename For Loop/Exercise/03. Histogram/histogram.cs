using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //setpoints
            int firstPercent = 0;
            int secondPercent = 0;
            int thirdPercent = 0;
            int fourthPercent = 0;
            int fifthPercent = 0;
            //input
            int numberOfEntries = int.Parse(Console.ReadLine());
            //logic
            for (int i = 0; i < numberOfEntries; i++)
            {
                int entryNumber = int.Parse(Console.ReadLine());
                if (entryNumber < 200)
                {
                    firstPercent++;
                }
                else if (entryNumber < 400)
                {
                    secondPercent++;
                }
                else if (entryNumber < 600)
                {
                    thirdPercent++;
                }
                else if (entryNumber < 800)
                {
                    fourthPercent++;
                }
                else
                {
                    fifthPercent++;
                }
            }
            int totalSum = firstPercent + secondPercent + thirdPercent + fourthPercent + fifthPercent;
            //output
            Console.WriteLine($"{(double)firstPercent / totalSum * 100:F2}%");
            Console.WriteLine($"{(double)secondPercent / totalSum * 100:F2}%");
            Console.WriteLine($"{(double)thirdPercent / totalSum * 100:F2}%");
            Console.WriteLine($"{(double)fourthPercent / totalSum * 100:F2}%");
            Console.WriteLine($"{(double)fifthPercent / totalSum * 100:F2}%");
        }
    }
}