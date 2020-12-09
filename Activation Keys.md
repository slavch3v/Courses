using System;

namespace _ ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Contains")
                {
                    if (activationKey.Contains(tokens[1]))
                    {
                        Console.WriteLine($"{activationKey} contains {tokens[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (tokens[0] == "Flip")
                {
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);

                    string firstPart = activationKey.Substring(0, startIndex);
                    string secondPart = activationKey.Substring(startIndex, endIndex - startIndex);
                    string thirdPart = activationKey.Substring(endIndex);

                    if (tokens[1] == "Upper")
                    {
                        secondPart = secondPart.ToUpper();
                    }
                    else
                    {
                        secondPart = secondPart.ToLower();
                      
                    }
                    activationKey = firstPart + secondPart + thirdPart;
                    Console.WriteLine(activationKey);
                }
                else if (tokens[0] == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                   activationKey =  activationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(activationKey);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
