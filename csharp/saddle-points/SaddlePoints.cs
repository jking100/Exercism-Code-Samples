using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public static class SaddlePoints
{
    public static bool IsTallestInRow(int[,] matrix, int x, int y)
    {
        int rowLen = matrix.GetLength(0);
        int colLen = matrix.GetLength(1);

        for (int i = 0; i < colLen; i++)
        {
            if (i == y) continue;
            if (matrix[x, i] > matrix[x, y])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsShortestInCol(int[,] matrix, int x, int y)
    {
        int rowLen = matrix.GetLength(0);
        int colLen = matrix.GetLength(1);

        for (int i = 0; i < rowLen; i++)
        {
            if (i == x) continue;
            if (matrix[i, y] < matrix[x, y])
            {
                return false;
            }
        }
        return true;
    }

    private static bool valid(int[,] matrix, int x, int y)
    {
        if (IsShortestInCol(matrix, x, y) && IsTallestInRow(matrix, x, y))
        {
            return true;
        }
        return false;
    }

    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rowLen = matrix.GetLength(0);
        int colLen = matrix.GetLength(1);
        /*
        int[] rowMax = new int[rowLen];
        int[] colMax = new int[colLen];
        */
        for (int i = 0; i < rowLen; i++)
        {
            for (int j = 0; j < colLen; j++)
            {
                if (valid(matrix, i, j)) yield return (i + 1, j + 1);
            }
        }
        //throw new NotImplementedException("You need to implement this method.");
    }
}
