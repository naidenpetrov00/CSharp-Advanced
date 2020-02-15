namespace _1.DatingApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] AllMales = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] AllFemales = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var males = StackAdder(AllMales);
            var females = QueueAdder(AllFemales);

            var matchesCount = 0;

            while (!EmptyStackChecker(males, females))
            {
                if (StackPeekBiggerThenZero(males) && QueuePeekBiggerThenZero(females))
                {
                    if (males.Peek() % 25 == 0 || females.Peek() % 25 == 0)
                    {
                        if (males.Peek() % 25 == 0)
                        {
                            males.Pop();
                            if (EmptyStackChecker(males, females)) { break; }

                            males.Pop();
                            if (EmptyStackChecker(males, females)) { break; }
                        }
                        if (females.Peek() % 25 == 0)
                        {
                            females.Dequeue();
                            if (EmptyStackChecker(males, females)) { break; }

                            females.Dequeue();
                            if (EmptyStackChecker(males, females)) { break; }
                        }
                        continue;
                    }
                }
                if (!StackPeekBiggerThenZero(males) || !QueuePeekBiggerThenZero(females))
                {
                    if (!StackPeekBiggerThenZero(males))
                    {
                        males.Pop();
                    }
                    if (!QueuePeekBiggerThenZero(females))
                    {
                        females.Dequeue();
                    }

                    continue;
                }

                if (males.Peek() == females.Peek())
                {
                    matchesCount++;

                    males.Pop();
                    females.Dequeue();

                    if (EmptyStackChecker(males, females)) { break; }
                }
                else
                {
                    females.Dequeue();


                    int num = males.Pop();
                    num -= 2;
                    males.Push(num);
                }
            }

            StringBuilder output = new StringBuilder();

            output.AppendLine($"Matches: {matchesCount}");

            if (males.Count == 0)
            {
                output.AppendLine("Males left: none");
            }
            else
            {
                output.AppendLine($"Males left: {string.Join(", ", males)}");
            }

            if (females.Count == 0)
            {
                output.AppendLine("Females left: none");
            }
            else
            {
                output.AppendLine($"Females left: {string.Join(", ", females)}");
            }

            Console.WriteLine(output);
        }
        static Stack<int> StackAdder(int[] males)
        {
            var stack = new Stack<int>();

            foreach (var male in males)
            {
                stack.Push(male);
            }

            return stack;
        }

        static Queue<int> QueueAdder(int[] females)
        {
            var queue = new Queue<int>();

            foreach (var female in females)
            {
                queue.Enqueue(female);
            }

            return queue;
        }

        static bool EmptyStackChecker(Stack<int> males, Queue<int> females)
        {
            if (males.Count == 0 || females.Count == 0)
            {
                return true;
            }

            return false;
        }

        static bool StackPeekBiggerThenZero(Stack<int> stack)
        {
            if (stack.Peek() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool QueuePeekBiggerThenZero(Queue<int> queue)
        {
            if (queue.Peek() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
