using System;
using System.Collections.Generic;

namespace Leetos.easy
{
    public class R2I
    {
        private Dictionary<char, int> r_nums = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public void RomanToInt(string s)
        {
            int res = 0;
            int y = 4000;

            foreach (char x in s)
            {
                int z = r_nums[x];

                if (z > y)
                {
                    z -= y * 2;
                }

                res += z;
                y = z;
            }

            Console.WriteLine(res);
        }
    }
}