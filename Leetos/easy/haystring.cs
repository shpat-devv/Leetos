using System;
using System.Collections.Generic;
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if(needle == "") return 0;

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                string word = haystack.Substring(i, needle.Length);
                if (word == needle)
                {
                    return i;
                }
            }
        }

        return -1;
    }
    public int StrStr2(string haystack, string needle) //DOESNT WORK
    {
        while (true)
        {
            int haystack_length = haystack.Length;

            int first_ind = haystack.IndexOf(needle[0]);
            int last_ind = haystack.IndexOf(needle[^1]);

            Console.WriteLine($"{first_ind}, {last_ind}");
            Console.WriteLine(haystack);

            if (first_ind != -1 && last_ind != -1)
            {
                Console.WriteLine("check 1");

                if (first_ind < last_ind)
                {
                    Console.WriteLine("check 2");

                    if (last_ind - first_ind + 1 == needle.Length)
                    {
                        Console.WriteLine("check 3");

                        string word = haystack[first_ind..(last_ind + 1)];

                        Console.WriteLine(word);

                        if (word == needle)
                        {
                            return first_ind;
                        }
                    }

                    haystack = haystack[(first_ind + 1)..];
                }
                else
                {
                    haystack = haystack[first_ind..];
                }
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

        Console.WriteLine(test.StrStr("sabdutsad", "sad"));
    }
}
