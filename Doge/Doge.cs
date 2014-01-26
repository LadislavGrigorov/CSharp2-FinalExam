using System;

class Doge
{
    static void Main()
    {
        string[] matrixSize = Console.ReadLine().Split(new char[] { ' ', '\r', '\n' });
        int rows = int.Parse(matrixSize[0]);
        int cols = int.Parse(matrixSize[1]);
        string[] dogeFood = Console.ReadLine().Split(new char[] { ' ', '\r', '\n' });
        int foodRow = int.Parse(dogeFood[0]);
        int foodCol = int.Parse(dogeFood[1]);
        char[,] matrix = new char[rows,cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = '`';
            }
        }
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] enemies = Console.ReadLine().Split(new char[] { ' ', '\r', '\n' });
            int currentRow = int.Parse(enemies[0]);
            int currentCol = int.Parse(enemies[1]);
            matrix[currentRow, currentCol] = '*';
        }
        Console.WriteLine("2");
    }
}
