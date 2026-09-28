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
    public void IsValid(string s)
    {
        if ((s.IndexOf(")") - s.IndexOf("(")) % 3 != 0)
        {
            Console.WriteLine("invalid");
        }

    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        test.valid_parantheses("()");
    }
}
