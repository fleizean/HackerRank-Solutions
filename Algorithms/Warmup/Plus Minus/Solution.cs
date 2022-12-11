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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr, int n)
    {
        int i = 0;
        double pos = 0, neg = 0, zero = 0;
        while(i < n)
        {
            if(arr[i] > 0)
                pos++;
            else if(arr[i] < 0)
                neg++;
            else
                zero++;
            i++;
        }
        Console.WriteLine(string.Format("{0:N6}", (float) pos / n));
        Console.WriteLine(string.Format("{0:N6}", (float) neg / n));
        Console.WriteLine(string.Format("{0:N6}", (float) zero / n));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr, n);
    }
}
