using System;
 
namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double balance = 0;
 
            while (true)
            {
                string input = Console.ReadLine();
 
                if(input == NoMoreMoney)
                {
                    break;
                }
 
                double income = double.Parse(input);
                if (income = 0)
                {
                    Console.WriteLine(Invalid operation!);
                    break;
                }
                else
                {
                    balance += income;
                    Console.WriteLine($Increase {incomef2});
                }
 
 
            }
                    Console.WriteLine($Total {balancef2} );
        }
    }
}