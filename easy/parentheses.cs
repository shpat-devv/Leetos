using System;
using System.Collections.Generic;


/*
Program.cs:

func isValid()
{
    s = "([{}])"
    stack = []
    parents = {
        "(":")",
        "[":"]",
        "{":"}".
    }


    loop through s
    {
        if parents.containsKey(s) 
        {
            stack.add(s)
        } 

        else 
        {
            if parents.getvalue(stack[-1]) == s 
            {
                stack.remove(-1)
            }

            return false
        }
    }

    return true
}
*/
public class Solution
{
    public bool IsValid(string s)
    {
        
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
