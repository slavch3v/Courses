using System;
using System.Linq;
using System.Collections.Generic;

namespace _5.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queues = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queues.Enqueue(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ",queues));
        }
    }
}
