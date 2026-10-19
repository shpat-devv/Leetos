using System;
using System.Collections.Generic;
using System.Globalization;


namespace ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            TargetIndices([1,2,5,2,3], 2);
        }

        public static IList<int> TargetIndices(int[] nums, int target) {
            List<int> res = [];

            int n = nums.Length;

            for (int i = 1; i < n; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    nums[j] = key;
                    j -= 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == target)
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}