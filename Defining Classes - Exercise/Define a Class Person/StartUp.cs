namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person peoples = new Person();

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine()
                    .Split()
                    .ToArray();

                Person person = new Person(nameAge[0], int.Parse(nameAge[1]));

                peoples.AddPerson(person);
            }

            SortedDictionary<string, int> allPeoples = peoples.GetThePeoplesOverThirtySorted();

            foreach (var (key, value) in allPeoples)
            {
                Console.WriteLine($"{key} - {value}");
            }
        }
    }
}
