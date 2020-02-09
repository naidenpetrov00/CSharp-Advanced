namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cat
        : Animals
    {

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Meow()
        {
            Console.WriteLine("Meeooow");
        }
    }
}
