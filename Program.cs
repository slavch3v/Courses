using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+.?\d*)\$";

            Regex regex = new Regex(pattern);

            string command = Console.ReadLine();
            double totalPrice = 0;
            double income = 0;

            while (command != "end of shift")
            {
                Match matched = regex.Match(command);


                if (matched.Success)
                {
                
                    string name = matched.Groups[1].Value;
                    string products = matched.Groups[2].Value;
                    double quantity = double.Parse(matched.Groups[3].Value);
                    double price = double.Parse(matched.Groups[4].Value);
                    totalPrice = price * quantity;

                    Console.WriteLine($"{name}: {products} - {totalPrice:f2}");
                    income += totalPrice;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
