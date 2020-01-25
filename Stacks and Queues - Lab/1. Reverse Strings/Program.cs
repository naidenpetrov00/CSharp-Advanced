using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            for (int i = 0; i < stack.Count || stack.Any(); i++) 
            {
                Console.Write($"{stack.Pop()}");
            }
        }
    }
}
