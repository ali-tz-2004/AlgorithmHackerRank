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
     * Complete the 'pokerNim' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY c
     */

    public static string pokerNim(int k, List<int> c)
    {
        int result = 0;
        foreach (int i in c)
        {
            result ^= i;
        }
        if (result == 0) return "Second";
        else return "First";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Result.pokerNim(2, [2,1,3]);
        //        10
        //        01
        //        11
        //result: 00
    }
}
