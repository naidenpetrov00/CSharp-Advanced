namespace Helen_sAbduction
{
    using System;
    using System.Linq;

    public class Program
    {
        private static int energyParis;
        private static bool moved = true;
        private static bool parisDied = false;
        private static int[] parisDeadPosition = new int[2];
        private static bool parisFoundedHelen = false;

        static void Main(string[] args)
        {
            energyParis = int.Parse(Console.ReadLine());

            int numRows = int.Parse(Console.ReadLine());

            char[,] field = new char[numRows, default];

            var rows = new char[] { };

            var command = new string[] { };
            var moveCommand = string.Empty;
            var rowSpawn = 0;
            var colSpawn = 0;

            var parisPosition = new int[2];

            for (int i = 0; i < numRows; i++)
            {
                rows = Console.ReadLine().ToCharArray();

                field = MatrixAdder(field, rows, i);
            }

            while (true)
            {
                command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                moveCommand = command[0];
                rowSpawn = int.Parse(command[1]);
                colSpawn = int.Parse(command[2]);

                ParisPositionFinder(field, parisPosition);

                field = SpawnForEnemy(field, rowSpawn, colSpawn);

                field = ParisMoveTo(field, moveCommand, parisPosition);

                if (parisDied || parisFoundedHelen)
                {
                    break;
                }
            }

            if (parisDied)
            {
                Console.WriteLine($"Paris died at {parisDeadPosition[0]};{parisDeadPosition[1]}.");
            }
            else if (parisFoundedHelen)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energyParis}");
            }

            MatrixPrinter(field);
        }
        static char[,] MatrixAdder(char[,] field, char[] rows, int row)
        {
            if (row == 0)
            {
                field = new char[field.GetLength(0), rows.Length];
            }

            for (int i = 0; i < rows.Length; i++)
            {
                field[row, i] = rows[i];
            }

            return field;
        }

        static int[] ParisPositionFinder(char[,] field, int[] position)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    if (field[i, k] == 'P')
                    {
                        position[0] = i;
                        position[1] = k;

                        break;
                    }
                }
            }
            return position;
        }

        static char[,] SpawnForEnemy(char[,] field, int row, int col)
        {
            field[row, col] = 'S';

            return field;
        }

        static char[,] ParisMoveTo(char[,] field, string move, int[] position)
        {
            int row = position[0];
            int col = position[1];

            if (move == "up")
            {
                field = ParisMover(field, row - 1, col);
                if (moved)
                {
                    field[row, col] = '-';
                }
            }
            else if (move == "down")
            {
                field = ParisMover(field, row + 1, col);
                if (moved)
                {
                    field[row, col] = '-';
                }
            }
            else if (move == "left")
            {
                field = ParisMover(field, row, col - 1);
                if (moved)
                {
                    field[row, col] = '-';
                }
            }
            else if (move == "right")
            {
                field = ParisMover(field, row, col + 1);
                if (moved)
                {
                    field[row, col] = '-';
                }
            }

            return field;
        }

        static char[,] ParisMover(char[,] field, int row, int col)
        {
            energyParis--;

            if (row > field.GetLength(0) - 1 || row < 0
                || col > field.GetLength(1) - 1 || col < 0)
            {
                moved = false;

                return field;
            }
            else
            {
                moved = true;
                if (field[row, col] == 'S')
                {
                    field[row, col] = 'P';
                    energyParis -= 2;
                }
                if (energyParis <= 0)
                {
                    field[row, col] = 'X';

                    parisDied = true;
                    parisDeadPosition[0] = row;
                    parisDeadPosition[1] = col;
                }
                if (field[row, col] == '-')
                {
                    field[row, col] = 'P';
                }
                if (field[row, col] == 'H')
                {
                    field[row, col] = '-';

                    parisFoundedHelen = true;
                }


                return field;
            }
        }

        static void MatrixPrinter(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int k = 0; k < field.GetLength(1); k++)
                {
                    Console.Write(field[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
