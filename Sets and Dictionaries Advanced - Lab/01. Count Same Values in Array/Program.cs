using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

           var occurrences = new Dictionary<double, int>();

            foreach (var item in nums)
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

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
