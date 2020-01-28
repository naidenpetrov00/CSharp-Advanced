using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = Console.ReadLine()
                 .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Where(num => num % 2 == 0)
                 .OrderBy(num => num)
                 .ToList();

            Console.WriteLine(string.Join(", ", result));   
        }
    }
}
