using System;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            string collection = Console.ReadLine();

            int one = first;
            int two = second;

            int total = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                char curr = collection[i];
                int sum = curr;

                if (sum > one && sum < two || sum > two && sum < one)
                {
                    total += sum;
                }
            }

            Console.WriteLine(total);
        }
    }
}
