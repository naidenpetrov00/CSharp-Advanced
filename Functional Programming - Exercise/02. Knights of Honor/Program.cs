using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine($"Sir {n}"); ;

            Console.ReadLine()
                           .Split()
                           .ToList()
                           .ForEach(n => printer(n));
        }
    }
}
