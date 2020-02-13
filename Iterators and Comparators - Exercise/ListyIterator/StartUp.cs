namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] create = Console.ReadLine()
                .Split()
                .ToArray();
            var command = string.Empty;

            ListyIterator<string> list = new ListyIterator<string>(create);

            while (command != "END")
            {
                command = Console.ReadLine();
                if (command == "END") { break; }

                if (command == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (command == "Print")
                {
                    list.Print();
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in list)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
