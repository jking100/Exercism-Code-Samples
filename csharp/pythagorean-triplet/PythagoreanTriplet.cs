using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> triplets = [];
        //given
        //a2+b2=c2
        //a<b<c
        //sum = a+b+c

        //deduce
        //all are >= 1
        //a+b > c

        //ideas:
        //generate all combos of a and b and c that add to sum

        int c;

        for (int a = 1; a <= (sum / 2); a++)
        {
            for (int b = a; b < (sum - (a + b)); b++)
            {
                c = (int)Math.Pow((sum - (a + b)), 2);
                if (a * a + b * b == c)
                {
                    triplets.Add((a, b, (sum - (a + b))));
                }
            }
        }

        return triplets.ToArray();
    }
}