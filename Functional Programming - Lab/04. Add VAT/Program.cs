using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(num => num * 1.2)
                .ToList()
                .ForEach(num => Console.WriteLine($"{num :F2}"));
        }
    }
}
