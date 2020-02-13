namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var personData = new string[] { };
            var command = string.Empty;

            List<Person> persons = new List<Person>();

            while (command != "END")
            {
                personData = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                command = personData[0];
                if (command == "END") { break; }

                Person person = new Person(personData[0]
                    , int.Parse(personData[1])
                    , personData[2]);

                persons.Add(person);
            }

            var personToCompare = int.Parse(Console.ReadLine());

            var countOfMatches = 0;
            var numNotEqual = 0;

            for (int i = 0; i < persons.Count; i++)
            {
                var result = persons[personToCompare - 1].CompareTo(persons[i]);

                if (result == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    numNotEqual++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {numNotEqual} {persons.Count}");
            }
        }
    }
}
