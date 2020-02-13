namespace Froggy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var orderOfStones = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(orderOfStones);

            var printerer = new List<int>();

            foreach (var stone in lake)
            {
                printerer.Add(stone);
            }

            Console.WriteLine(string.Join(", ", printerer));
        }
    }
}
