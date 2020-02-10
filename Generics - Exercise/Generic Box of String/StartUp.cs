namespace _01.GenericBoxofString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < num; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Box<int> box = new Box<int>(list);

            var swapNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swaper(swapNums[0], swapNums[1]);

            box.ToString();
        }
    }
}
