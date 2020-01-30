using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();

            var output = new List<int>();

            Predicate<int> oddOrEven = n => Sorter(n, command);

            for (int i = range[0]; i <= range[1]; i++)
            {
                output.Add(i);
            }
            output.Where(n => oddOrEven(n)).ToList().ForEach(n => Console.Write($"{n} "));
        }
        static bool Sorter(int num, string command)
        {
            switch (command)
            {
                case "odd": return num % 2 != 0;
                case "even": return num % 2 == 0;
                default: return false;
            }
    }
}
}
