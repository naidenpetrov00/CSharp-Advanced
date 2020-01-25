using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            var matrix = new int[sizes[0], sizes[1]];
            int max = int.MinValue;
            int sum = 0;
            int positionRows = 0;
            int positionCols = 0;
            var result = new StringBuilder();

            for (int row = 0; row < sizes[0]; row++)
            {
                var columnsValues = Console.ReadLine()
                    .Split(',')
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = columnsValues[col];
                }
            }

            for (int rows = 0; rows < sizes[0]; rows++)
            {
                if (rows == matrix.GetLength(0) - 1) { continue; }
                for (int cols = 0; cols < sizes[1]; cols++)
                {
                    if (cols == matrix.GetLength(1) - 1) { continue; }
                    else
                    {
                        sum = matrix[rows, cols]
                            + matrix[rows, cols + 1]
                            + matrix[rows + 1, cols]
                            + matrix[rows + 1, cols + 1];

                        if (sum > max)
                        {
                            max = sum;
                            positionRows = rows;
                            positionCols = cols;
                        }
                    }
                    sum = 0;
                }
            }

            result.AppendLine(matrix[positionRows, positionCols]+" "+ matrix[positionRows, positionCols+1]);
            result.AppendLine(matrix[positionRows+1, positionCols]+" "+ matrix[positionRows+1, positionCols+1]);
            result.Append(max);
            Console.WriteLine(result);
        }
    }
}
