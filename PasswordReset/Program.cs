using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            string concate = string.Empty;
            var sb = new StringBuilder();

            while (command != "Done")
            {
                string[] full = command.Split();
                string action = full[0];

                if (action == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 == 1 && i != 0)
                        {
                            concate += password[i];
                        }
                    }
                    password = concate;
                    Console.WriteLine(password);

                    // icecream::hot::summer
                }
                else if (action == "Cut")
                {

                    int index = int.Parse(full[1]);
                    int lenght = int.Parse(full[2]);

                    int test = index + lenght;
                    if (test <= password.Length)
                    {
                        string substring = password.Substring(index, lenght);
                        int indes1 = password.IndexOf(substring);
                        password = password.Remove(indes1, substring.Length);


                        Console.WriteLine(password);
                    }

                }
                else if (action == "Substitute")
                {
                    string substring = full[1];
                    string substitute = full[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
