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
using System.Text.Json.Nodes;
using System.Text.Json;

class Result
{

    /*
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        var result = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[i] + arr[j] == m)
                {
                    result.Add(i + 1);
                    result.Add(j + 1);
                    break;
                }
            }
            if (result.Count != 0) break;
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int m = 4;
        List<int> arr = [2, 2, 4, 3];
        Result.icecreamParlor(m, arr);
    }
}
