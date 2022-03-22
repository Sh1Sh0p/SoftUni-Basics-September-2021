using System;
 
namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int clas = 1;
            int notPassed = 0;
            double yearGrade = 0;
            bool expelled = false;
 
            while (clas <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    notPassed++;
                    if (notPassed > 0)
                    {
                        expelled = true;
                        break;
                    }
                    continue;
                }
                yearGrade += grade;
                clas++;
 
 
 
            }
            if (expelled)
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {(yearGrade / (clas - 1)):f2}");
            }
        }
    }
}