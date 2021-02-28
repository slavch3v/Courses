using System;
using System.Linq;
using System.Collections.Generic;


namespace ReverseNumberswithaStack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stackBabyy = new Stack<int>();

            for (int i = 0; i < array.Length; i++)
            {
                stackBabyy.Push(array[i]);
            }

            Console.WriteLine(string.Join(" ", stackBabyy));
        }
    }
}
