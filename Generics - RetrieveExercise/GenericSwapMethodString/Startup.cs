namespace GenericSwapMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Strartup
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var boxes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                boxes.Add(Console.ReadLine());
            }

            var swapCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Swapper(boxes, swapCommand);
        }

        static void Swapper<T>(List<T> boxes, int[] swapCommand)
        {
            var indexOne = swapCommand[0];
            var indexTwo = swapCommand[1];

            var valueAtOne = boxes[indexOne];
            boxes[indexOne] = boxes[indexTwo];
            boxes[indexTwo] = valueAtOne;

            boxes.ForEach(i => Console.WriteLine($"{i.GetType()}: {i}"));
        }
    }
}
