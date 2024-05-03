using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution
{
    public static void insertionSort(int[] A)
    {
        var result = A.ToList();
        for (int i = 0; i < result.Count; i++)
        {
            for (int j = i + 1; j < result.Count; j++)
            {
                if (result[i] < result[j]) continue;
                else
                {
                    var temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }

    static void Main(string[] args)
    {
        int[] _ar = [7, 4, 3, 5, 6, 2];
        insertionSort(_ar);
    }
}

