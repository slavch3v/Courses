using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());

            Queue<string> result = new Queue<string>(names);
            int count = 0;

            while (result.Count > 1)
            {
                count++;

                string kid = result.Dequeue();

                if (count == num )
                {
                    count = 0;
                    Console.WriteLine("Removed "+ kid );
                }
                else
                {
                    result.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + result.Dequeue());
        }
    }
}
