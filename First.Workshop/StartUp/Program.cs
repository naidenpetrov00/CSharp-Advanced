namespace CustomDataStructures
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            ListTester();

            StackTester();
        }

        static void ListTester()
        {
            MyList list = new MyList();

            list.Add(4);
            list.Add(10);
            list.Add(15);
            list.Add(3);
            list.Add(1);

            list[1] = 2;

            list.RemoveAt(2);

            list.Swap(0, 3);

            var kur = list.Count;
            Console.WriteLine(kur);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine(list.Contains(7));
        }

        static void StackTester()
        {
            MyStack stack = new MyStack();

            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(10);

            stack.Pop();

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Count);

            stack.ForEach(n => Console.WriteLine(n / 2));
        }
    }
}
