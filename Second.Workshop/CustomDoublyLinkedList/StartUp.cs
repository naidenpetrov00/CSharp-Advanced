namespace CustomDoublyLinkedList
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            MyDoublyLinkedList list = new MyDoublyLinkedList();

            list.AddFirst(1);
            list.AddFirst(3);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(3);

            list.RemoveFirst();
            list.RemoveLast();

            list.ForEach(n => Console.WriteLine($".{n}."));

            int[] array = list.ToArray();

            Console.Write($"Array -> {string.Join(" ", array)}");
        }
    }
}
