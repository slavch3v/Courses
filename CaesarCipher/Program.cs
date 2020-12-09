using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            // string result = string.Empty;

            foreach (char ch in command)
            {
                int last = (int)ch + 3;
                char word   = (char)last;
                Console.Write(word);

            }
        }
    }
}
