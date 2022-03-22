using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int facebook = 150;
            int instagram = 100;
            int reddit = 50;

            for (int i = 1; i <= n; i++)
            {
                string page = Console.ReadLine();
                if (page == "Facebook")
                {
                    salary -= facebook;
                }
                else if (page == "Instagram")
                {
                    salary -= instagram;
                }
                else if (page == "Reddit")
                {
                    salary -= reddit;
                }
                else
                {
                    salary -= 0;
                }
            }
            if (salary <= 0)
            { Console.WriteLine("You have lost your salary."); }

            else

            { Console.WriteLine($"{salary}"); }


        }
    }
}