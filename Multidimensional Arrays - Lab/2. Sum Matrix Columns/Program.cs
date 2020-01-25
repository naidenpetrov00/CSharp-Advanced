using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();

            int[,,] matrix = new int[matrixSize[0], matrixSize[1], matrixSize[2]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] columnElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    for (int i = 0; i < matrixSize[2]; i++)
                    {
                    matrix[row, col, i] = columnElements[col];

                    }
                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
