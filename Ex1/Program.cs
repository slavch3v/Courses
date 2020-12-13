using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string problem = Console.ReadLine();

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] full = commands.Split();
                string action = full[0];

                if (action == "Translate")
                {
                    char toReplace = char.Parse(full[1]);
                    char replacement = char.Parse(full[2]);

                    for (int i = 0; i < problem.Length; i++)
                    {
                        if (problem[i] == toReplace)
                        {
                          problem =   problem.Replace(toReplace, replacement);
                        }
                    }

                    Console.WriteLine(problem);
                }
                else if (action == "Includes")
                {
                    string checkString = full[1];

                    bool isValid = problem.Contains(checkString);
                    Console.WriteLine(isValid);
                }
                else if (action == "Start")
                {
                    string startWord = full[1];

                    bool isStart = problem.StartsWith(startWord);

                    Console.WriteLine(isStart);
                }
                else if (action == "Lowercase")
                {
                    problem = problem.ToLower();

                    Console.WriteLine(problem);
                }
                else if (action == "FindIndex")
                {
                    char find = char.Parse(full[1]);

                    int lastIndex = problem.LastIndexOf(find);

                    Console.WriteLine(lastIndex);
                }
                else if (action == "Remove")
                {
                    int startIndex = int.Parse(full[1]);
                    int count = int.Parse(full[2]);

                    problem = problem.Remove(startIndex, count);
                    Console.WriteLine(problem);
                }




                commands = Console.ReadLine();
            }

        }
    }
}
