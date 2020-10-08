namespace TronRacers
{
    using System;
    using System.Linq;

    public class Strartup
    {
        const char FPlayerTag = 'f';
        const char SPlayerTag = 's';
        const char DeathPlayerTag = 'x';
        static int[] FPlayerPosition;
        static int[] SPlayerPosition;
        static bool AllPlayersAlive;
        static char[,] Field;

        public static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            Field = MatrixAdder(size);
            FPlayerPosition = PositionFinder(FPlayerTag, Field);
            SPlayerPosition = PositionFinder(SPlayerTag, Field);

            AllPlayersAlive = true;
            var commands = new string[] { };
            var fCommand = string.Empty;
            var sCommand = string.Empty;

            while (AllPlayersAlive)
            {
                commands = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                fCommand = commands[0];
                sCommand = commands[1];

                MoveSeparator(FPlayerTag, fCommand);
                if (!AllPlayersAlive) break;
                MoveSeparator(SPlayerTag, sCommand);
            }

            MatrixPrinter();
        }

        static void MatrixPrinter()
        {
            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int k = 0; k < Field.GetLength(1); k++)
                {
                    Console.Write(Field[i, k]);
                }
                Console.WriteLine();
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
                    Mover(player, (x, y) => new int[2] { --x, y });
                    break;
                case "right":
                    Mover(player, (x, y) => new int[2] { x, ++y });
                    break;
                case "left":
                    Mover(player, (x, y) => new int[2] { x, --y });
                    break;
                case "down":
                    Mover(player, (x, y) => new int[2] { ++x, y });
                    break;
                default:
                    break;
            }
        }

        static void Mover(char player, Func<int, int, int[]> direction)
        {
            var position = new int[2];
            if (player == FPlayerTag)
            {
                position = direction(FPlayerPosition[0], FPlayerPosition[1]);
                FPlayerPosition = position;
            }
            else if (player == SPlayerTag)
            {
                position = direction(SPlayerPosition[0], SPlayerPosition[1]);
                SPlayerPosition = position;
            }
            //nagore i izleze
            if (position[0] < 0)
            {
                if (EmptyPlaceChecker(Field[Field.GetLength(0) - 1, position[1]]))
                {
                    Field[Field.GetLength(0) - 1, position[1]] = player;
                    PositionMover(player, Field.GetLength(0) - 1, position[1]);
                }
                else
                {
                    Field[Field.GetLength(0) - 1, position[1]] = DeathPlayerTag;
                    AllPlayersAlive = false;
                }
            }
            //nadolu izleze
            else if (position[0] > Field.GetLength(0) - 1)
            {
                if (EmptyPlaceChecker(Field[0, position[1]]))
                {
                    Field[0, position[1]] = player;
                    PositionMover(player, 0, position[1]);
                }
                else
                {
                    Field[0, position[1]] = DeathPlayerTag;
                    AllPlayersAlive = false;
                }
            }
            //nadqsno izleze
            else if (position[1] > Field.GetLength(1) - 1)
            {
                if (EmptyPlaceChecker(Field[position[0], 0]))
                {
                    Field[position[0], 0] = player;
                    PositionMover(player, position[0], 0);
                }
                else
                {
                    Field[position[0], 0] = DeathPlayerTag;
                    AllPlayersAlive = false;
                }
            }
            //nalqvo izleze
            else if (position[1] < 0)
            {
                if (EmptyPlaceChecker(Field[position[0], Field.GetLength(1) - 1]))
                {
                    Field[position[0], Field.GetLength(1) - 1] = player;
                    PositionMover(player, position[0], Field.GetLength(1) - 1);
                }
                else
                {
                    Field[position[0], Field.GetLength(1) - 1] = DeathPlayerTag;
                    AllPlayersAlive = false;
                }
            }
            else
            {
                if (EmptyPlaceChecker(Field[position[0], position[1]]))
                {
                    Field[position[0], position[1]] = player;
                    PositionMover(player, position[0], position[1]);
                }
                else
                {
                    Field[position[0], position[1]] = DeathPlayerTag;
                    AllPlayersAlive = false;
                }
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

        static bool EmptyPlaceChecker(char symbol)
        {
            if (symbol == '*')
            {
                return true;
            }

            return false;
        }

        static void PositionMover(char player, params int[] position)
        {
            if (player == FPlayerTag)
            {
                FPlayerPosition = position;
            }
            else if (player == SPlayerTag)
            {
                SPlayerPosition = position;
            }
        }

    }
}