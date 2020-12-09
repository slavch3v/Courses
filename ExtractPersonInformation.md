using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var patterName = @"\@(\w+)\|";
             string patternAge = @"\#(\d+)\*";
            var regexName = new Regex(patterName);
            var regexAge = new Regex(patternAge);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();

                var matchName = regexName.Match(command);
                var matchAge = regexAge.Match(command);

                if (matchName.Success && matchAge.Success)
                {
                    sb.Append($"{matchName.Groups[1].Value} is {matchAge.Groups[1].Value} years old.{Environment.NewLine}");

                }
            }

            Console.WriteLine(sb);
        }
    }
}
