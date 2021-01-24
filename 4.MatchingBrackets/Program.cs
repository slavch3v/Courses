using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            Stack<int> indexer = new Stack<int>();

            //(2 + 3) - (2 + 3)


            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    indexer.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = indexer.Pop();


                    Console.WriteLine(input.Substring(startIndex , i - startIndex + 1));



                }

            }

        }
    }
}
