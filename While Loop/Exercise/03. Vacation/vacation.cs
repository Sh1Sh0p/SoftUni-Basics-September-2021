using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoneyForHoliday = double.Parse(Console.ReadLine());
            double jessyMoney = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counter = 0;
            while (counterDays != 5)
            {
                counter++;
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    counterDays = 0;
                    jessyMoney += money;
                }
                else if (action == "spend")
                {
                    jessyMoney -= money;
                    if (jessyMoney < 0)
                    {
                        jessyMoney = 0;
                    }
                    counterDays++;

                }
                if (jessyMoney >= needMoneyForHoliday)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    break;
                }
            }
            if (counterDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{counter}");
            }

        }
    }
}