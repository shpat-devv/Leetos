using System;
using System.Collections.Generic;
public class Solution
{

    /*
        how to solve

        main() 
        {
            loop()
            {
                first_ind = get_first_index()
                last_ind = get_last_index()

                if (first_ind != -1 and last_ind != -1) 
                {
                    if (first_ind < last_ind) 
                    {
                        if (last_ind - first_ind == needle.length) 
                        {
                            word = haystack[last_ind, first_ind]

                            if (word == needle)
                            {
                                return first_ind
                            }
                        }
                    }
                haystack = haystack.substring(first_ind, needle.length)
                }

                return -1
            }
        }

    */
    public int StrStr(string haystack, string needle)
    {

        int res = -1;

        while (res == -1)
        {
            int first_ind = haystack.IndexOf(needle[0]);
            int last_ind = haystack.IndexOf(needle[^1]);
            
            if (first_ind != -1 && last_ind != -1) 
            {
                if (first_ind < last_ind) 
                {
                    if (last_ind - first_ind + 1 == needle.Length) 
                    {
                        string word = haystack.Substring(first_ind, last_ind);

                        if (word == needle)
                        {
                            return first_ind;
                        }
                    }
                }

                haystack = haystack.Substring(first_ind, needle.Length);
            }
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        Console.WriteLine(test.StrStr("sabdutsad", "sad"));
    }
}
