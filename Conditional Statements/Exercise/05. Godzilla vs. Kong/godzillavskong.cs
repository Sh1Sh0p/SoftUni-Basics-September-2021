using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double allCostumePrice = statists * costumePrice;

            double discount = 0;

            if (statists > 150)
            {
                discount = allCostumePrice * 0.1;
                allCostumePrice = allCostumePrice - discount;
            }

            double expenses = decor + allCostumePrice;

            if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(expenses - budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - expenses):f2} leva left.");
            }

        }
    }
}