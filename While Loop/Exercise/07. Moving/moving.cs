using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freespace = width * length * height;

            int sumOfCubicMeters = 0;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                int currentCubicMeter = int.Parse(command);
                sumOfCubicMeters += currentCubicMeter;
                if (freespace < sumOfCubicMeters)
                {
                    int neededCubicMeters = sumOfCubicMeters - freespace;
                    Console.WriteLine($"No more free space! You need {neededCubicMeters} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Done")
            {
                int freeCubicMeters = freespace - sumOfCubicMeters;
                Console.WriteLine($"{freeCubicMeters} Cubic meters left.");
            }
        }
    }
}