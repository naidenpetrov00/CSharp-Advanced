namespace TheBattleoftheFiveArmies
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var armyArmor = int.Parse(Console.ReadLine());
            var numberOfRows = int.Parse(Console.ReadLine());

            char[,] world = MatrixCreator(numberOfRows);

            var command = new string[] { };


            while (true)
            {
                 command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            }


        }

        private static char[,] MatrixCreator(int numberOfRows)
        {
            char[,] world = new char[numberOfRows, numberOfRows];
            var rows = new char[numberOfRows];

            for (int i = 0; i < numberOfRows; i++)
            {
                rows = Console.ReadLine().ToCharArray();

                for (int k = 0; k < numberOfRows; k++)
                {
                    world[i, k] = rows[k];
                }
            }

            return world;
        }
    }
}
