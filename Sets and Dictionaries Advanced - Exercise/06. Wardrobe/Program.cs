using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            var clothes = new string[] { };

            for (int i = 0; i < num; i++)
            {
                clothes = Console.ReadLine()
                    .Split(new string[] { " -> ", ","}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!wardrobe.ContainsKey(clothes[0]))
                {
                    wardrobe.Add(clothes[0], new Dictionary<string, int>());

                    for (int clothesIndex = 1; clothesIndex < clothes.Length; clothesIndex++)
                    {
                        if (!wardrobe[clothes[0]].ContainsKey(clothes[clothesIndex]))
                        {
                            wardrobe[clothes[0]].Add(clothes[clothesIndex], 1);
                        }
                        else
                        {
                            wardrobe[clothes[0]][clothes[clothesIndex]]++;
                        }
                    }
                }
                else
                {
                    for (int k = 1; k < clothes.Length; k++)
                    {
                        if (!wardrobe[clothes[0]].ContainsKey(clothes[k]))
                        {
                            wardrobe[clothes[0]].Add(clothes[k], 1);
                        }
                        else
                        {
                            wardrobe[clothes[0]][clothes[k]]++;
                        }
                    }
                }
            }

            var clotheSearchingFor = Console.ReadLine().Split(' ').ToArray();
            bool colorCoincidence = false;

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothe in color.Value)
                {
                    if (color.Key == clotheSearchingFor[0] && clothe.Key == clotheSearchingFor[1])
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");

                    }
                }
            }
        }
    }
}
