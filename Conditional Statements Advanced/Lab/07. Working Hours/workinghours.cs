using System;
 
namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine().ToLower();
 
            if (10 <= hours && hours <= 18) 
            {
                switch (weekDay)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                    case "saturday":
                        Console.WriteLine("open");
                        break;
 
                    case "sunday":
                        Console.WriteLine("closed");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
 
        }
    }
}