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

            var tupleOne = new Tuple<string, string>(nameAdress[0], nameAdress[1]);
            var tupleTwo = new Tuple<string, int>(nameBeerCapacity[0], int.Parse(nameBeerCapacity[1]));
            var tupleThree = new Tuple<int, double>(int.Parse(integerDouble[0]), double.Parse(integerDouble[1]));

            Printer(tupleOne, tupleTwo, tupleThree);
        }

        public static void Printer(Tuple<string, string> tupleOne, Tuple<string, int> tupleTwo, Tuple<int, double> tupleThree)
        {
            Console.WriteLine(tupleOne.ToString());
            Console.WriteLine(tupleTwo.ToString());
            Console.WriteLine(tupleThree.ToString());
        }
    }
}
