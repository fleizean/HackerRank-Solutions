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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int temp = 0, swapCount = 0, last = a.Count - 1;
        // Write your code here
        for (int i = 0; i <= a.Count - 1; i++)
        {
            for (int j = 1; j <= a.Count - 1; j++)
            {
                if (a[j - 1] > a[j])
                {
                    temp = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = temp;
                    swapCount++;
                }
            }
        }
        Console.WriteLine("Array is sorted in " + swapCount + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[last]);
    }
}
