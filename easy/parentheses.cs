using System;
using System.Collections.Generic;
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

        /*

        program loops through string, checks if current char matches last item in stack before removing

        program lifecycle:

        create parentheses pairs
        create empty list
        make sure string length is even
        start loop
        check if current char is an opening parentheses
            if yes, add to stack
        else if current char matches last parentheses in stack
        if not, return false
        return true

        problems:

        program always return true if loop is succesful
        */


        for (int i = 0; i < s.Length; i++)
        {
            if (pars.ContainsKey(s[i]))
            {
                stack.Add(s[i]);
            }

            else if (stack.Count != 0 && pars[stack[stack.Count - 1]] == s[i]) 
            {
                stack.RemoveAt(stack.Count - 1);
            }
            
            else
            {
                return false;
            }

        }

        if (stack.Count == 0)
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

        Console.WriteLine(test.IsValid("]"));
    }
}
