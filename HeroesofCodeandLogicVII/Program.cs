using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> heros = new Dictionary<string, List<int>>();
            // var sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            int maxHp = 100;
            int maxMp = 200;

            for (int i = 0; i < n; i++)
            {
                string[] full = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = full[0];
                int hp = int.Parse(full[1]);
                int mp = int.Parse(full[2]);

                if (!heros.ContainsKey(name))
                {
                    heros.Add(name, new List<int> { hp, mp });
                }
                else
                {
                    heros[name][0] += hp;
                    heros[name][1] += mp;
                }

            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] array = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = array[0];

                string heroName = array[1];

                if (action == "CastSpell")
                {

                    if (heros.ContainsKey(heroName))
                    {
                        int mana = int.Parse(array[2]);
                        string speelHero = array[3];

                        // heros[heroName][1] -= mana;


                        if (heros[heroName][1] >= mana)
                        {
                            heros[heroName][1] -= mana;


                            Console.WriteLine($"{heroName} has successfully cast {speelHero} and now has {heros[heroName][1]} MP!");

                        }
                        else

                        {


                            Console.WriteLine($"{heroName} does not have enough MP to cast {speelHero}!");

                        }



                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(array[2]);
                    string atackerHero = array[3];

                    if (heros.ContainsKey(heroName))
                    {
                        heros[heroName][0] -= damage;


                        if (heros[heroName][0] >= 0 && heros[heroName][0] <= 100)
                        {
                            // heros[heroName][0] = -damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {atackerHero} and now has {heros[heroName][0]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {atackerHero}!");
                            heros[heroName][0] = 0;
                            heros.Remove(heroName);
                        }


                    }

                }
                else if (action == "Recharge")
                {
                    int amountMana = int.Parse(array[2]);

                    if (heros.ContainsKey(heroName))
                    {
                        int result = maxMp - heros[heroName][1];
                        heros[heroName][1] += amountMana;

                        if (heros[heroName][1] >= maxMp)
                        {

                            heros[heroName][1] = maxMp;

                            Console.WriteLine($"{heroName} recharged for {result} MP!");
                        }
                        else
                        {

                            Console.WriteLine($"{heroName} recharged for {amountMana} MP!");
                        }

                    }
                }
                else if (action == "Heal")
                {
                    int amountPower = int.Parse(array[2]);
                         

                    if (heros.ContainsKey(heroName))
                    {
                        int result = maxHp - heros[heroName][0];
                        // double result2 = maxHp - result;

                        heros[heroName][0] += amountPower;

                        if (heros[heroName][0] >= maxHp)
                        {

                            heros[heroName][0] = maxHp;

                            Console.WriteLine($"{heroName} healed for {result } HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} healed for {amountPower} HP!");
                        }

                    }
                }


                command = Console.ReadLine();
            }



            foreach (var item in heros.OrderByDescending(x => x.Value[0]).ThenBy(a => a.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value[0]}{Environment.NewLine}  MP: {item.Value[1]}");

            }

        }
    }
}
