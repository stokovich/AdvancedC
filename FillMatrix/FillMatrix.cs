using System;
class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char type = char.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 0;

        if (type == 'a')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter + 1;
                    counter++;
                }
            }
        }
        else if (type == 'b')
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = counter + 1;
                        counter++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = counter + 1;
                        counter++;
                    }
                }
            }
        }
    }
}
