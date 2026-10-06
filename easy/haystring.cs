using System;
using System.Collections.Generic;
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        /*
            loop through haystack - needle.len

            check if current char is first char

            if first char, create substring and compare to needle

            return current index if match

            return -1 at end
        */

        return -1;
    }
    public int StrStr2(string haystack, string needle)
    {
        while (true)
        {
            int first_ind = haystack.IndexOf(needle[0]);
            int last_ind = haystack.IndexOf(needle[^1]);
            
            Console.WriteLine($"{first_ind }, {last_ind}");

            if (first_ind != -1 && last_ind != -1) 
            {
                if (first_ind < last_ind) 
                {
                    if (last_ind - first_ind + 1 == needle.Length) 
                    {
                        string word = haystack.Substring(first_ind, last_ind);
                        
                        Console.WriteLine(word);

                        if (word == needle)
                        {
                            return first_ind;
                        }
                    }
                }
                haystack = haystack.Substring(first_ind + 1, needle.Length);
            }
            else
            {
                return -1;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        Console.WriteLine(test.StrStr2("sabdutsad", "sad"));
    }
}
