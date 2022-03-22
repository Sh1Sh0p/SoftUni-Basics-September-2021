using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            string typeAccomodation = "";
            double budgetSum = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";

                switch (season)
                {
                    case "summer":
                        budgetSum = budget * 0.3;
                        typeAccomodation = "Camp";
                        break;
                    case "winter":
                        budgetSum = budget * 0.7;
                        typeAccomodation = "Hotel";
                        break;
                }
            }
            else if (100 < budget && budget <= 1000)
            {
                place = "Balkans";

                switch (season)
                {
                    case "summer":
                        budgetSum = budget * 0.4;
                        typeAccomodation = "Camp";
                        break;
                    case "winter":
                        budgetSum = budget * 0.8;
                        typeAccomodation = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                typeAccomodation = "Hotel";
                budgetSum = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{typeAccomodation} - {budgetSum:f2}");
        }
    }
}