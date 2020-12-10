using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int  grade = 1;
            int failGrade = 0;
            double totalRating = 0;

            while (grade <= 12 )
            {
                double rating  = double.Parse(Console.ReadLine());
                if (rating  >= 4)
                {
                    totalRating += rating ; 
                    grade++;
                    
                }
                else
                {
                    failGrade++;
                }

                if (failGrade == 2 )
                {
                    Console.WriteLine($"{name} has been excluded at {grade } grade");
                }
            }

            if (grade == 13 )
            {
                double average = totalRating / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");

            }
         

        }

    }
}


 

