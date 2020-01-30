using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static public int min = int.MaxValue;
        static void Main(string[] args)
        {
            Func<int, int> smallestNumPuller = n => SmallestNumber(n);

            Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .Select(n => smallestNumPuller(n))
                            .ToList();

            Console.WriteLine(min);
        }
        static int SmallestNumber(int num)
        {
            if (num < min)
            {
                min = num;
                return min;
            }
            else
            {
                return num;
            }
        }
    }
}
