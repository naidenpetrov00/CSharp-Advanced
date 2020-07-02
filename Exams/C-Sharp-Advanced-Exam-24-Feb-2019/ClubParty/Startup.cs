namespace ClubParty
{
    using System;
    using System.Collections;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            var hallsMaximumCapacity = int.Parse(Console.ReadLine());
            var questsCode = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var halls = new Stack();
            var people = new Stack();

            foreach (var item in questsCode)
            {
                if (item.GetType() == )
                {

                }
            }
        }
    }
}
