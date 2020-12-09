using System;
using System.Text;

namespace _5._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            string head = Console.ReadLine();
            string article = Console.ReadLine();

            string comments = Console.ReadLine(); 

            sb.Append($"<h1>{Environment.NewLine}    {head}{Environment.NewLine}</h1>{Environment.NewLine}");
            sb.Append($"<article>{Environment.NewLine}    {article}{Environment.NewLine}</article>{Environment.NewLine}");

            while (comments != "end of comments")
            {

                sb.Append($"<div>{Environment.NewLine}    {comments}{Environment.NewLine}</div>{Environment.NewLine}");

                comments = Console.ReadLine();
            }

            Console.WriteLine(sb);
        }
    }
}
