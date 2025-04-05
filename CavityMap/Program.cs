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
     * Complete the 'cavityMap' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static List<string> cavityMap(List<string> grid)
    {
        List<string> result = [.. grid];

        for (int i = 1; i < grid.Count - 1; i++)
        {
            StringBuilder stringBuilder = new StringBuilder(result[i]);

            for (int j = 1; j < grid[i].Length - 1; j++)
            {
                char current = grid[i][j];

                if (
                    current > grid[i][j - 1] && 
                    current > grid[i][j + 1] &&
                    current > grid[i - 1][j] && 
                    current > grid[i + 1][j]   
                   )
                {
                    stringBuilder[j] = 'X';
                }
            }

            result[i] = stringBuilder.ToString();
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Result.cavityMap(["989",
                          "191",
                          "111"]);
    }
}
