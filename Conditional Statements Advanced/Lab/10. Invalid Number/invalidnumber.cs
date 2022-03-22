using System;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if (num == 0)
            {

            }
            else if (num >= 100 && num <= 200)
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}