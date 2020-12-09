using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentWithGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());


                if (!studentWithGrade.ContainsKey(name))
                {
                    studentWithGrade.Add(name, new List<double>());

                }

                studentWithGrade[name].Add(grade);
                    
            }


            foreach (var item in studentWithGrade.Where(x=>x.Value.Average(x => x)>=4.50)
                .OrderByDescending(y =>y.Value.Average(z=>z)))
            {
                Console.WriteLine($"{item.Key} –> {item.Value.Average(x =>x):f2}");
            }
        }
    }
}