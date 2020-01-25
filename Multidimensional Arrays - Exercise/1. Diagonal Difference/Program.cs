using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            var primaryDiagSum = 0;
            var secondaryDiagSum = 0;

            for (int row = 0; row < size; row++)
            {
                var rowValues = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    if (rows == cols)
                    {
                        primaryDiagSum += matrix[rows, cols];
                    }
                }
            }

            int floatRows = 0;

            for (int revC = size - 1; revC >= 0; revC--)
            {
                secondaryDiagSum += matrix[floatRows, revC];
                floatRows++;
            }

            Console.WriteLine(Math.Abs(primaryDiagSum - secondaryDiagSum));
        }
    }
}
