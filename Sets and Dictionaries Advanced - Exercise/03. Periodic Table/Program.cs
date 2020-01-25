using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var uniqueElements = new SortedSet<string>();
            var chemicalCompounds = new string[] { };

            for (int i = 0; i < num; i++)
            {
                chemicalCompounds = Console.ReadLine().Split().ToArray();

                foreach (var item in chemicalCompounds)
                {
                    uniqueElements.Add(item);
                }
            }

            Console.WriteLine($"{string.Join(" ", uniqueElements)}");
        }
    }
}
