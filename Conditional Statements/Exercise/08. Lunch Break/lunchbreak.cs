using System;
 
namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int minSerial = int.Parse(Console.ReadLine());
            int rest = int.Parse(Console.ReadLine());
            double lunch = rest / 8.0;
            double moreRest = rest / 4.0;
            double freeTime = rest - lunch - moreRest;
 
            if (freeTime >= minSerial)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(freeTime - minSerial)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(minSerial - freeTime)} more minutes.");
            }
 
        }
    }
}
 