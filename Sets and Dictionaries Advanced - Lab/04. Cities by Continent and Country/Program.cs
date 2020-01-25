using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var Map = new Dictionary<string, Dictionary<string, List<string>>>();
            var place = new string[] { };

            var continent = string.Empty;
            var countrie = string.Empty;
            var cities = string.Empty;

            for (int i = 0; i < num; i++)
            {
                place = Console.ReadLine()
                    .Split()
                    .ToArray();

                continent = place[0];
                countrie = place[1];
                cities = place[2];

                if (!Map.ContainsKey(continent))
                {
                    Map.Add(continent, new Dictionary<string, List<string>>() { [countrie] = new List<string>() { cities} });
                }
                else
                {
                    if (!Map[continent].ContainsKey(countrie))
                    {
                        Map[continent].Add(countrie, new List<string>() { cities } );
                    }
                    else
                    {
                        Map[continent][countrie].Add(cities);
                    }
                }
            }

            foreach (var item in Map)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var countries in item.Value)
                {
                    Console.WriteLine($"{countries.Key} -> {string.Join(", ", countries.Value)}");
                }
            }
        }
    }
}
