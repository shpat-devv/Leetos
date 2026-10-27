using System;
using System.Collections.Generic;

namespace Leetos.easy
{
    public class Palindrome
    {
        public bool isPalindrome(int x)
        {
            String x_str = x.ToString();
            String y_str = "";

            for (int i = x_str.Length - 1; i >= 0; i--)
            {
                y_str += x_str[i];
            }

            if (x_str == y_str)
            {
                return true;
            }

            return false;
        }
    }
}