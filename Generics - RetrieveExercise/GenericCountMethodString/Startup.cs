namespace GenericCountMethodString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                boxes.Add(new Box<string>(Console.ReadLine()));

            }

            var elementForComparison = Console.ReadLine();

            Console.WriteLine(Comparer(boxes, elementForComparison));
        }

        static int Comparer<T>(List<T> boxes, string elementForComparison)
        {
            var count = 0;

            if (boxes is List<Box<string>> castedBox)
            {
                var boxWithElementForComparison = new Box<string>(elementForComparison);

                castedBox.Add(boxWithElementForComparison);
                
                castedBox.OrderBy(i => i.Value);

                var position = castedBox.LastIndexOf(boxWithElementForComparison);

                count = castedBox.Count - --position;
            }

            return count;
        }
    }
}
