using System;
using System.Linq;

namespace _2.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var matrix = new string[size[0], size[1]];
            var countSquares = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows == matrix.GetLength(0) - 1)
                {
                    break;
                }

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (cols == matrix.GetLength(1) - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[rows, cols].Equals(matrix[rows, cols + 1])
                            && matrix[rows, cols].Equals(matrix[rows + 1, cols])
                            && matrix[rows, cols].Equals(matrix[rows + 1, cols + 1]))
                        {
                            countSquares++;
                        }
                    }
                }
            }

            Console.WriteLine(countSquares);
        }
    }
}
