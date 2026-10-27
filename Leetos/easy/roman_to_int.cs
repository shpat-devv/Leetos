using System;
using System.Collections.Generic;

public class Solution
{
    private Dictionary<char, int> r_nums = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public void RomanToInt(string s)
    {
        int res = 0;
        int y = 4000;

        foreach (char x in s)
        {
            int z = r_nums[x];

            if (z > y)
            {
                z -= y * 2;
            }

            res += z;
            y = z;
        }

        Console.WriteLine(res);
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        test.RomanToInt("III");
        test.RomanToInt("LVIII");
        test.RomanToInt("MCMXCIV");
    }
}
