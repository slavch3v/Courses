using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"\@\#{1,}([A-Z][A-Za-z0-9]{4,}[A-Z])\@\#{1,}";
            string numPatterm = @"(\d+)";
            var regex = new Regex(pattern);
            var regexNum = new Regex(numPatterm);
            string  trim = "@#";
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                var matched = regex.Match(command);

                if (matched.Success)
                {
                   string barcodes =  matched.Value.Replace(trim , "");

                    var matchednum = regexNum.Matches(barcodes);


                    if (matchednum.Count > 0)
                    {
                        string global = "";

                        foreach (Match item in matchednum)
                        {
                              global += item.Groups[1];
                        }

                        Console.WriteLine($"Product group: {global}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }

                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

           

        }
    }
}
