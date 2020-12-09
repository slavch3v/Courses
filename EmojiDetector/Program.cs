using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var numberPattern = @"(\d)";
            var namepattern = @"(:{2}|\*{2})([A-Z][a-z]{2,})\1"; //string pattern = @"(\:\:|\*\*)([A-Za-z]{3,})\1";

            var regexNum = new Regex(numberPattern);
            var regexName = new Regex(namepattern);

            string comman = Console.ReadLine();

            var matchesNum = regexNum.Matches(comman);
            // var matchName = regexName.Match(comman);

            int n = 1;
           
             int countOfMatches = 0;
            regexNum.Matches(comman).Select(m => m.Value).Select(int.Parse).ToList().ForEach(x => n *= x);

         

           // var matchesName = regexName.Matches(comman);
            string full = string.Empty;

            var matches = regexName.Matches(comman);

            int totalEmojiCount = matches.Count;
            List<string> coolEmoji = new List<string>();
            List<string> readyNames = new List<string>();
            List<string> unReadyNames = new List<string>();

            char[] charsToTrim = { ':', '*' };

            foreach (Match name in matches)
            {
                readyNames.Add(name.Value.Trim(charsToTrim));
                unReadyNames.Add(name.Value);

            }

            for (int i = 0; i < readyNames.Count; i++)
            {
                var currentEmoji = unReadyNames[i];
                int sumOfLetter = 0;
                string currentWord = readyNames[i];
                for (int c = 0; c < currentWord.Length; c++)
                {
                    int currentLetter = (int)currentWord[c];
                    sumOfLetter += currentLetter;

                }
                if (sumOfLetter >= n)
                {
                    sb.AppendLine(currentEmoji);
                }
            }
            Console.WriteLine($"Cool threshold: {n}");
            Console.WriteLine($"{totalEmojiCount} emojis found in the text. The cool ones are:");
            Console.WriteLine(sb.ToString());

        }
    }


}
