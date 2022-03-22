using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int timeExam = hourExam * 60 + minExam;
            int timeArrive = hour * 60 + min;
            int difference = timeExam - timeArrive;
            int hourLate = 0;
            int minLate = 0;
            if (difference < 0)
            {
                hourLate = (timeArrive - timeExam) / 60;
                minLate = -(difference % 60);
                Console.WriteLine("Late");
                if (hourLate == 0)
                {
                    Console.WriteLine($"{minLate} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{hourLate}:{minLate:D2} hours after the start");
                }
            }
            else if (difference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (difference <= 30 && difference > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{difference} minutes before the start");
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");
                hourLate = (timeExam - timeArrive) / 60;
                minLate = difference % 60;
                if (hourLate == 0)
                {
                    Console.WriteLine($"{minLate:D2} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{hourLate}:{minLate:D2} hours before the start");
                }
            }
        }
    }
}