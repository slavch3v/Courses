using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();
            var ticket = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                                        

           // var pattern = @"(\${6,}|\@{6,}|\#{6,}|\^{6,})";
             var pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex regex = new Regex(pattern);

            foreach (var ticks in ticket)
            {
                if (ticks.Length != 20 )
                {
                    result.Append($"Invalid ticket {Environment.NewLine}");
                    continue;
                }

                var leftSide = regex.Match(ticks.Substring(0, 10));
                var rightSide = regex.Match(ticks.Substring(10));
                var minLen = Math.Min(leftSide.Length, rightSide.Length);

                if (!leftSide.Success || !rightSide.Success)
                {
                    result.Append($"ticket \"{ticks}\" - no match");
                    continue;
                }

                var lefPart = leftSide.Value.Substring(0, minLen);
                var rightPart = rightSide.Value.Substring(0, minLen);

                if (lefPart.Equals(rightPart))
                {
                    if (lefPart.Length == 10)
                    {
                        result.Append($"ticket \"{ ticket}\" - {minLen}{lefPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                    }
                    else
                    {
                       // result.Append($"ticket \"{ ticket}\" - {minLen}{lefPart.Substring(0, 1)}{Environment.NewLine}");
                        result.Append($"ticket \"{ ticket}\" - {minLen}{lefPart.Substring(0, 1)}{Environment.NewLine}");
                    }
                }
                else
                {
                    result.Append($"ticket {ticks}- no match");
                }

               
            }

            Console.Write(result.ToString());
        }                                
    }
}
