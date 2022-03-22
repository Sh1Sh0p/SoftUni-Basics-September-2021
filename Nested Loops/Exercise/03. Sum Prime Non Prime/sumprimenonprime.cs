using System;
 
namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
 
            int primeSum = 0;
            int notPrimeSum = 0;
 
            while (input != "stop")
            {
                int n = int.Parse(input);
 
                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
 
                int m = n / 2;
                bool isNotPrime = false;
 
                for (int i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }
 
                if (isNotPrime)
                {
                    notPrimeSum += n;
                }
                else
                {
                    primeSum += n;
                }
 
                input = Console.ReadLine();
            }
 
 
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
 
 
        }
    }
}