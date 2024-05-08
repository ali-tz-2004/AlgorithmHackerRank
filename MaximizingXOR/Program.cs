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
     * Complete the 'maximizingXor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER l
     *  2. INTEGER r
     */

    public static int maximizingXor(int l, int r)
    {
        var result = 0;
        var countCheck = r - l;

        for (int i = l; i < r; i++)
        {
            for (int j = 0; j <= countCheck; j++)
            {
                var xor = i ^ (i + j);
                if (xor > result) result = xor;
            }
            countCheck--;
        }
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Result.maximizingXor(10, 15);
    }
}
