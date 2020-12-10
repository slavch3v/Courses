using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            Dictionary<string, List<int>> output = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] fullcityesAndPopulatianAndGold = input.Split("||");
                string city = fullcityesAndPopulatianAndGold[0];
                int population = int.Parse(fullcityesAndPopulatianAndGold[1]);
                int gold = int.Parse(fullcityesAndPopulatianAndGold[2]);

                if (!output.ContainsKey(city))
                {
                    output.Add(city, new List<int> { population, gold });
                }
                else
                {
                    output[city][0] += population;
                    output[city][1] += gold;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] full = input.Split("=>");

                string action = full[0];
                string town = full[1];
                if (action == "Plunder")
                {


                    int people = int.Parse(full[2]);
                    int zlato = int.Parse(full[3]);

                    if (output.ContainsKey(town))
                    {
                        output[town][0] -= people;
                        output[town][1] -= zlato;

                        sb.AppendLine($"{town} plundered! {zlato} gold stolen, {people} citizens killed.");


                        if (output[town][0] <= 0 || output[town][1] <= 0)
                        {
                            output.Remove(town);

                            sb.AppendLine($"{town} has been wiped off the map!");
                        }



                    }

                }

                else if (action == "Prosper")
                {

                    int gold = int.Parse(full[2]);

                    if (output.ContainsKey(town))
                    {
                        if (gold > 0)
                        {
                            output[town][1] += gold;
                            sb.AppendLine($"{gold} gold added to the city treasury. {town} now has { output[town][1]} gold.");


                        }
                        else
                        {
                            sb.AppendLine("Gold added cannot be a negative number!");


                        }


                    }
                }
                input = Console.ReadLine();
            }


            if (output.Count > 0)
            {
                sb.AppendLine($"Ahoy, Captain! There are {output.Count} wealthy settlements to go to:");

                foreach (var item in output.OrderByDescending(x => x.Value[1]).ThenBy(y => y.Key))
                {
                    sb.AppendLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
                Console.WriteLine(sb.ToString());
            }



        }
    }
}
