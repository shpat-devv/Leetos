using System;
using System.Collections.Generic;


/*
PLANNING

how dis gna go

we receive string

string has diff parentheses 

string only consisnts of parentheses


*/
public class Solution
{
    public bool IsValid(string s)
    {
        if ((s.IndexOf(")") - s.IndexOf("(")) % 3 != 0)
        {
            return false;
        }

        if ((s.IndexOf("]") - s.IndexOf("[")) % 3 != 0)
        {
            return false;
        }

        if ((s.IndexOf("}") - s.IndexOf("{")) % 3 != 0)
        {
            return false;
        }

        return true;
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        Console.WriteLine(test.IsValid("(dfdff)"));
    }
}
