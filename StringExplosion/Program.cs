using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // abv > 1 > 1 > 2 > 2asdasd

            string input = Console.ReadLine();
            int bomb = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var currcharacter = input[i];

                if (currcharacter == '>')
                {
                    bomb += int.Parse(input[i + 1].ToString());
                    continue;

                }

                if (bomb > 0)
                {
                    input = input.Remove(i, 1);
                    bomb--;
                    i--;
                }
            }

          

            Console.WriteLine(input);

        }
    }
}
