using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Basic_StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushToStak = elements[0];
            int popOnStack = elements[1];
            int containsNum = elements[2];

         

            Stack<int> stack = new Stack<int>();

            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < num.Length; i++)
            {
                stack.Push(num[i]);
            }

            int stop = 0;
            for (int i = 0; i < popOnStack; i++)
            {
                if (pushToStak <= popOnStack)
                {
                    Console.WriteLine(0);
                    stop++;
                    break;
                }
                stack.Pop();
            }

            if (stop == 0 )
            {


                bool isValid = stack.Contains(containsNum);

                if (isValid)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
