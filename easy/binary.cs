using System;
using System.Collections.Generic;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        /*
        binary.cs

        receive 2 binary numbers

        create variable for end result

        create carry variable

        get lenght of both binary numbers

        start while i or j is bigger or equal than 0 whlie loop

        
        */
    }
}

class Program
{
    static void Main()
    {
        Solution test = new Solution();
        Console.WriteLine(test.AddBinary("10001", "10"));    //10011
        Console.WriteLine(test.AddBinary("1", "111"));       //1010
        Console.WriteLine(test.AddBinary("111", "111"));     //1110
        Console.WriteLine(test.AddBinary("101", "1100101")); //1101010
        Console.WriteLine(test.AddBinary("1011", "0010110")); //001
    }
}