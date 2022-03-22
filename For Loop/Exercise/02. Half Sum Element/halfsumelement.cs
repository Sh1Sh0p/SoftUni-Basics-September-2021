using System;

namespace HalfSumElement
 
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(num > max)
                {
                    max = num;
                }
                sum = sum + num;
            }
 
 
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                var diff = Math.Abs(max - sum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
            }
    }