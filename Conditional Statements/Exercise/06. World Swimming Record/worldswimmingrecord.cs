using System;
 
namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            double allTime = distance * timeForMeter;
 
            double plusTime = Math.Floor(distance / 15) * 12.5;
            double fullTime = distance * timeForMeter + plusTime;
 
 
 
            if (fullTime  < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(fullTime - record):f2} seconds slower.");
            }
 
 
 
        }
    }
}