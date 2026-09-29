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

        if (s.Length % 2 == 0) 
        {
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
                
                else
                {
                    return false;
                }

            }
    
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

        Console.WriteLine(test.IsValid("("));
    }
}
