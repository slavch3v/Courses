using System;
using System.Collections.Generic;

namespace _0._3.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = new List<string>();

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];

                if (command.Length == 3)
                {
                    if (guest.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guest.Add(name);
                    }
                }
                else
                {
                    if (guest.Contains(name))
                    {
                        guest.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine , guest));
        }
    }
}
