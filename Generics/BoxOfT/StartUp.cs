namespace BoxOfT
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            box.Add("a");
            box.Add("b");
            box.Add("d");

            Console.WriteLine(box.Remove());

            box.Add("c");
            box.Add("e");

            Console.WriteLine(box.Remove());
        }
    }
}
