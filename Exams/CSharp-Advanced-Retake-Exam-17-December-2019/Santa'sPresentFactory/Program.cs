namespace SantasPresentFactory
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        private static Dictionary<int, string> toysTable = new Dictionary<int, string>
        {
            { 150, "Doll"},
            {250, "Wooden train"},
            {300, "Teddy bear"},
            {400, "Bicycle"}
        };

        static void Main(string[] args)
        {
            var boxesValue = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var magicValue = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> boxes = new Stack<int>();
            Queue<int> magic = new Queue<int>();

            boxes = StackAdder(boxesValue);
            magic = QueueAdder(magicValue);

            int totalMagicLevel = 0;
            int result = 0;

            var craftedPresents = new SortedDictionary<string, int>();

            while (boxes.Count != 0 || magic.Count != 0)
            {
                if (boxes.Count == 0 || magic.Count == 0)
                {
                    break;
                }
                totalMagicLevel = boxes.Peek() * magic.Peek();

                if (totalMagicLevel < 0)
                {
                    result = boxes.Peek() + magic.Peek();

                    boxes.Pop();
                    magic.Dequeue();

                    boxes.Push(result);
                }
                else if (boxes.Peek() == 0 || magic.Peek() == 0)
                {
                    if (boxes.Peek() == 0)
                    {
                        boxes.Pop();
                    }
                    if (magic.Peek() == 0)
                    {
                        magic.Dequeue();
                    }
                }
                else if (totalMagicLevel > 0)
                {
                    if (toysTable.ContainsKey(totalMagicLevel))
                    {
                        if (!craftedPresents.ContainsKey(toysTable[totalMagicLevel]))
                        {
                            craftedPresents.Add(toysTable[totalMagicLevel], 1);
                        }
                        else
                        {
                            craftedPresents[toysTable[totalMagicLevel]]++;
                        }

                        boxes.Pop();
                        magic.Dequeue();
                    }
                    else
                    {
                        result = boxes.Pop() + 15;

                        magic.Dequeue();

                        boxes.Push(result);
                    }
                }
            }

            var output = new StringBuilder();

            if ((craftedPresents.ContainsKey("Doll")) && (craftedPresents.ContainsKey("Wooden train"))
                || (craftedPresents.ContainsKey("Teddy bear")) && (craftedPresents.ContainsKey("Bicycle")))
            {
                output.AppendLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                output.AppendLine("No presents this Christmas!");
            }

            if (boxes.Count > 0)
            {
                output.AppendLine($"Materials left: {string.Join(", ", boxes)}");
            }
            if (magic.Count() > 0)
            {
                output.AppendLine($"Magic left: {string.Join(", ", magic)}");
            }

            foreach (var toy in craftedPresents)
            {
                output.AppendLine($"{toy.Key}: {toy.Value}");
            }

            Console.WriteLine(output);
        }

        static Stack<int> StackAdder(int[] boxesValue)
        {
            var boxes = new Stack<int>();

            foreach (var box in boxesValue)
            {
                boxes.Push(box);
            }

            return boxes;
        }

        static Queue<int> QueueAdder(int[] magicValue)
        {
            var magic = new Queue<int>();

            foreach (var item in magicValue)
            {
                magic.Enqueue(item);
            }

            return magic;
        }
    }
}
