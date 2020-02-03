namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;
        private List<Person> persons = new List<Person>();
        private SortedDictionary<string, int> peoplesOverThirty = new SortedDictionary<string, int>();

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                this.name = value; 
            }
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                this.age = value;
            }
        }

        public void AddPerson(Person person)
        {
            this.persons.Add(person);

            if (person.Age > 30)
            {
                peoplesOverThirty.Add(person.Name, person.Age);
            }
        }

        public SortedDictionary<string, int> GetThePeoplesOverThirtySorted()
        {
            return peoplesOverThirty;
        }
    }
}

