using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var n = int.Parse(Console.ReadLine());
        var phoneBook = new Dictionary<string, int>();
        for(var i = 0; i < n; i++)
        {
            var text = Console.ReadLine().Split(' ');
            var name = text[0];
            var phone = int.Parse(text[1]);
            phoneBook.Add(name, phone);
        }
        string name_txt;
        while ((name_txt = Console.ReadLine()) != null) {
            if (phoneBook.ContainsKey(name_txt)) {
                Console.WriteLine(name_txt + "=" + phoneBook[name_txt]);
            }
            else {
                Console.WriteLine("Not found");
            }
        }
    }
}
