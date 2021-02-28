using System;
using System.Linq;
using System.Collections.Generic;

namespace _3.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] action = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (action[0] == 1)
                {
                    int numToPush = action[1];

                    if (numToPush  >= 1 && numToPush <= 109)
                    {
                        stack.Push(numToPush);
                    }
                    
                }
                else if (action[0] == 2)
                {
                    if (stack.Count == 0 )
                    {
                        
                    }
                    else
                    {
                        stack.Pop();
                    }
                   
                }
                else if (action[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (action[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
