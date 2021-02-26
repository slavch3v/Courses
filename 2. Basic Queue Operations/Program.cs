using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementToAdd = elements[0];
            int elementToDequeue = elements[1];
            int searchingNumInQueue = elements[2];

            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < num.Length; i++)
            {
                queue.Enqueue(num[i]);
            }

            int breakProgram = 0;

            for (int i = 0; i < elementToDequeue; i++)
            {

                if (elementToDequeue >= elementToAdd)
                {
                    Console.WriteLine(0);
                    breakProgram++;
                    break;
                }

                queue.Dequeue();
            }

            if (breakProgram == 0 )
            {
                bool containsNum = queue.Contains(searchingNumInQueue);

                if (containsNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

        }
    }
}
