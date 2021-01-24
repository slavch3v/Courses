using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

            Stack<int> stack = new Stack<int>(arr);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    var com = command.Split();
                    stack.Push(int.Parse(com[1]));

                    stack.Push(int.Parse(com[2]));

                }
                else if (command.Contains("remove"))
                {
                    var com = command.Split();
                    var count = int.Parse(com[1]);

                    if (stack.Count > count)
                    {
                       

                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }


                command = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();

            Console.WriteLine("Sum: " + sum);

        }
    }
}
