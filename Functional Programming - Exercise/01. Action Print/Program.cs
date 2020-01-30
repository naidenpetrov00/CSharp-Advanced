using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine(n); ;

            var names = Console.ReadLine()
                .Split()
                .ToList();

            foreach (var item in names)
            {
                printer(item);
            }
        }
    }
}
