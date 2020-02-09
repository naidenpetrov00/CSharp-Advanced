namespace GenericScale
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equality = new EqualityScale<int>(4, 4);

            Console.WriteLine(equality.AreEqual());
        }
    }
}
