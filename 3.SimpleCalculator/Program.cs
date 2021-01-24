using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            var a = 0;

            while (stack.Count > 1)
            {
                int leftNum = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int rightNum = int.Parse(stack.Pop());

                if (sign == "+")
                {
                   a =   leftNum + rightNum;
                    stack.Push(a.ToString());
                }
                else
                {
                    a = leftNum - rightNum;
                    stack.Push(a.ToString());
                }
            }

            Console.WriteLine(string.Join(' ', stack));

        }
    }
}
