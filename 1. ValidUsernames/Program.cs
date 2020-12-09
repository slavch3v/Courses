using System;
using System.Linq;

namespace _1._ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string validUsername = string.Empty;

            foreach (var word in username)
            {
                validUsername = word;
                if (Isvalid(validUsername))
                {
                    Console.WriteLine(validUsername);
                }
            }
        }

        static bool Isvalid (string curr)
        {
            return curr.Length >= 3 &&
                curr.Length <= 16 &&
                curr.All(c => char.IsLetterOrDigit(c)) ||
                curr.Contains("-") || curr.Contains("_");
        }
    }
}
