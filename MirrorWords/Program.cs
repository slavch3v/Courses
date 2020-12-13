using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@{1}|\#{1})(?<wordone>[A-Za-z][A-Za-z][A-Za-z]+)\1\1(?<wordtwo>[A-Za-z][A-Za-z][A-Za-z]+)\1";

            string command = Console.ReadLine();
            List<string> mirrors = new List<string>();
            var regex = new Regex(pattern);
            int count = 0;
            var matched = regex.Matches(command);

            if (matched.Count > 0)
            {
                Console.WriteLine($"{matched.Count} word pairs found!");

                foreach (Match word in matched)
                {
                    string wordOne = word.Groups["wordone"].Value;
                    string wordTwo = word.Groups["wordtwo"].Value;

                    char[] array = wordTwo.ToCharArray();
                   Array.Reverse(array);

                    wordTwo = new string(array);

                    if (wordOne == wordTwo)
                    {
                        char[] array2 = wordTwo.ToCharArray();
                        Array.Reverse(array);
                        wordTwo = new string(array);

                        mirrors.Add($"{ wordOne} <=> { wordTwo}");
                        count++;
                    }

                    

                }

            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }


            if (count > 0 )
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrors));
                  
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
