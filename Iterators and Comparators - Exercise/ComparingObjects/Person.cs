namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;
        private List<Person> persons;

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Town
        {
            get { return this.town; }
            set { this.town = value; }
        }

        public void Add(Person person)
        {
            this.persons.Add(person);
        }

        public int CompareTo(Person other)
        {
            var result = other.name.CompareTo(this.Name);
            if (result == 0)
            {
                result = other.age.CompareTo(this.Age);
                if (result == 0)
                {
                    result = other.town.CompareTo(this.Town);

                    return result;
                }

                return result;
            }

            return result;
        }
    }
}
