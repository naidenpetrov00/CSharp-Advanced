namespace TronRacers
{
    using System;
    using System.Linq;

    public class Strartup
    {
        const char FPlayerTag= 'f';
        const char SPlayerTag= 's';
        static int[] FPlayerPosition;
        static int[] SPlayerPosition;
        static char[,] Field;

        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            Field = MatrixAdder(size);
            PositionFinder(FPlayerTag, Field).CopyTo(FPlayerPosition, 0);
            PositionFinder(SPlayerTag, Field).CopyTo(SPlayerPosition, 0);

            var fPlayerLive = true;
            var sPlayerLive = true;
            var commands = new string[] { };
            var fCommand = string.Empty;
            var sCommand = string.Empty;

            while (fPlayerLive && sPlayerLive)
            {
                commands = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                fCommand = commands[0];
                sCommand = commands[1];

                MoveSeparator(FPlayerTag, fCommand);


            }
        }

        static char[,] MatrixAdder(int size)
        {
            var matrix = new char[size, size];
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

        static void MoveSeparator(char player, string command)
        {
            switch (command)
            {
                case "up":
                    Mover(player, (x, y) => new int[2] { x++, y });
                    break;
                case "right":
                    break;
                case "left":
                    break;
                case "down":
                    break;
                default:
                    break;
            }
        }

        static void Mover(char player, Func<int, int, int[]> direction)
        {
            if (player == 'f')
            {
                var position = direction(FPlayerPosition[0], FPlayerPosition[1]);

                if (position[0] > Field.GetLength(0))
                {
                    Field[0, position[1]] = FPlayerTag;
                }
            }
            else if(player == 's')
            {

            }
        }

        static int[] PositionFinder(char player, char[,] field)
        {
            var position = new int[2];

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    if (field[i, k] == player)
                    {
                        position[0] = i;
                        position[1] = k;

                        break;
                    }
                }
            }

            return position;
        }
    }
}
