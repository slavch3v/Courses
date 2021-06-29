using System;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var jagged = new char[lines][];
            var MyTokens = 0;
            var OpponentedTokens = 0;

            for (int i = 0; i < lines; i++)
            {
                var tokenArgs = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                jagged[i] = new char[tokenArgs.Count];

                for (int j = 0; j < tokenArgs.Count; j++)
                {
                    jagged[i][j] = tokenArgs[j].First();
                }
            }

            var command = Console.ReadLine();

            while (command != "Gong")
            {
                var commandArgs = command
                    .Split(' ')
                    .ToList();

                var row = int.Parse(commandArgs[1]);
                var col = int.Parse(commandArgs[2]);

                if (commandArgs[0] == "Find")
                {
                    if (jagged.Length > row && row >= 0)
                    {
                        if (jagged[row].Length > col && col >= 0)
                        {
                            if (jagged[row][col] == 'T')
                            {
                                jagged[row][col] = '-';
                                MyTokens++;
                            }
                        }
                    }
                }
                else if (commandArgs[0] == "Opponent")
                {
                    var direction = commandArgs[3];
                    if (jagged.Length > row && row >= 0)
                    {
                        if (jagged[row].Length > col && col >= 0)
                        {
                            if (jagged[row][col] == 'T')
                            {
                                jagged[row][col] = '-';
                                OpponentedTokens++;
                            }

                            if (direction == "up")
                            {
                                while (--row >= 0)
                                {
                                    if (jagged[row].Length - 1 >= col)
                                    {
                                        if (jagged[row][col] == 'T')
                                        {
                                            jagged[row][col] = '-';
                                            OpponentedTokens++;
                                        }
                                    }
                                }
                            }
                            else if (direction == "down")
                            {
                                while (++row < jagged.Length)
                                {
                                    if (jagged[row].Length - 1 >= col)
                                    {
                                        if (jagged[row][col] == 'T')
                                        {
                                            jagged[row][col] = '-';
                                            OpponentedTokens++;
                                        }
                                    }
                                }
                            }
                            else if (direction == "left")
                            {
                                while (--col >= 0)
                                {
                                    if (jagged[row][col] == 'T')
                                    {
                                        jagged[row][col] = '-';
                                        OpponentedTokens++;
                                    }
                                }
                            }
                            else
                            {
                                while (++col < jagged[row].Length)
                                {
                                    if (jagged[row][col] == 'T')
                                    {
                                        jagged[row][col] = '-';
                                        OpponentedTokens++;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lines; i++)
            {
                var cols = jagged[i].Length;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Collected tokens: {MyTokens}");
            Console.WriteLine($"Opponent's tokens: {OpponentedTokens}");
        }
    }
}