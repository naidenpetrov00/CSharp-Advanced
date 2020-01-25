using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            var matrix = new int[size[0], size[1]];
            var position = new int[2];
            var result = new StringBuilder();
            int sum = 0;
            int max = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowValues = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if (rows == matrix.GetLength(0) - 2) { break; }

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (cols == matrix.GetLength(1) - 2)
                    {
                        break;
                    }
                    else
                    {
                        for (int pseudoRow = rows; pseudoRow < rows + 3; pseudoRow++)
                        {
                            for (int pseudoCol = cols; pseudoCol < cols + 3; pseudoCol++)
                            {
                                sum += matrix[pseudoRow, pseudoCol];
                            }
                        }

                        if (sum > max)
                        {
                            max = sum;
                            position[0] = rows;
                            position[1] = cols;
                        }
                    }

                    sum = 0;
                }
            }

            result.AppendLine($"Sum = {max}");

            for (int printRows = position[0]; printRows < position[0] + 3; printRows++)
            {
                for (int printCols = position[1]; printCols < position[1] + 3; printCols++)
                {
                    result.Append($"{matrix[printRows, printCols]}" + " ");
                }

                result.AppendLine();
            }

            Console.WriteLine(result);
        }
    }
}
