using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;
                double totalSum = 0;


                while (destination != "End")
                {
                    while (totalSum < budget)
                    {
                        sum = double.Parse(Console.ReadLine());
                        totalSum += sum;
                    }

                    Console.WriteLine($"Going to {destination}!");
                    break;

                }


            }
        }
    }
}