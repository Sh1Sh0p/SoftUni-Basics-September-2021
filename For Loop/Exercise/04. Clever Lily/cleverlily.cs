using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //setpoints
            int birthdayMoney = 0;
            int moneyTotal = 0;
            int numberOfToys = 0;
            //input
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            //logic
            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 0)
                {
                    birthdayMoney += 10;
                    moneyTotal += birthdayMoney - 1;
                }
                else
                {
                    numberOfToys++;
                }
            }
            moneyTotal += numberOfToys * toyPrice;
            //output
            Console.WriteLine(moneyTotal >= priceOfWashingMachine
                            ? $"Yes! {moneyTotal - priceOfWashingMachine:F2}"
                            : $"No! {priceOfWashingMachine - moneyTotal:F2}");
        }
    }
}