namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Family
    {
        private List<Person> family = new List<Person>();

        public void AddMember(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            int max = int.MinValue;
            Person oldest = new Person();

            foreach (var person in family)
            {
                if (person.Age > max)
                    max = person.Age;
            }

            family = family.Where(age => age.Age == max).ToList();

            oldest.Name = family[0].Name;
            oldest.Age = family[0].Age;

            return oldest;
        }
    }
}
