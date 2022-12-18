using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        int s1;    
        double e;
        string NewString;
        s1 = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        NewString = Console.ReadLine();
        // Declare second integer, double, and String variables.
        Console.WriteLine(s1 + i);
        Console.WriteLine("{0:F1}", d + e);
        Console.WriteLine(s + NewString);    
        // Read and save an integer, double, and String to your variables.
        
        // Print the sum of both integer variables on a new line.
        
        // Print the sum of the double variables on a new line.
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

    }
}