using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'stones' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER a
     *  3. INTEGER b
     */

    public static List<int> stones(int n, int a, int b)
    {
        HashSet<int> results = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            int value = i * b + (n - 1 - i) * a;
            results.Add(value);
        }

        return results.OrderBy(x => x).ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> result = Result.stones(4, 10, 100);
    }
}
