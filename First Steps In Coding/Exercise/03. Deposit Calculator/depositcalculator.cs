using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
             Вход на потребителя
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearInterest = double.Parse(Console.ReadLine());
            double yearValue = deposit  yearInterest  100;
            double monthValue = yearValue  12;

             Изход за потребителя
            double endSum = deposit + monthValue  months;
            Console.WriteLine(${endSumf2});
        }
    }
}