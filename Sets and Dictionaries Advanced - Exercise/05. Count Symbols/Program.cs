using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()
                .ToCharArray();

            var occurrences = new Dictionary<char, int>();

            foreach (var item in text)
            {
                if (!occurrences.ContainsKey(item))
                {
                    occurrences.Add(item, 1);
                }
                else
                {
                    occurrences[item]++;
                }
            }

            occurrences = occurrences
                .OrderBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
