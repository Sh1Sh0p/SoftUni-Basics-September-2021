using System;
 
namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
 
 
            for ( int i = 1; i <= num; i++)
            {
               int sum = int.Parse(Console.ReadLine());
 
                if (i % 2 == 0)
                {
                    even += sum;
                }
                else
                {
                    odd += sum;
                }
            }
 
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else 
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(odd - even)}");
 
            }
 
        }
    }
}