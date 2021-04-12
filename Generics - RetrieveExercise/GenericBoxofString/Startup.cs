namespace GenericBoxofString
{
    using System;

    public class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var actualString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                actualString = Console.ReadLine();

                var box = new Box<string>(actualString);

                box.ToString();
            }
        }
    }
}
