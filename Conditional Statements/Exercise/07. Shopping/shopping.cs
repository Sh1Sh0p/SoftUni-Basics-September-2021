using System;
 
namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
 
            double vidCardPrice = videoCards * 250;
            double procPrice = processors * vidCardPrice * 0.35;
            double ramPrice = ram * vidCardPrice * 0.1;
            double finalPrice = vidCardPrice + procPrice + ramPrice;
            if (videoCards > processors)
            {
                finalPrice = finalPrice * 0.85;
            }
 
            if (budget >= finalPrice)
            {
                Console.WriteLine($"You have {(budget - finalPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(finalPrice - budget):f2} leva more!");
            }
        }
    }
}