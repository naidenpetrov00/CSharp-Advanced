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
            //var line = Console.ReadLine()
            //    .Split(" ")
            //    .Reverse()
            //    .ToArray();
            var line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var reservation = StackAdder(line);
            var openHalls = new Queue();

            var halls = new Dictionary<string, List<int>>();
            var hall = string.Empty;
            var resCount = reservation.Count;

            for (int i = 0; i < resCount; i++)
            {
                var resInfo = reservation.Pop().ToString();

                if (halls.Count == 0)
                {
                    continue;
                }

                if (int.TryParse(resInfo, out int number))
                {
                    if (PlaceChecker(halls, openHalls, number, hallsMaximumCapacity))
                    {

                    }
                }
                else if (resInfo != null)
                {
                    halls.Add(resInfo, new List<int>());
                    openHalls.Enqueue(resInfo);
                }
            }
        }

        private static Stack StackAdder(string[] input)
        {
            var stack = new Stack();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            return stack;
        }

        private static bool PlaceChecker(Dictionary<string, List<int>> halls, Queue openHals, int number, int maxCapcity)
        {
            var capacity = 0;

            foreach (var item in halls[openHals.Peek().ToString()])
            {
                capacity += item;
            }

            if (capacity + number > maxCapcity)
            {
                return false;
            }

            return true;
        }
    }
}
