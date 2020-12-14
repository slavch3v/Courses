using System;
using System.Text.RegularExpressions;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"U\$(?<name>[A-Z][a-z]{2,})U\$P@\$(?<pass>[A-Za-z]{5,}\d+)P@\$";
            int count = 0;
            var regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match matched = regex.Match(input);

                if (matched.Success)
                {
                    count++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {matched.Groups[1].Value}, Password: { matched.Groups[2].Value}");
                    
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
