using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);

            var Command = new string[] { };
            var command = string.Empty;
            int removingCount = 0;
            int sum = input.Sum();

            while (command != "end")
            {
                Command = Console.ReadLine().Split().ToArray();
                command = Command[0].ToLower();

                if (command == "add")
                {
                    stack.Push(int.Parse(Command[1]));
                    stack.Push(int.Parse(Command[2]));

                    sum += int.Parse(Command[1]) + int.Parse(Command[2]);
                }
                else if (command == "remove")
                {
                    removingCount = int.Parse(Command[1]);

                    if (removingCount > stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < removingCount; i++)
                        {
                            sum -= stack.Peek();
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
