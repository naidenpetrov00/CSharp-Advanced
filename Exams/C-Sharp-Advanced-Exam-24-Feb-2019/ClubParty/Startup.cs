namespace ClubParty
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            var hallsMaximumCapacity = int.Parse(Console.ReadLine());
            var line = Console.ReadLine()
                .Split(" ")
                .Reverse()
                .ToArray();

            var halls = new Dictionary<string, List<int>>();
            var hall = string.Empty;

            for (int i = 0; i < line.Length; i++)
            {

                if (int.TryParse(line[i], out int number) && halls.Count() > 0)
                {
                    halls.
                }
            }
        }

        static Stack StackAdder(string[] input)
        {
            var stack = new Stack();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            return stack;
        }
    }
}
