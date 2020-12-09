using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arraysOfTokens = Console.ReadLine().Split();

            var firstWord = arraysOfTokens[0];
            var secondWord = arraysOfTokens[1];

            var longestWord = firstWord;
            var shortWord = secondWord;

            if (firstWord.Length < shortWord.Length)
            {
                longestWord = secondWord;
                shortWord = firstWord;
                  
            }

            var result = Manipulation(longestWord, shortWord);
            Console.WriteLine(result );
        }

        static  int Manipulation ( string longestWord , string shortWord )
        {
            int total = 0;

            for (int i = 0; i < shortWord.Length; i++)
            {
                var sum = longestWord[i] * shortWord[i];
                total += sum;
            }

            for (int i = shortWord.Length; i < longestWord.Length; i++)
            {
                var lastSum =+  longestWord[i];
                total += lastSum;
            }

            return total;
        }
    }
}
