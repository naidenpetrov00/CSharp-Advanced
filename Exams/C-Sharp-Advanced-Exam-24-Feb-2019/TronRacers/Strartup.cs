namespace TronRacers
{
    using System;
    using System.Linq;

    public class Strartup
    {
        private const char FPlayerSymbol = 'f';
        private const char SPlayerSymbol = 's';
        private static int[] FPlayerPosition;
        private static int[] SPlayerPosition;

        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = MatrixAdder(size);

            var fPlayer = true;
            var sPlayer = true;
            var commands = new string[] { };
            var fCommand = string.Empty;
            var sCommand = string.Empty;

            while (fPlayer && sPlayer)
            {
                commands = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                fCommand = commands[0];
                sCommand = commands[1];


            }
        }

        static int[,] MatrixAdder(int size)
        {
            var matrix = new int[size, size];
            var values = new char[] { };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                values = Console.ReadLine().ToCharArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = values[k];
                }
            }

            return matrix;
        }

        static void PositionFinder(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] == FPlayerSymbol)
                    {
                        FPlayerPosition = new int[] { i, k };
                    }
                    if (matrix[i, k] == SPlayerSymbol)
                    {
                        SPlayerPosition = new int[] { i, k };
                    }
                }
            }
        }
    }
}
