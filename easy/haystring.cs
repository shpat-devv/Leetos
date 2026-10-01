using System;
using System.Collections.Generic;
public class Solution
{

    /*

    retrieve a string and return first occurance of string using index of first char

    return -1 if needle not in haystack

    haystack always bigger than 1

    needle can be up to 10^4 big


    how we do this:

    program loop

    get first indexes of last and first char

    check if pulled string matches needle

    if not, cut string till needle index

    resume loop

    */
    public int StrStr(string haystack, string needle)
    {
        
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();

        Console.WriteLine(test.StrStr("sadbutsad", "sad"));
    }
}
