namespace TrojanInvasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfWaves = int.Parse(Console.ReadLine());

            var platesRepresenter = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();
            var warriorsRepresenter = new List<int>();

            var plates = new Queue<int>();
            var warriorsWaves = new Stack<int>();

            var platesLefted = new List<int>();
            var warriorsLefted = new List<int>();

            var warriorPower = 0;
            var platePower = 0;

            QueueAdder(plates, platesRepresenter);
            for (int i = 1; i <= numOfWaves; i++)
            {
                warriorsRepresenter = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                if (plates.Count() > 0)
                {
                    platePower = plates.Peek();
                }
                else { break; }

                StackAdder(warriorsWaves, warriorsRepresenter);

                while (warriorsWaves.Count() > 0)
                {

                    if (warriorsWaves.Peek() > platePower)
                    {
                        warriorPower = warriorsWaves.Pop();

                        warriorsWaves.Push(warriorPower - platePower);
                        plates.Dequeue();
                        platePower = 0;

                        break;
                    }
                    else if (platePower > warriorsWaves.Peek())
                    {
                        platePower -= warriorsWaves.Pop();
                    }
                    else
                    {
                        plates.Dequeue();
                        warriorsWaves.Pop();
                        platePower = 0;

                        break;
                    }

                }

                if (warriorsWaves.Count() > 0)
                {
                    foreach (var warrior in warriorsWaves)
                    {
                        warriorsLefted.Add(warrior);
                    }
                }

                warriorsWaves.Clear();
            }
            if (plates.Count > 0)
            {
                foreach (var plate in plates)
                {
                    platesLefted.Add(plate);
                }
            }

            StringBuilder output = new StringBuilder();

            if (warriorsLefted.Count > 0)
            {
                output.AppendLine("The Trojans successfully destroyed the Spartan defense.");
                output.Append($"Warriors left: {string.Join(", ", warriorsLefted)}");
            }
            else if (platesLefted.Count > 0)
            {
                output.AppendLine("The Spartans successfully repulsed the Trojan attack.");
                output.Append($"Plates left: {string.Join(", ", platesLefted)}");
            }

            Console.WriteLine(output);
        }
        static Queue<int> QueueAdder(Queue<int> plates, List<int> platesRepresenter)
        {
            for (int i = 0; i < platesRepresenter.Count(); i++)
            {
                plates.Enqueue(platesRepresenter[i]);
            }

            return plates;
        }

        static Stack<int> StackAdder(Stack<int> warriorsWaves, List<int> warriorsRepresenter)
        {
            for (int i = 0; i < warriorsRepresenter.Count(); i++)
            {
                warriorsWaves.Push(warriorsRepresenter[i]);
            }

            return warriorsWaves;
        }
    }
}
