using System;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d*\.?\d+)!(\d+)";

            string command = Console.ReadLine();
            double totalPrice = 0;

            Regex regex = new Regex(pattern);

            Console.WriteLine("Bought furniture:");
            while (command != "Purchase")
            {

                Match matched = regex.Match(command);

                if (matched.Success)
                {
                    string name = matched.Groups[1].Value;
                    double price =double.Parse( matched.Groups[2].Value);
                    double quantity =double.Parse( matched.Groups[3].Value);

                    totalPrice += price * quantity;

                    Console.WriteLine(name);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: { totalPrice :f2}");
        }
    }
}
