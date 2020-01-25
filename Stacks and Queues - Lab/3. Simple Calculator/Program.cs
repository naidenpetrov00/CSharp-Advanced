using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var stack = new Stack<string>(input.Reverse());

            int firstDig = 0;
            int secondDig = 0;
            char xperator;
            while (stack.Count > 1)
            {
                firstDig = int.Parse(stack.Pop());
                xperator = char.Parse(stack.Pop());
                secondDig = int.Parse(stack.Pop());

                switch (xperator)
                {
                    case '+':
                        stack.Push((firstDig + secondDig).ToString());
                        break;
                    case '-':
                        stack.Push((firstDig - secondDig).ToString());
                        break;
                }
            }

            Console.WriteLine($"{stack.Pop()}");
        }
    }
}
