using System;
 
namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numValue = int.Parse(Console.ReadLine());
            double sum = academyPoints;
 
            for (int i = 0; i < numValue; i++)
            {
                string nameEvaluate = Console.ReadLine();
                double pointsEvaluate = double.Parse(Console.ReadLine());
                int txt = nameEvaluate.Length;
                sum += (txt * pointsEvaluate) / 2 ;
                if (sum > 1250.5)
                {
                    break;
                }
 
 
            }
 
            if (sum > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sum:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameActor} you need {(1250.5 - sum):f1} more!");
            }
 
 
        }
    }
}