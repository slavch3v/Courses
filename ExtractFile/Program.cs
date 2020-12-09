using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(@"\");

             string lastFile = array[array.Length - 1];
            string[] lastAraay = lastFile.Split(".");

            string firstWord = lastAraay[0];

            string secondWord = lastAraay[1];

            Console.WriteLine($"File name: {firstWord}");
            Console.WriteLine($"File extension: { secondWord} ");
        }
    }
}
