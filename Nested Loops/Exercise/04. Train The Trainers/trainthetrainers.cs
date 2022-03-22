using System;

namespace TrainTheTrainers
 
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  num of people in the jury
 
        int countOfPresentations = 0;
        double totalSumOfGrades = 0;
 
        string presentation = Console.ReadLine();
 
        while (presentation != Finish)
        {
            countOfPresentations++;
            double sumOfGrades = 0;
 
             for loop for the grades
            for (int i = 0; i  n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumOfGrades += grade;
            }
            double averageGrade = sumOfGrades  n;
            Console.WriteLine(${presentation} - {averageGradef2}.);
 
            totalSumOfGrades += averageGrade;
 
 
            presentation = Console.ReadLine();
        }
 
        Console.WriteLine($Student's final assessment is {totalSumOfGradescountOfPresentationsf2}.);
    }
 
}