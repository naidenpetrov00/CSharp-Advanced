using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSizes = Console.ReadLine()
                .Split(new char[] { ',',' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSizes[0], matrixSizes[1]];
            var sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var columns = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = columns[cols];
                    sum += matrix[rows, cols];
                }
            }
            Console.WriteLine($"{matrix.GetLength(0)}");
            Console.WriteLine($"{matrix.GetLength(1)}");
            Console.WriteLine(sum);
        }
    }
}
