namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dog
        : Animals
    {

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Bark()
        {
            Console.WriteLine("Baaaall");
        }
    }
}
