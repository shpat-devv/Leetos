using System;
using System.Collections.Generic;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();
        Console.WriteLine(test.AddBinary("101", "001"));
    }
}