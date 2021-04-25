namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            while (command != "End")
            {
                Create(command);
            }
        }

        public static void Create(string command)
        {
            var input = command
                .Split(new string[] { "Create", " "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


        }
    }
}
