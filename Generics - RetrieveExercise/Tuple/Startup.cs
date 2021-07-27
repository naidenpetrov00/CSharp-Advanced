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

            var drunk = false;

            if (nameBeerCapacity[2] == "drunk")
            {
                drunk = true;
            }

            var tupleOne = new Tuple<string, string, string>
                (String.Join(" ", nameAdress[0], nameAdress[1])
                , nameAdress[2]
                , String.Join(" ", nameAdress.Skip(3)));

            var tupleTwo = new Tuple<string, int, bool>(nameBeerCapacity[0], int.Parse(nameBeerCapacity[1]), drunk);

            var tupleThree = new Tuple<string, double, string>(integerDouble[0], double.Parse(integerDouble[1]), integerDouble[2]);


            Printer(tupleOne, tupleTwo, tupleThree);
        }

        public static void Printer(Tuple<string, string, string> tupleOne, Tuple<string, int, bool> tupleTwo, Tuple<string, double, string> tupleThree)
        {
            Console.WriteLine(tupleOne.ToString());
            Console.WriteLine(tupleTwo.ToString());
            Console.WriteLine(tupleThree.ToString());
        }
    }
}
