namespace ConsoleApp1
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Ivana", 5);
            Dog dog = new Dog("Gosho", 3);

            Console.WriteLine($"Cat" +
                $"\nName: {cat.Name}" +
                $"\nAge: {cat.Age}");

            cat.Meow();

            Console.WriteLine($"Dog" +
                $"\nName: {dog.Name}" +
                $"\nAge: {dog.Age}");

            dog.Bark();
        }
    }
}
