using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> str = new List<string>();
        int p = 0;
        while(p < N)
        {
            string text = Console.ReadLine();
            str.Add(text);
            p++;
        }
        for (int i = 0; i < N; i++)
        {
            string text = str[i];
            string even = "";
            string odd = "";
            for (int j = 0; j < text.Length; j++)
            {
                if (j == 0 || j % 2 == 0)
                    even += text[j];
                else
                    odd += text[j];
            }
            
            Console.WriteLine(even + " " + odd);
        }
    }
}