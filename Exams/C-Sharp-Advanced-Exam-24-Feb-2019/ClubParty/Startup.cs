namespace ClubParty
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        static void Main(string[] args)
        {
            var hallsMaximumCapacity = int.Parse(Console.ReadLine());
            var line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var reservation = StackAdder(line);
            var openHalls = new Queue();

            var halls = new Dictionary<string, List<int>>();
            var resCount = reservation.Count;

            for (int i = 0; i < resCount; i++)
            {
                var resInfo = reservation.Pop().ToString();

                if (int.TryParse(resInfo, out int currReservation) && openHalls.Count != 0)
                {
                    if (PlaceChecker(halls, openHalls, currReservation, hallsMaximumCapacity))
                    {
                        halls[openHalls.Peek().ToString()].Add(currReservation);
                    }
                    else
                    {
                        Console.WriteLine(ClosedReservationPrinter(halls, openHalls));

                        if (openHalls.Count != 0)
                        {
                            halls[openHalls.Peek().ToString()].Add(currReservation);
                        }
                    }
                }
                else if (!int.TryParse(resInfo, out int number))
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

        private static bool PlaceChecker(Dictionary<string, List<int>> halls, Queue openHals, int currReservation, int maxCapcity)
        {
            var capacity = 0;

            foreach (var reservations in halls[openHals.Peek().ToString()])
            {
                capacity += reservations;
            }

            if (capacity + currReservation > maxCapcity)
            {
                return false;
            }

            return true;
        }

        private static string ClosedReservationPrinter(Dictionary<string, List<int>> halls, Queue openHalls)
        {
            var sb = new StringBuilder();
            var closedRezervation = openHalls.Dequeue().ToString();

            sb.Append(string.Format("{0} -> {1}", closedRezervation, string.Join(", ", halls[closedRezervation])));

            return sb.ToString().Trim();
        }
    }
}
