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

        int[] rowMax = new int[rowLen];
        int[] colMin = new int[colLen];

        //precompute max values per row
        for (int i = 0; i < rowLen; i++)
        {
            rowMax[i] = matrix[i, 0];
            for (int j = 0; j < colLen; j++)
            {
                if (matrix[i, j] > rowMax[i]) rowMax[i] = matrix[i, j];
            }
        }
        //precompute min values per col
        for (int i = 0; i < colLen; i++)
        {
            colMin[i] = matrix[0, i];
            for (int j = 0; j < rowLen; j++)
            {
                if (matrix[j, i] < colMin[i]) colMin[i] = matrix[j, i];
            }
        }

        //iterate thru whole array
        //check if each member is equal to the max and min of its row
        //if so yield its coords
        for (int i = 0; i < rowLen; i++)
        {
            for (int j = 0; j < colLen; j++)
            {
                if (matrix[i, j] == rowMax[i] && matrix[i, j] == colMin[j])
                {
                    yield return (i + 1, j + 1);
                }
            }
        }
        Console.WriteLine("");
        //throw new NotImplementedException("You need to implement this method.");
    }
}
