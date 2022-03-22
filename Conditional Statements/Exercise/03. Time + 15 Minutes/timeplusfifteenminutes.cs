using System;

namespace Time_15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            
            int allMin = hour * 60 + min + 15;
            int allHour = allMin / 60;
            int finalMin = allMin % 60;

            if (allHour > 23)
            {
                Console.WriteLine($"0:{finalMin:D2}");
            }
            else
            {

                Console.WriteLine($"{allHour}:{finalMin:D2}");
            }

        }
    }
}