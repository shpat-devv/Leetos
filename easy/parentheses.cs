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
        var pars = new Dictionary<char, char> {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'} 
        };
        
        List<char> stack = new List<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (pars.ContainsKey(s[i]))
            {
                stack.Add(s[i]);
            }

            else if (pars[stack[stack.Count - 1]] == s[i]) 
            {
                stack.RemoveAt(stack.Count - 1);
            }

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

        Console.WriteLine(test.IsValid("()"));
    }
}
