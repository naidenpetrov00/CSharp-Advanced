namespace _2.BookWorm
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var initialText = Console.ReadLine();

            var size = int.Parse(Console.ReadLine());

            char[,] field = MatrixAdder(size);

            var moveCommand = string.Empty;
            var position = PositionFinder(field);
            int rowP = position[0];
            int colP = position[1];

            while (moveCommand != "end")
            {
                moveCommand = Console.ReadLine();
                if (moveCommand == "end") { break; }

                if (moveCommand == "up")
                {
                    if (SizeValidation(size, rowP - 1, colP))
                    {
                        if (field[rowP - 1, colP] != '-')
                        {
                            initialText += field[rowP - 1, colP];

                            Mover(field, moveCommand, rowP, colP);
                            rowP -= 1;
                        }
                        else
                        {
                            Mover(field, moveCommand, rowP, colP);
                            rowP -= 1;
                        }
                    }
                    else
                    {
                        if (initialText.Length != 0)
                        {
                            initialText = initialText.Remove(initialText.Length - 1);
                        }
                    }
                }
                else if (moveCommand == "down")
                {
                    if (SizeValidation(size, rowP + 1, colP))
                    {
                        if (field[rowP + 1, colP] != '-')
                        {
                            initialText += field[rowP + 1, colP];

                            Mover(field, moveCommand, rowP, colP);
                            rowP += 1;
                        }
                        else
                        {
                            Mover(field, moveCommand, rowP, colP);
                            rowP += 1;
                        }
                    }
                    else
                    {
                        if (initialText.Length != 0)
                        {
                            initialText = initialText.Remove(initialText.Length - 1);
                        }
                    }
                }
                else if (moveCommand == "left")
                {
                    if (SizeValidation(size, rowP, colP - 1))
                    {
                        if (field[rowP, colP - 1] != '-')
                        {
                            initialText += field[rowP, colP - 1];

                            Mover(field, moveCommand, rowP, colP);
                            colP -= 1;
                        }
                        else
                        {
                            Mover(field, moveCommand, rowP, colP);
                            colP -= 1;
                        }
                    }
                    else
                    {
                        if (initialText.Length != 0)
                        {
                            initialText = initialText.Remove(initialText.Length - 1);
                        }
                    }
                }
                else if (moveCommand == "right")
                {
                    if (SizeValidation(size, rowP, colP + 1))
                    {
                        if (field[rowP, colP + 1] != '-')
                        {
                            initialText += field[rowP, colP + 1];

                            Mover(field, moveCommand, rowP, colP);
                            colP += 1;
                        }
                        else
                        {
                            Mover(field, moveCommand, rowP, colP);
                            colP += 1;
                        }
                    }
                    else
                    {
                        if (initialText.Length != 0)
                        {
                            initialText = initialText.Remove(initialText.Length - 1);
                        }
                    }
                }
            }

            Console.WriteLine(initialText);
            Printer(field);
        }

        static char[,] MatrixAdder(int size)
        {
            char[,] matrix = new char[size, size];
            var row = new char[] { };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                row = Console.ReadLine().ToCharArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = row[k];
                }
            }

            return matrix;
        }

        static int[] PositionFinder(char[,] matrix)
        {
            var position = new int[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] == 'P')
                    {
                        position[0] = i;
                        position[1] = k;

                        break;
                    }
                }
            }

            return position;
        }

        static bool SizeValidation(int size, params int[] position)
        {
            if (position[0] < 0 || position[0] > size - 1
                || position[1] < 0 || position[1] > size - 1)
            {
                return false;
            }

            return true;
        }

        static char[,] Mover(char[,] matrix, string command, int rowP, int colP)
        {
            if (command == "up")
            {
                matrix[rowP - 1, colP] = matrix[rowP, colP];
                matrix[rowP, colP] = '-';
            }
            else if (command == "down")
            {
                matrix[rowP + 1, colP] = matrix[rowP, colP];
                matrix[rowP, colP] = '-';
            }
            else if (command == "left")
            {
                matrix[rowP, colP - 1] = matrix[rowP, colP];
                matrix[rowP, colP] = '-';
            }
            else if (command == "right")
            {
                matrix[rowP, colP + 1] = matrix[rowP, colP];
                matrix[rowP, colP] = '-';
            }

            return matrix;
        }

        static void Printer(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write(matrix[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
