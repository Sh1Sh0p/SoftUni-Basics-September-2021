using System;
 
namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
 
            double sum = 0;
 
            if (city == "Sofia")
            {
                if (0 <= sales && sales <= 500)
                {
                    sum = sales * 0.05;
                }
                else if (500 < sales && sales <= 1000)
                {
                    sum = sales * 0.07;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sum = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    sum = sales * 0.045;
                }
                else if (500 < sales && sales <= 1000)
                {
                    sum = sales * 0.075;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sum = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    sum = sales * 0.055;
                }
                else if (500 < sales && sales <= 1000)
                {
                    sum = sales * 0.08;
                }
                else if (1000 < sales && sales <= 10000)
                {
                    sum = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.145;
                }
            }
 
            if (sum == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{(sum):f2}");
            }
 
        }
    }
}