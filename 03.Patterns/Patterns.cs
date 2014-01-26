using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                string[] colNums = Console.ReadLine().Split();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = int.Parse(colNums[col]);
                }
            }
            long maxSum = 0;
            for (int row = 0; row < size; row++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    long currentSum = 0;
                    if (row + 2 < size & cols + 4 < size)
                    {
                        if (matrix[row, cols] == (matrix[row, cols + 1] - 1) && matrix[row, cols] == (matrix[row, cols + 2] - 2) && matrix[row, cols] == (matrix[row + 1, cols + 2] - 3) && (matrix[row, cols] == matrix[row + 2, cols + 2] - 4 && matrix[row, cols] == (matrix[row + 2, cols + 3] - 5) && matrix[row, cols] == (matrix[row + 2, cols + 4] - 6)))
                        {
                            currentSum = matrix[row, cols] + matrix[row, cols + 1] + matrix[row, cols + 2] + matrix[row + 1, cols + 2] + matrix[row + 2, cols + 2] + matrix[row + 2, cols + 3] + matrix[row + 2, cols + 4];
                            if (currentSum > maxSum)
                            {
                                maxSum = currentSum;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("YES {0}", maxSum);
        }
    }
}
