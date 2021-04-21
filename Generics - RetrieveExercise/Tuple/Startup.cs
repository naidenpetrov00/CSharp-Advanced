namespace Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            var nameAdress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var nameBeerCapacity = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var integerDouble = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var integerInput = int.Parse(integerDouble[0]);
            var doubleInput = double.Parse(integerDouble[1]);

            var tupleOne = new MyTuple<>(nameAdress[0], nameAdress[1]);
        }
    }
}
