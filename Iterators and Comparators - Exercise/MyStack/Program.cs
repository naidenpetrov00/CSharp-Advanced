namespace Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            string[] Command = new string[] { };
            int[] values = new int[] { };

            Stack<int> stack = new Stack<int>();

            while (command != "END")
            {
                Command = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                command = Command[0];

                values = Command
                    .Skip(1)
                    .Select(int.Parse)
                    .ToArray();

                if (command == "Push")
                {
                    stack.Push(values);
                }
                else if (command == "Pop")
                {
                    if (stack.EmptyStackCheck())
                    {
                        Console.WriteLine("No elements");
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                else if (command == "END")
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
