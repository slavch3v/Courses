using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace mdaadada
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            Dictionary<string, List<int>> people = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "Results")
            {
                var cmdArg = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];
                var username = cmdArg[1];
                if (command == "Add")
                {
                    var helth = int.Parse(cmdArg[2]);
                    var energy = int.Parse(cmdArg[3]);
                    if (people.ContainsKey(username))
                    {
                        people[username][0] += helth;
                        if (people[username][0] > 100000)
                        {
                            people[username][0] = 100000;
                        }

                    }
                    else
                    {
                        people.Add(username, new List<int> { helth, energy });
                    }
                }
                else if (command == "Attack")
                {
                    var attackerName = username;
                    var defenderName = cmdArg[2];
                    var damage = int.Parse(cmdArg[3]);
                    if (people.ContainsKey(attackerName) && people.ContainsKey(defenderName))
                    {
                        people[defenderName][0] -= damage;
                        people[attackerName][1]--;
                        if (people[defenderName][0] <= 0)
                        {
                            sb.AppendLine($"{defenderName} was disqualified!");
                            people.Remove(defenderName);
                        }
                        if (people[attackerName][1] <= 0)
                        {
                            sb.AppendLine($"{attackerName} was disqualified!");
                            people.Remove(attackerName);
                        }
                    }
                }
                else if (command == "Delete")
                {

                    if (username == "All")
                    {
                        people.Clear();
                    }
                    else
                    {
                        people.Remove(username);
                    }
                }
                input = Console.ReadLine();
            }
            var count = people.Count;
            sb.AppendLine($"People count: {count}");
            foreach (var item in people.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                sb.AppendLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}