using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            var sb = new StringBuilder();

            for (int i = 0; i < array.Length - 1 ; i++)
            {
                if (array[i] != array[i + 1])
                {
                    sb.Append(array[i]);
                }
            }

            sb.Append(array[array.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
