using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];
            var sum = 0;

            for (int row = 0; row < size; row++)
            {
                var columnsValues = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = columnsValues[col];
                }
            }

            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    if (rows == cols)
                    {
                        sum += matrix[rows, cols];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
