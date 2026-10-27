using System;
using System.Collections.Generic;

public class Solution
{
    public bool isPalindrome(int x)
    {
        String x_str = x.ToString();
        String y_str = "";

        for (int i = x_str.Length - 1; i >= 0; i--)
        {
            y_str += x_str[i];
        }

        if (x_str == y_str)
        {
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        Console.WriteLine(test.isPalindrome(121));
        Console.WriteLine(test.isPalindrome(1001));
        Console.WriteLine(test.isPalindrome(1424));
    }
}