using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            bool consist = false;
            char[] position = new char[] { '(', ' ', ',', ' ', ' ', ')' };

            for (int row = 0; row < matrixSize; row++)
            {
                char[] rowsValues = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowsValues[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < matrixSize; rows++)
            {
                for (int cols = 0; cols < matrixSize; cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        consist = true;
                        position[1] = char.Parse($"{rows}");
                        position[4] = char.Parse($"{cols}");
                        break;
                    }
                }
                if (consist) { break; }
            }

            if (consist)
            {
                Console.WriteLine(string.Join("", position));
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
