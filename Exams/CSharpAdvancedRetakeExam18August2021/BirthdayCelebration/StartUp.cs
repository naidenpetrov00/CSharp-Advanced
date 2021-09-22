namespace BirthdayCelebration
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var questCapacityData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var preparedPlatesData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var questCapacity = new Queue();
            var preparedPlates = new Stack();

            var currQuest = 0;
            var currPlate = 0;
            var wastedFood = 0;

            foreach (var item in questCapacityData)
            {
                questCapacity.Enqueue(item);
            }
            foreach (var item in preparedPlatesData)
            {
                preparedPlates.Push(item);
            }

            while (true)
            {
                if (questCapacity.Count <= 0 || preparedPlates.Count <= 0)
                {
                    break;
                }

                currQuest = int.Parse(questCapacity.Peek().ToString());

                while (currQuest > 0)
                {
                    currPlate = int.Parse(preparedPlates.Peek().ToString());
                    currQuest -= currPlate;

                    if (currQuest <= 0)
                    {
                        wastedFood += Math.Abs(currQuest);
                        questCapacity.Dequeue();
                        preparedPlates.Pop();

                        break;
                    }
                    else
                    {
                        preparedPlates.Pop();
                    }
                }

            }

            if (questCapacity.Count <= 0)
            {

                foreach (var item in preparedPlates)
                {
                    //wastedFood += int.Parse(item.ToString());
                }
                Console.WriteLine($"Plates: {string.Join(" ", preparedPlates.ToArray())}");
            }
            else if (preparedPlates.Count <= 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", questCapacity.ToArray())}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
